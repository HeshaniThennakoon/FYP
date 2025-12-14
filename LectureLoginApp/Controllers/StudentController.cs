using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LectureLoginApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        // [HttpPost]
        // public IActionResult StartSharing()
        // {
        //     try
        //     {
        //         var psi = new ProcessStartInfo();
        //         psi.FileName = "cmd.exe";
        //         psi.Arguments = "/c start \"\" \"C:\\Users\\hesha\\AppData\\Local\\Programs\\Python\\Python311\\python.exe\" \"E:\\5.Projects\\Final Year Project\\FaceDetection\\main.py\"";
        //         psi.UseShellExecute = true;
        //         psi.CreateNoWindow = false;

        //         Process.Start(psi);

        //         return Ok("Screen sharing started successfully.");
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest (ex.Message);
        //     }
        // }
    }
}
