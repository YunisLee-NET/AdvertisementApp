using AutoMapper;
using Parviz.AdvertisementApp.Business.Mapping.AutoMapper;
using System.Collections.Generic;

namespace Parviz.AdvertisementApp.Business.Helper
{
    public static class MapProfileHelper
    {
        public static List<Profile> GetProfiles()
        {
            return new List<Profile>
            {
               new ProvidedServiceProfile(),
               new AdvertisementProfile(),
               new AppUserProfile(),
               new GenderProfile()
            };
        }
    }
}
