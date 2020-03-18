using System.IO;
using System.Runtime.CompilerServices;
using SIS.HTTP;
using SIS.HTTP.Response;

namespace SIS.MvcFramework
{
    public abstract class Controller
    {
        protected HttpResponse View<T>(T viewModel = null, [CallerMemberName] string viewName = null)
            where T : class
        {
            var viewEngine = new ViewEngine();


            var typeName = this.GetType().Name;
            var controllerName = this.GetType().Name.Replace("Controller", string.Empty);
            var html = File.ReadAllText("Views/" + controllerName + "/" + viewName + ".html");
            html = viewEngine.GetHtml(html, viewModel);

            var layout = File.ReadAllText("Views/Shared/_Layout.html");
            var bodyWithLayout = layout.Replace("@RenderBody()", html);
            bodyWithLayout = viewEngine.GetHtml(bodyWithLayout, viewModel);
            return new HtmlResponse(bodyWithLayout);
        }

        protected HttpResponse View(object viewModel = null, [CallerMemberName] string viewName = null)
        {
            return this.View<object>(null, viewName);
        }
    }
}