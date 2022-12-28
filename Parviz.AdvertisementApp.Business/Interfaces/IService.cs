﻿using Parviz.AdvertisementApp.Common;
using Parviz.AdvertisementApp.Dtos.Inferfaces;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Business.Interfaces
{
    public interface IService<CreateDto,ListDto,UpdateDto,T>
        where CreateDto : class ,IDto, new()
        where ListDto : class,IDto,new()
        where UpdateDto : class,IUpdateDto,new()
        where T : BaseEntity
    {
        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);
        Task<IResponse<List<ListDto>>> GetAllAsync();
        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);
        Task<IResponse<IDto>> GetByIdAsync(int id);
        Task<IResponse> RemoveAsync(int id);

    }
}
