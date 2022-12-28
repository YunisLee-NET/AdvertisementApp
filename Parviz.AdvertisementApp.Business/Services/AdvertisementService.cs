using Parviz.AdvertisementApp.Dtos.Inferfaces;
using Parviz.AdvertisementApp.Dtos;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parviz.AdvertisementApp.Common;
using AutoMapper;
using FluentValidation;
using Parviz.AdvertisementApp.DataAccess.UnitOfWork;

namespace Parviz.AdvertisementApp.Business.Services
{
    public class AdvertisementService : Service<AdvertisementCreateDto, AdvertisementListDto, AdvertisementUpdateDto, Advertisement>, IAdvertisementService
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;
        public AdvertisementService(IMapper mapper, IValidator<AdvertisementCreateDto> creatoDtoValidator, IValidator<AdvertisementUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, creatoDtoValidator, updateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;           
        }

        public async Task<IResponse<List<AdvertisementListDto>>> GetActiveAsync()
        {
            var data = await _uow.GetRepository<Advertisement>().GetAllAsync(x => x.Status, x => x.CreatedDate, Common.Enums.OrderByType.DESC);
            var mappedData = _mapper.Map<List<AdvertisementListDto>>(data);
            return new Response<List<AdvertisementListDto>>(ResponseType.Success, mappedData);
        }
    }
}
