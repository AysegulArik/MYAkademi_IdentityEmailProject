using Microsoft.AspNetCore.Mvc;

namespace MYAkademi_IdentityEmailProject.Controllers
{
    public class MessageLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
