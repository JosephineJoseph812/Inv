using Microsoft.AspNetCore.Mvc;

namespace Inv.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
