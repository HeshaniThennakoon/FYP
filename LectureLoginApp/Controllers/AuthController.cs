using Microsoft.AspNetCore.Mvc;

namespace SchoolLoginApp.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password, string role)
        {
            // TODO: Add authentication logic here
            if (email == "lecturer@uni.lk" && password == "Pass@123" && role == "Teacher")
            {
                return RedirectToAction("Dashboard", "Home");
            }
            else if (email == "student@uni.lk" && password == "Pass@123" && role == "Student")
            {
                return RedirectToAction("Dashboard", "Home");
            }

            ViewBag.Error = "Invalid login attempt!";
            return View();
        }


        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
            // TODO: Implement email reset logic
            ViewBag.Message = $"If {email} is registered, a reset link will be sent.";
            return View();
        }

    }
}
