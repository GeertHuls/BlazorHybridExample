using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorHybridExample.Library.Auth
{
    public interface ICustomAuthStateProvider
    {
        Task<AuthenticationState> GetAuthenticationStateAsync();
        Task LogInAsync();
        void Logout();
    }
}