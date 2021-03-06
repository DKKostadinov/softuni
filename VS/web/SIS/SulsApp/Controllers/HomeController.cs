using System;
using System.IO;
using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework;
using SulsApp.ViewModels;

namespace SulsApp.Controllers
{
    public class HomeController : Controller
    {
        public HttpResponse Index(HttpRequest request)
        {
            var viewModel = new IndexViewModel
            {
                Message = "Welcome to SULS Platform!",
                Year = DateTime.UtcNow.Year,
            };
            return this.View(viewModel);
        }
    }
}