using Parviz.AdvertisementApp.Business.Interfaces;
using Parviz.AdvertisementApp.Common;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Dtos.Inferfaces
{
    public interface IAdvertisementService : IService<AdvertisementCreateDto, AdvertisementListDto, AdvertisementUpdateDto, Advertisement>
    {
        Task<IResponse<List<AdvertisementListDto>>> GetActiveAsync();
    }
}
