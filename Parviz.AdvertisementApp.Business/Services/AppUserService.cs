using AutoMapper;
using FluentValidation;
using Parviz.AdvertisementApp.Business.Extensions;
using Parviz.AdvertisementApp.Business.Interfaces;
using Parviz.AdvertisementApp.Common;
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
        private readonly IMapper _mapper;
        private readonly IUOW _uow;
        private readonly IValidator<AppUserCreateDto> _createAppUserDtoValidator;
        public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> creatoDtoValidator, IValidator<AppUserUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, creatoDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
            _uow = uow;
            _createAppUserDtoValidator = creatoDtoValidator;
        }

        public async Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId)
        { 
            var validationResult = _createAppUserDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var userMapingData = _mapper.Map<AppUser>(dto);
                await _uow.GetRepository<AppUser>().AddAsync(userMapingData);

                await _uow.GetRepository<AppUserRole>().AddAsync(new AppUserRole
                {
                    AppUser = userMapingData,
                    AppRoleId = roleId
                });
                await _uow.SaveChangesAsync();
                return new Response<AppUserCreateDto>(ResponseType.Success, dto);

            }
            else
            {
                return new Response<AppUserCreateDto>(ResponseType.ValidationError, validationResult.ConvertValidationFromCustomValidationError(), dto);
            }
        }
    }
}
