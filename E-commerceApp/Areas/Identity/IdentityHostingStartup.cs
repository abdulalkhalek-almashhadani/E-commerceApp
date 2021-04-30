using System;
using EcommerceApp1.Areas.Identity.Data;
using EcommerceApp1.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EcommerceApp1.Areas.Identity.IdentityHostingStartup))]
namespace EcommerceApp1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EcommerceApp1Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EcommerceApp1ContextConnection")));

                services.AddDefaultIdentity<EcommerceApp1User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<EcommerceApp1Context>();
            });
        }
    }
}