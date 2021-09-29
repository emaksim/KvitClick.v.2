using KvitClick.v._2.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(KvitClick.v._2.Areas.Identity.IdentityHostingStartup))]
namespace KvitClick.v._2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<KvitClickContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("KvitClickContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<KvitClickContext>();
            });
        }
    }
}