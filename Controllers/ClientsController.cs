using Microsoft.AspNetCore.Mvc;

namespace ContractTrack.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
