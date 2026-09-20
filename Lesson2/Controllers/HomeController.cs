using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lesson2.Models;

namespace Lesson2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Content("Welcome to ASP.NET MVC");
    }

    public IActionResult About()
    {
        return Content("Lê Xuân Bảo");
    }

    public IActionResult Contact()
    {
        return Content("lexuanbao258@gmail.com");
    }
}