using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parviz.AdvertisementApp.Business.DependencyRepository.Microsoft;
using Parviz.AdvertisementApp.Business.Helper;
using Parviz.AdvertisementApp.UI.AutoMapper;
using Parviz.AdvertisementApp.UI.Models;
using Parviz.AdvertisementApp.UI.ValidationRules;
using System;

namespace Parviz.AdvertisementApp.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependency(Configuration);
            services.AddControllersWithViews();
            services.AddTransient<IValidator<UserCreateModel>, UserCreateModelValidator>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
            {
                option.Cookie.Name = "ParvizCookie";
                option.Cookie.HttpOnly = true;
                option.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                option.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                option.ExpireTimeSpan = TimeSpan.FromDays(30);
                option.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/SignIn");
                option.LogoutPath = new Microsoft.AspNetCore.Http.PathString("/Account/LogOut");
                option.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/AccessDenied");
            });

            var profiles = MapProfileHelper.GetProfiles();
            profiles.Add(new UserCreateModelProfile());
            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfiles(profiles);
                //Add.Profile();
            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
