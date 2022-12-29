﻿using AutoMapper;
using Parviz.AdvertisementApp.Dtos;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Business.Mapping.AutoMapper
{
    public class GenderProfile:Profile
    {
        public GenderProfile()
        {
            CreateMap<Gender, GenderCreateDto>().ReverseMap();
            CreateMap<Gender, GenderListDto>().ReverseMap();
            CreateMap<Gender, GenderUpdateDto>().ReverseMap();
        }
    }
}
