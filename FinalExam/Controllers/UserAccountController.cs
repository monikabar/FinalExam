using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    public class UserAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
