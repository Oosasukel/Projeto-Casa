using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoCasaDeShow.Areas.Identity.Data;

[assembly: HostingStartup(typeof(ProjetoCasaDeShow.Areas.Identity.IdentityHostingStartup))]
namespace ProjetoCasaDeShow.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {

        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<IdentityContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("ProjetoCasaDeShowIdentityDbContextConnection")));

                services.AddDefaultIdentity<ProjetoCasaDeShowUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IdentityContext>();
            });
        }
    }
}