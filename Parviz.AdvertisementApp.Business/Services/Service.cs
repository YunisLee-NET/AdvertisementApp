using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using Parviz.AdvertisementApp.Business.Extensions;
using Parviz.AdvertisementApp.Business.Interfaces;
using Parviz.AdvertisementApp.Common;
using Parviz.AdvertisementApp.DataAccess.UnitOfWork;
using Parviz.AdvertisementApp.Dtos.Inferfaces;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Business.Services
{
    public class Service<CreateDto, ListDto, UpdateDto, T> : IService<CreateDto, ListDto, UpdateDto, T>
        where CreateDto : class, IDto, new()
        where ListDto : class, IDto, new()
        where UpdateDto : class, IUpdateDto, new()
        where T : BaseEntity
    {
        private readonly IMapper _mapper;
        private readonly IValidator<CreateDto> _creatoDtoValidator;
        private readonly IValidator<UpdateDto> _updateDtoValidator;
        private readonly IUOW _uow;

        public Service(IMapper mapper, IValidator<CreateDto> creatoDtoValidator, IValidator<UpdateDto> updateDtoValidator, IUOW uow)
        {
            _mapper = mapper;
            _creatoDtoValidator = creatoDtoValidator;
            _updateDtoValidator = updateDtoValidator;
            _uow = uow;
        }

        public async Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
        {
            var validationresult = _creatoDtoValidator.Validate(dto);
            if (validationresult.IsValid)
            {
                var mapped = _mapper.Map<T>(dto);
                await _uow.GetRepository<T>().AddAsync(mapped);
                await _uow.SaveChangesAsync();
                return new Response<CreateDto>(ResponseType.Success, dto);
            }
            return new Response<CreateDto>(ResponseType.ValidationError, validationresult.ConvertValidationFromCustomValidationError(), dto);
        }

        public async Task<IResponse<List<ListDto>>> GetAllAsync()
        {
            var defaultData = await _uow.GetRepository<T>().GetAllAsync();
            var mappedData = _mapper.Map<List<ListDto>>(defaultData);
            return new Response<List<ListDto>>(ResponseType.Success, mappedData);
        }

        public async Task<IResponse<IDto>> GetByIdAsync(int id)
        {
            var defaultData = await _uow.GetRepository<T>().GetByFilter(x => x.Id == id);
            if (defaultData == null)
            {
                return new Response<IDto>(ResponseType.NotFound, $"{id} nömrəli məlumat tapılmadı.");
            }
            var mappedData = _mapper.Map<IDto>(defaultData);
            return new Response<IDto>(ResponseType.Success, mappedData);
        }

        public async Task<IResponse> RemoveAsync(int id)
        {
            var dataId = await _uow.GetRepository<T>().Find(id);
            if (dataId == null)
            {
                await _uow.SaveChangesAsync();
                return new Response<IDto>(ResponseType.NotFound, $"{id} nömrəli məlumat tapılmadı.");
            }
            _uow.GetRepository<T>().Remove(dataId);
            return new Response<IDto>(ResponseType.Success, $"{id} nömrəli məlumat uğurlu silindi.");
        }

        public async Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto)
        {
            var resultValidation = _updateDtoValidator.Validate(dto);
            if (resultValidation.IsValid)
            {
                var unchangedData = await _uow.GetRepository<T>().Find(dto.Id);
                var mappedData = _mapper.Map<T>(dto);
                _uow.GetRepository<T>().Update(mappedData, unchangedData);
                await _uow.SaveChangesAsync();
                return new Response<UpdateDto>(ResponseType.Success, dto);
            }
            return new Response<UpdateDto>(ResponseType.ValidationError, resultValidation.ConvertValidationFromCustomValidationError(), dto);
        }
    }
}
