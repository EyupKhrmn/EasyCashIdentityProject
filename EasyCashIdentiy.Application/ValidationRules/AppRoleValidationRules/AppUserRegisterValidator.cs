using EasyCashIdentity.Domain.Dtos.AppUserDtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EasyCashIdentiy.Application.ValidationRules.AppRoleValidationRules;

public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
{
    public AppUserRegisterValidator()
    {
        RuleFor(_ => _.Name).NotEmpty().WithMessage("İsim Kısmı Boş Geçilemez").MaximumLength(30)
            .WithMessage("İsim alanı 30 Karakterden fazla olamaz").MinimumLength(2)
            .WithMessage("İsim alanı en az 2 karakter Olmalıdır");
        RuleFor(_ => _.Surname).NotEmpty().WithMessage("Soyad Kısmı Boş Geçilemez");
        RuleFor(_ => _.Username).NotEmpty().WithMessage("Username Kısmı Boş Geçilemez");
        RuleFor(_ => _.Email).NotEmpty().WithMessage("Mail Kısmı Boş Geçilemez").EmailAddress()
            .WithMessage("Geçerli bir Mail formatı giriniz!");
        RuleFor(_ => _.Password).NotEmpty().WithMessage("Şifre Kısmı Boş Geçilemez");
        RuleFor(_ => _.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Kısmı Boş Geçilemez")
            .Equal(x => x.Password).WithMessage("Parolalar Eşleşmedi !");
    }
}