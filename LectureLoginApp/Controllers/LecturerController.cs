using Microsoft.AspNetCore.Mvc;

namespace SchoolLoginApp.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
