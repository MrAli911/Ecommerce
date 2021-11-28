using Ecommerce.Data;
using Ecommerce.Interfaces;
using Ecommerce.Models;
using Ecommerce.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc(option => option.EnableEndpointRouting = false) ; 
            services.AddRazorPages();
            services.AddDbContext<EcommerceDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<EcommerceDbContext>();

            //add dependecy of idenetiy in startup.cs
            //services.AddIdentity<IdentityUser , IdentityRole>()
            //    .AddEntityFrameworkStores<EcommerceDbContext>()
            //    .AddDefaultTokenProviders()
            //    .AddDefaultUI();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookies =>
            {
                cookies.LoginPath = "/DashBoard/AdminLogin";
                cookies.AccessDeniedPath ="";
                cookies.LogoutPath ="";

            });
                
            services.AddTransient(typeof(IBaseRepository<>) , typeof(BaseRepository<>));
            services.AddSession();
        }

      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();   
            app.UseRouting();
            app.UseAuthentication();
            
            app.UseAuthorization();
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //to use pages in identity area
                endpoints.MapRazorPages();  
            });

            app.UseMvc();   
        }
    }
}
