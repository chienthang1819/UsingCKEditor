using System.IO;
using System.Web.Mvc;
using System.Web.Util;

namespace MvcApplication1.Models
{
    public class CustomHttpEncoder : HttpEncoder
    {
        protected override void HtmlEncode(string value, TextWriter output)
        {
            base.HtmlEncode(value, output);
        }

        protected override void HtmlAttributeEncode(string value, TextWriter output)
        {
            base.HtmlAttributeEncode(value, output);
        }
    }

    public class TestModel
    {
        [AllowHtml]
        public string Message { get; set; }
    }
}