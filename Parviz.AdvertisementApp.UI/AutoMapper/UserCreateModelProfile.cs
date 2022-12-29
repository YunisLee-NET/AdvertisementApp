using AutoMapper;
using Parviz.AdvertisementApp.Dtos;
using Parviz.AdvertisementApp.UI.Models;

namespace Parviz.AdvertisementApp.UI.AutoMapper
{
    public class UserCreateModelProfile:Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
        }
    }
}
