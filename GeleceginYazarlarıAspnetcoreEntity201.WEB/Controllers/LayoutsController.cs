using Microsoft.AspNetCore.Mvc;

namespace GeleceginYazarlarıAspnetcoreEntity201.WEB.Controllers
{
    public class LayoutsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
