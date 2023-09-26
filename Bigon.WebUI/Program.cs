using Bigon.WebUI.Models.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace Bigon.WebUI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<DataContext>(cfg =>
        {
            cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"));
        }
        );

        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();
        app.UseEndpoints(cfg =>
        {
            cfg.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );
            cfg.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}");
        }
        );

        app.Run();
    }
}

