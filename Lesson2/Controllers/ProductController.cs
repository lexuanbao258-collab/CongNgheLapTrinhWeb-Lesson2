using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers;

public class ProductController : Controller
{
    public IActionResult Detail(int? id)
    {
        if (!id.HasValue || !ModelState.IsValid || id.Value <= 0)
        {
            return Content("Product ID không hợp lệ hoặc chưa được cung cấp.");
        }

        return Content($"Product ID = {id.Value}");
    }

    public IActionResult Category(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Content("Category name không được để trống.");
        }

        return Content($"Category = {name.Trim()}");
    }
}
