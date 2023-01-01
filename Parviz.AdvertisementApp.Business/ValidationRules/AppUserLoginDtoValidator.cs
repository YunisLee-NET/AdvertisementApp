using FluentValidation;
using Parviz.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Business.ValidationRules
{
    public class AppUserLoginDtoValidator:AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Məlumat daxil edilməlidir!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Məlumat daxil edilməlidir!");
        }

    }
}
