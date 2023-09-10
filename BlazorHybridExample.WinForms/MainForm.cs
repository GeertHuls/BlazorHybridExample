using BlazorHybridExample.Library;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorHybridExample.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm(ServiceProvider serviceProvider)
        {
            InitializeComponent();
            blazorWebView.HostPage = "wwwroot/index.html";
            blazorWebView.Services = serviceProvider;
            blazorWebView.RootComponents.Add(
                new RootComponent("#app", typeof(Main), null));
        }
    }
}