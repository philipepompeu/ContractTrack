using Microsoft.AspNetCore.Mvc;

namespace ContractTrack.Controllers
{
    public class PlanTemplatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
