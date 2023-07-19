using Blazor.ConnectionStatusDetector;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using XtianBlazorApp.Client;
using XtianBlazorApp.Client.Pages;
using XtianBlazorApp.Shared.ViewModels;

namespace EmafMobile.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //  builder.Services.AddHttpClient();
            builder.Services.AddScoped(sp => new HttpClient());
            builder.Services.AddSingleton<IConnectionStatusDetectorService, ConnectionStatusDetectorService>();
            // { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<StateContainer>();
            builder.Services.AddSingleton<Dashboard>();
            builder.Services.AddSingleton<PersonalForm>();
            // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //builder.Services.AddSingleton<StateContainer>();

            //  builder.Services
            var app = builder.Build();

            //app.UseCors();
            await app.RunAsync();
        }
    }
}
