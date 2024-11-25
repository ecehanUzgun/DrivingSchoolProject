using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
