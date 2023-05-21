using EasyCashIdentity.Domain.Dtos.AppUserDtos;
using EasyCashIdentity.Domain.Entites;
using EasyCashIdentiy.Presentation.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EasyCashIdentiy.Presentation.Controllers;

public class RegisterController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public RegisterController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
    {
        if (ModelState.IsValid)
        {
            Random rnd = new Random();
            int code = rnd.Next(100000, 1000000);
            AppUser appUser = new AppUser()
            {
                UserName = appUserRegisterDto.Username,
                Name = appUserRegisterDto.Name,
                Surname = appUserRegisterDto.Surname,
                Email = appUserRegisterDto.Email,
                City = appUserRegisterDto.City,
                District = appUserRegisterDto.District,
                ImageUrl = appUserRegisterDto.ImageUrl,
                ConfirmCode = code
            };
            
            var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
            
            if (result.Succeeded)
            {
                MimeMessage mimeMessage = new MimeMessage();
                MailboxAddress mailboxAddressFrom = new MailboxAddress("Easy Cash Admin", "eyupkhrmn45@gmail.com");
                MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                mimeMessage.From.Add(mailboxAddressFrom);
                mimeMessage.To.Add(mailboxAddressTo);

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Kayıt işlemini Gerçekleştirmek için onay Kodunuz: " + code;
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                mimeMessage.Subject = "Easy Cash Onay Kodu";

                SmtpClient client = new SmtpClient();
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("eyupkhrmn45@gmail.com","tshvkdifmrslkwjo");
                client.Send(mimeMessage);
                client.Disconnect(true);

                TempData["Mail"] = appUserRegisterDto.Email;
                
                return RedirectToAction("Index","Confirm");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("",item.Description);
            }
        }

        return View();
    }
}