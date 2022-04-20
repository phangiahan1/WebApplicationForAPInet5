using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationForAPInet5.Data;

[assembly: HostingStartup(typeof(WebApplicationForAPInet5.Areas.Identity.IdentityHostingStartup))]
namespace WebApplicationForAPInet5.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebApplicationForAPInet5Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebApplicationForAPInet5ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WebApplicationForAPInet5Context>();
            });
        }
    }
}