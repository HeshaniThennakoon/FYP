using Microsoft.AspNetCore.Mvc;

namespace SchoolLoginApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(string role, string name, string regNo, string academicYear, string batch,
                                    string department, string email, string phone)
        {
            // TODO: Save to database
            TempData["Success"] = "Account created successfully!";
            return RedirectToAction("Login", "Account");
        }
    }
}
