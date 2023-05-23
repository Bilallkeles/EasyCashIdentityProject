using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("ad alanı boş geçmeyin");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("soyadı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("mail adresi boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("şifrenizi girin");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("şifrenizi girin");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("şifre uzunluğu");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Password");
        }
    }
}
