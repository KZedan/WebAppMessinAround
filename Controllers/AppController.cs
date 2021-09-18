using Microsoft.AspNetCore.Mvc;
using WebAppMessinAroundEmpty.Services;
using WebAppMessinAroundEmpty.ViewModels;

namespace WebAppMessinAroundEmpty.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("Kareem335@yahoo.co.uk", contactViewModel.Subject, contactViewModel.Message);
                ViewBag.UserMessage = "Mail Sent";
            }

            return View();
        }

        public IActionResult Error() 
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
