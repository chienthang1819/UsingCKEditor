using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class TestModel
    {
        [AllowHtml]
        public string Message { get; set; }
    }
}