using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Service;
using AppKeep.Web.Validators;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.Http;

namespace AppKeep
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // BLAZOR COOKIE Auth Code
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<AppKeepContext>();
            services.AddTransient<IMachineRepository, MachineRepository>();
            services.AddTransient<IMachineService, MachineService>();
            services.AddTransient<IUpkeepTemplateDetailRepository, UpkeepTemplateDetailRepository>();
            services.AddTransient<IUserMachineRepository, UserMachineRepository>();
            services.AddTransient<IUserMachineService, UserMachineService>();
            services.AddTransient<IUpkeepTemplateDetailService, UpkeepTemplateDetailService>();
            services.AddTransient<IUpkeepTemplateRepository, UpkeepTemplateRepository>();
            services.AddTransient<IUpkeepTemplateService, UpkeepTemplateService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserAuthenticationService, UserAuthenticationService>();
            services.AddTransient<IMyPlanRepository, MyPlanRepository>();
            services.AddTransient<IMyPlanService, MyPlanService>();

            services.AddScoped<LoginCredentialsValidator>();

            // BLAZOR COOKIE Auth Code
            services.AddHttpContextAccessor();
            services.AddScoped<HttpContextAccessor>();
            services.AddHttpClient();
            services.AddScoped<HttpClient>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // BLAZOR COOKIE Auth Code
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
