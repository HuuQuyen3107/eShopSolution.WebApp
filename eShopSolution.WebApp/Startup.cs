using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace eShopSolution.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddControllersWithViews();
            services.AddRazorPages().AddMvcOptions(options => options.EnableEndpointRouting = false);
            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                  .RequireAuthenticatedUser()
                  .Build();
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
             .AddCookie(options =>
             {
                 options.LoginPath = "/Account/Login";
                 options.AccessDeniedPath = "/User/Forbidden/";
             });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseSession();
            app.UseAuthorization();
            app.UseCors();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "Product Category En",
                    pattern: "{culture}/categories/{id}", new
                    {
                        controller = "Product",
                        action = "Category"
                    });

                endpoints.MapControllerRoute(
                  name: "Product Category Vn",
                  pattern: "{culture}/danh-muc/{id}", new
                  {
                      controller = "Product",
                      action = "Category"
                  });

                endpoints.MapControllerRoute(
                    name: "Product Detail En",
                    pattern: "{culture}/products/{id}", new
                    {
                        controller = "Product",
                        action = "Detail"
                    });

                endpoints.MapControllerRoute(
                  name: "Product Detail Vn",
                  pattern: "{culture}/san-pham/{id}", new
                  {
                      controller = "Product",
                      action = "Detail"
                  });

                endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{culture=vi}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
