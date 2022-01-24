using Microsoft.AspNetCore.Mvc;

namespace HotelListing.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
