
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework;

namespace DemoApp
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            await WebHost.StartAsync(new Startup());
        }

        

    }
}
