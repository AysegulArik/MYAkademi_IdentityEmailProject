using Microsoft.AspNetCore.Mvc;

namespace MYAkademi_IdentityEmailProject.ViewComponents
{
    public class _MessageLayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
