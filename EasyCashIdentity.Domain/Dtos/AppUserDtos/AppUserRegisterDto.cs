using System.ComponentModel.DataAnnotations;

namespace EasyCashIdentity.Domain.Dtos.AppUserDtos;

public class AppUserRegisterDto
{
    [Required(ErrorMessage = "Ad alanı Zorunludur")]
    [Display(Name = "İsim")]
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}