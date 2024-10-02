namespace Teknologi_19_09_2024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/route1", () => "Hello from Route 1!");
            app.MapGet("/route2", () => "Hello from Route 2!");
            app.MapGet("/route3", () => "Hello from Route 3!");

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("");
            //});


            app.MapGet("/", async (context) =>
            {
                await context.Response.WriteAsync("Hello from Route 4!");
            });

            app.Run();

        }
    }
}
