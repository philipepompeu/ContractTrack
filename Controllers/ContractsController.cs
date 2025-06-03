using Microsoft.AspNetCore.Mvc;

namespace ContractTrack.Controllers
{
    public class ContractsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
