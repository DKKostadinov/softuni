using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoApp;
using SIS.HTTP;
using SIS.MvcFramework;
using SulsApp.Controllers;

namespace SulsApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await WebHost.StartAsync(new Startup());
        }
    }
}
