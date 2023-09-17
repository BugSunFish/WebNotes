namespace src
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            if(app.Environment.IsDevelopment()) 
                app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "deafult", 
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}