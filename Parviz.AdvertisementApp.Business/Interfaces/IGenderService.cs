using Parviz.AdvertisementApp.Dtos;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Business.Interfaces
{
    public interface IGenderService:IService<GenderCreateDto,GenderListDto,GenderUpdateDto,Gender>
    {
    }
}
