using Lesson2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers;

public class StudentController : Controller
{
    public IActionResult Info()
    {
        ViewBag.Name = "Lê Xuân Bảo";
        ViewData["Age"] = 20;

        var student = new Student
        {
            Major = "CNTT"
        };

        return View(student);
    }
}
