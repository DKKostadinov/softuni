using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string NewLine = "\r\n";
            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 1234);
            tcpListener.Start();
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                using (NetworkStream networkStream = tcpClient.GetStream())
                {

                    //TODO use buffer
                    byte[] requestBytes = new byte[1000000];
                    int bytesRead = networkStream.Read(requestBytes, 0, requestBytes.Length);
                    string request = Encoding.UTF8.GetString(requestBytes, 0, bytesRead);
                    string responseText = "<h1> Hello </h1>";
                    string response = "HTTP/1.0 200 OK" + NewLine +
                                      "Server: LocalServer/1.0" + NewLine +
                                      "Content-Type: text/html" + NewLine +
                                      "Content-Disposition: attacment; filename=hello.html" + NewLine +
                                      "Content-Length: " + responseText.Length + NewLine +
                                      NewLine +
                                      responseText;
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    networkStream.Write(responseBytes, 0, responseBytes.Length);
                    Console.WriteLine(request);
                    Console.WriteLine(new string('-', 60));
                }

            }

        }
    }
}
