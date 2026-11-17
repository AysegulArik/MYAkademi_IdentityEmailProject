using Microsoft.AspNetCore.Mvc;

namespace MYAkademi_IdentityEmailProject.ViewComponents.MessageLayoutViewComponents
{
    public class _MessageLayoutStyleComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
