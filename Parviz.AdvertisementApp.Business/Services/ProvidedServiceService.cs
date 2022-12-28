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
    public class ProvidedServiceService : Service<ProvidedServiceCreatedDto, ProvidedServiceListDto, ProvidedServiceUpdateDto, ProvidedService>, IProvidedServiceService
    {
        public ProvidedServiceService(IMapper mapper,IValidator<ProvidedServiceCreatedDto> createDtoValidator, IValidator<ProvidedServiceUpdateDto> updateDtoValidator,IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {

        }
    }
}
