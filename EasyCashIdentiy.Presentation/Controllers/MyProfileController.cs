using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentiy.Presentation.Controllers;

public class MyProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}