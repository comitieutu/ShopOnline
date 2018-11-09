using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BookStore.Interfaces;
using BookStore.Implementations;
using Newtonsoft.Json;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace BookStore
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<StoreUser, IdentityRole>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<AppDbContext>();

            //services.AddIdentity<IdentityUser, IdentityRole>()
            //    // services.AddDefaultIdentity<IdentityUser>()
            //    .AddEntityFrameworkStores<AppDbContext>()
            //    .AddDefaultTokenProviders();

            services.AddDbContext<AppDbContext>(cfg => 
            {
                cfg.UseSqlServer(_config.GetConnectionString("BookConnectionString"));
            });

            services.AddTransient<IMailService, NullMailService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new BookProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc()
                .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
            
            app.UseStaticFiles();

            app.UseAuthentication();    

            app.UseNodeModules(env);

            app.UseMvc(cfg => 
            {
                cfg.MapRoute(
                     name: "areaRoute",
                     template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                cfg.MapRoute("Default",
                    "{controller}/{action}/{id?}",
                    new { controller = "Book", Action = "Index" });
            });
        }
    }
}
