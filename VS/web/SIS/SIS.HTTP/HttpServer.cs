using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SIS.HTTP
{
    public class HttpServer : IHttpServer
    {
        private readonly IList<Route> routeTable;
        private readonly TcpListener tcpListener;
        private readonly IDictionary<string, IDictionary<string, string>> 
            sessions = new Dictionary<string, IDictionary<string, string>>();

        public HttpServer(int port, IList<Route> routeTable)
        {
            this.routeTable = routeTable;
            this.tcpListener = new TcpListener(IPAddress.Loopback, port);
            this.sessions = new Dictionary<string, IDictionary<string, string>>();
        }

        public async Task ResetAsync()
        {
            this.Stop();
            await this.StartAsync();
        }

        public async Task StartAsync()
        {
            while (true)
            {
                tcpListener.Start();
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
#pragma warning disable CS4014
                Task.Run(() => ProcessClientAsync(tcpClient));
#pragma warning restore CS4014
            }
        }

        private async Task ProcessClientAsync(TcpClient tcpClient)
        {

            using NetworkStream networkStream = tcpClient.GetStream();
            try
            {
                byte[] requestBytes = new byte[1000000];
                int bytesRead = await networkStream.ReadAsync(requestBytes, 0, requestBytes.Length);
                string requestAsString = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);

                var request = new HttpRequest(requestAsString);
                string newSessionId = null;
                var sessionCookie = request.Cookies.FirstOrDefault(x => x.Name == HttpConstants.SessionIdCookieName);
                if (sessionCookie != null && this.sessions.ContainsKey(sessionCookie.Value))
                {
                    request.SessionData = this.sessions[sessionCookie.Value];
                }
                else
                {
                    newSessionId = Guid.NewGuid().ToString();
                    var dictionary = new Dictionary<string,string>();
                    this.sessions.Add(newSessionId, dictionary);
                    request.SessionData = dictionary;
                }
                Console.WriteLine($"{request.Method} {request.Path}");

                var route = this.routeTable.FirstOrDefault(
                    x => x.HttpMethod == request.Method && x.Path == request.Path);
                HttpResponse response;
                if (route == null)
                {
                    response = new HttpResponse(HttpResponseCode.NotFound, new byte[0]);
                }
                else
                {
                    response = route.Action(request);
                }
                response.Headers.Add(new Header("Server", "SoftUniServer/1.0"));

                if (newSessionId != null)
                {
                    response.Cookies.Add(new ResponseCookie(HttpConstants.SessionIdCookieName, newSessionId) 
                        { HttpOnly = true, MaxAge = 30*24*3600, });
                }
                
                


                byte[] responseBytes = Encoding.UTF8.GetBytes(response.ToString());
                await networkStream.WriteAsync(responseBytes, 0, responseBytes.Length);
                await networkStream.WriteAsync(response.Body, 0, response.Body.Length);


            }
            catch (Exception e)
            {
                var errorResponse = new HttpResponse(
                    HttpResponseCode.InternalServerError, 
                    Encoding.UTF8.GetBytes(e.ToString()));
                errorResponse.Headers.Add(new Header("Content-Type", "text/plain"));

                byte[] responseBytes = Encoding.UTF8.GetBytes(errorResponse.ToString());
                await networkStream.WriteAsync(responseBytes, 0, responseBytes.Length);
                await networkStream.WriteAsync(errorResponse.Body, 0, errorResponse.Body.Length);
            }
            
        }

        public void Stop()
        {
            this.tcpListener.Stop();
        }
    }
}