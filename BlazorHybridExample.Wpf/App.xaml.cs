using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BlazorHybridExample.Wpf
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var services = new ServiceCollection();
            services.AddWpfBlazorWebView();
#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif

            var serviceProvider = services.BuildServiceProvider();
            // Register service provider with key 'ServiceProvider'
            // to create a reference to it for the application,
            // via DynamicResource of BlazorWebViewd element in MainWindow.xaml.
            Resources.Add("ServiceProvider", serviceProvider);
        }
    }
}
