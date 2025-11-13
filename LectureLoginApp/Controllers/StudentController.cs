using Microsoft.AspNetCore.Mvc;

namespace SchoolLoginApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
