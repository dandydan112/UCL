using Arvefordeleren_CleanArchitecture.WebUI.Components;
using Arvefordeleren_CleanArchitecture.Application;
using Arvefordeleren_CleanArchitecture.Infrastructure;
using Arvefordeleren_CleanArchitecture.Domain.Interfaces;
using Arvefordeleren_CleanArchitecture.Infrastructure.Repositories;

namespace Arvefordeleren_CleanArchitecture.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Register application and infrastructure services
            builder.Services.AddApplication(); // Placeholder for additional Application layer services
            builder.Services.AddInfrastructure(); // Placeholder for additional Infrastructure layer services

            // Register the GameRepository as the implementation for IGameRepository
            builder.Services.AddSingleton<IGameRepository, GameRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
