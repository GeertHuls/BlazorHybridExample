﻿using BlazorHybridExample.Library.Data;
using BlazorHybridExample.Maui.Auth;
using BlazorHybridExample.Maui.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace BlazorHybridExample.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider,
                CustomAuthStateProvider>();

            builder.Services.AddTransient<ICoffeeService, CoffeeService>();

            return builder.Build();
        }
    }
}