using Microsoft.AspNetCore.Mvc;
using LectureLoginApp.Models;

namespace LectureLoginApp.Controllers
{
    public class LecturerViewController : Controller
    {
        // Default action -> URL will be /LecturerView
        public IActionResult Index()
        {
            // Temporary dummy data for testing
            var students = new List<Student>
            {
                new Student { Name = "Student 01", Index = "12345", CamId = "12345", IsOnline = true },
                new Student { Name = "Student 02", Index = "12346", CamId = "12346", IsOnline = false },
                new Student { Name = "Student 03", Index = "12347", CamId = "12347", IsOnline = true },
                new Student { Name = "Student 04", Index = "12348", CamId = "12348", IsOnline = true }
            };

            return View("LecturerView", students);
        }
    }
}
