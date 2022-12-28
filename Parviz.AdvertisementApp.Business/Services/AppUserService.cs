using AutoMapper;
using FluentValidation;
using Parviz.AdvertisementApp.Business.Interfaces;
using Parviz.AdvertisementApp.DataAccess.UnitOfWork;
using Parviz.AdvertisementApp.Dtos;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Business.Services
{
    public class AppUserService : Service<AppUserCreateDto, AppUserListDto, AppUserUpdateDto, AppUser>, IAppUserService
    {
        public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> creatoDtoValidator, IValidator<AppUserUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, creatoDtoValidator, updateDtoValidator, uow)
        {
        }
    }
}
