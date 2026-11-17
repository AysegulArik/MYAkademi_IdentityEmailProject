using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MYAkademi_IdentityEmailProject.Context;
using MYAkademi_IdentityEmailProject.Entities;

namespace MYAkademi_IdentityEmailProject.Controllers
{
    //[Authorize]
    public class MessageController : Controller
    {
        private readonly EmailContext _context;

        public MessageController(EmailContext context)
        {
            _context = context;
        }

        public IActionResult Inbox()
        {
            var values=_context.Messages.ToList();
            return View(values);
        }
        public IActionResult CreateMessage()
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {

            return RedirectToAction("Sendbox");
        }
    }
}
