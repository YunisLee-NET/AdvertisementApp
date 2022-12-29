using AutoMapper;
using FluentValidation;
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
