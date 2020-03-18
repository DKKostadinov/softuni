using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SIS.MvcFramework.Tests
{
    public class ErrorView : IView
    {
        private readonly IEnumerable<string> errors;

        public ErrorView(IEnumerable<string> errors)
        {
            this.errors = errors;
        }

        public string GetHtml(object model)
        {
            StringBuilder html = new StringBuilder();
            html.AppendLine("<h1>View compilation errors:</h1>");
            html.AppendLine("<ul>");
            foreach (var error in errors)
            {
                html.Append($"<li>{error}</li>");
            }

            html.AppendLine("</ul>");

            return html.ToString();
        }
    }
}