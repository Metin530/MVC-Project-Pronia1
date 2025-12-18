
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace MVC_Project_Pronia

{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder .Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseExceptionHandler("/Home/Error");
            app.UseStaticFiles();
            app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}"
               
               



               );
           

            app.Run();
        }
    }
}
