using Microsoft.AspNetCore.Mvc;

namespace ABCDMallClient.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
