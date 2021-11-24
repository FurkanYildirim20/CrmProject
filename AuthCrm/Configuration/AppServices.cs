using AuthCrm.DataAccess.Abstruct;
using AuthCrm.DataAccess.Concrete;
using AuthCrm.DataAccess.Contexts;
using AuthCrm.Service.Abstract;
using AuthCrm.Service.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AuthCrm.Configuration
{
    public static class AppServices
    {
        public static void AddDefaultServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<AuthDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));
            serviceCollection.AddDatabaseDeveloperPageExceptionFilter();
            serviceCollection.AddControllersWithViews().AddRazorRuntimeCompilation();
            serviceCollection.AddRazorPages();
            serviceCollection.AddMvc();
            //serviceCollection.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            //{
            //    x.LoginPath = "/Identity/Account/Login";
            //});
            //serviceCollection.AddIdentity<ApplicationUser, IdentityRole>(opt =>
            //{
            //    opt.Password.RequireLowercase = false;
            //    opt.Password.RequireDigit = false;
            //    opt.Password.RequiredLength = 1;
            //    opt.Password.RequireUppercase = false;
            //    opt.Password.RequireNonAlphanumeric = false;
            //}).AddEntityFrameworkStores<AuthDbContext>();

            serviceCollection.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.HttpOnly = true;
                opt.Cookie.SameSite = SameSiteMode.Strict;
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(10);
            });
        }
        public static void AddCustomServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAdressService, AdressManager>();
            serviceCollection.AddScoped<IAdressDal, EfAdressDal>();
            serviceCollection.AddScoped<ICustomerService, CustomerManager>();
            serviceCollection.AddScoped<ICustomerDal, EfCustomerDal>();
            serviceCollection.AddScoped<ICompanyService, CompanyManager>();
            serviceCollection.AddScoped<ICompanyDal, EfCompanyDal>();
            serviceCollection.AddScoped<ICityService, CityManager>();
            serviceCollection.AddScoped<ICityDal, EfCityDal>();
            serviceCollection.AddScoped<ICountryService, CountryManager>();
            serviceCollection.AddScoped<ICountryDal, EfCountryDal>();

        }
    }
}