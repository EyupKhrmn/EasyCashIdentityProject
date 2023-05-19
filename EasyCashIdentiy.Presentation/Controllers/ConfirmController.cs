using System.Security.Claims;
using EasyCashIdentity.Domain.Entites;
using EasyCashIdentiy.Presentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentiy.Presentation.Controllers;

public class ConfirmController : Controller
{
    [HttpGet]
    public IActionResult Index(int id)
    {
        var value = TempData["Mail"];
        ViewBag.v = value;
        return View();
    }

    // [HttpPost]
    // public IActionResult COnfirMail(ConfirmMailViewModel confirmMailViewModel)
    // {
    //     return View();
    // }
}