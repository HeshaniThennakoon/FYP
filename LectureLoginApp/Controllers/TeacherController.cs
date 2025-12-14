using Microsoft.AspNetCore.Mvc;

namespace LectureLoginApp.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
