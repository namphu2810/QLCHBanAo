using Microsoft.AspNetCore.Mvc;

namespace QLCHBanAo.Controllers
{
    public class DashBoard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
