using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Parviz.AdvertisementApp.Business.Interfaces;
using Parviz.AdvertisementApp.Business.Mapping.AutoMapper;
using Parviz.AdvertisementApp.Business.Services;
using Parviz.AdvertisementApp.Business.ValidationRules;
using Parviz.AdvertisementApp.DataAccess.Context;
using Parviz.AdvertisementApp.DataAccess.UnitOfWork;
using Parviz.AdvertisementApp.Dtos;
using Parviz.AdvertisementApp.Dtos.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Parviz.AdvertisementApp.Business.DependencyRepository.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Connection"));
            });

            

            services.AddScoped<IUOW, UOW>();
            services.AddTransient<IValidator<ProvidedServiceCreatedDto>, ProvidedServiceCreatedDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();
            services.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
            services.AddTransient<IValidator<GenderUpdateDto>, GenderUpdateDtoValidator>();

            services.AddScoped<IProvidedServiceService, ProvidedServiceService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IGenderService, GenderService>();
        }
    }
}
