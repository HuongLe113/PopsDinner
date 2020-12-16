using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Domain.Entities;
using Infrastructure.Persistence;

namespace popsDiner
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

        }
    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                     options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDistributedMemoryCache();
            services.AddSession();
             services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/AppException");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "categoryfilter",
                    template: "Item/{action}/{category?}",
                    defaults: new { Controller = "Item", action = "List" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
                
            app.UseSession();
        }
    }
}
