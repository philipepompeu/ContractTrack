using Microsoft.AspNetCore.Mvc;

namespace ContractTrack.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
