using DotNetNote.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DotNetNote
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
            services.AddControllersWithViews();
            services.AddTransient<IAttendeeRepository, AttendeeRepository>();
            services.AddSingleton<IUserRepository>(new UserRepository(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddTransient<IUserRepository, UserRepositoryDapper>();

            services.AddSingleton<IMyNotificationRepository>(new MyNotificationRepository(Configuration.GetConnectionString("DefaultConnection")));


            ////[1] ASP.NET Core ��Ű ����: �ܼ���
            //services.AddAuthentication("Cookies").AddCookie();
            // ��Ű ���� ���� �ּ����� �ڵ� 
            //services.AddAuthentication("Cookies")
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/User/Login/";
                    options.AccessDeniedPath = "/User/Forbidden/";
                });

            #region [1] Session ��ü ���
            //[0] ���� ��ü ���: Microsoft.AspNetCore.Session.dll NuGet ��Ű�� ���� 
            //services.AddSession(); 
            // Session ��ü ���� �ɼ� �ο� 
            services.AddSession(options =>
            {
                // ���� ���� �ð�(��)
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            #endregion
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            #region [2] TempData�� Session ��ü ��� 
            //[DNN] TempData ��ü ���
            app.UseSession(); //[!] ���� ��ü ���, �ݵ�� UseMvc() ������ ȣ��Ǿ�� �� 
            #endregion

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
