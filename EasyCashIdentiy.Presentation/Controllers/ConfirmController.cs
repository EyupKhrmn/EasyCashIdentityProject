using System.Security.Claims;
using EasyCashIdentity.Domain.Dtos.AppUserDtos;
using EasyCashIdentity.Domain.Entites;
using EasyCashIdentiy.Presentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentiy.Presentation.Controllers;

public class ConfirmController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public ConfirmController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
     public IActionResult Index(int id)
     {
         var value = TempData["Mail"];
         ViewBag.v = value;
         return View();
     }

    [HttpPost]
    public async Task<IActionResult> Index(ConfirmMailViewModel confirmMailViewModel)
    {
        var value = confirmMailViewModel.Email;
        var user = await _userManager.FindByEmailAsync(value);
        if (user.ConfirmCode == confirmMailViewModel.ConfirmCode)
        {
            user.EmailConfirmed = true;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index","Login");
        }

        return RedirectToAction("Index", "Confirm");
    }
}