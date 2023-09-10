using BlazorHybridExample.Library.Data;
using BlazorHybridExample.WinForms.Auth;
using BlazorHybridExample.WinForms.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorHybridExample.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif
            services.AddAuthorizationCore();
            services.AddScoped<AuthenticationStateProvider,
                CustomAuthStateProvider>();

            services.AddTransient<ICoffeeService, CoffeeService>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(serviceProvider));
        }
    }
}