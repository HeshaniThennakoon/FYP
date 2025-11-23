using Microsoft.AspNetCore.Mvc;

namespace SchoolLoginApp.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
