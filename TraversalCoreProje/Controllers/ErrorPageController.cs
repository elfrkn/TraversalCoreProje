using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index(int code)
        {

            return View();
        }
    }
}
