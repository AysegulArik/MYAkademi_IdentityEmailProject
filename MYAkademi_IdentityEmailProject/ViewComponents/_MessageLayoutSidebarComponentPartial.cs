using Microsoft.AspNetCore.Mvc;

namespace MYAkademi_IdentityEmailProject.ViewComponents
{
    public class _MessageLayoutSidebarComponentPartial : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
