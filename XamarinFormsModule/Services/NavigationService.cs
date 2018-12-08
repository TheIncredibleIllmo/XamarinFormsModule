using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsModule.Interfaces;

namespace XamarinFormsModule.Services
{
    public class NavigationService : INavigationService
    {
        public async Task PopAsync()
        {
            await Application.Current?.MainPage?.Navigation?.PopAsync();
        }

        public async Task PopToRootAsync()
        {
            await Application.Current?.MainPage?.Navigation?.PopToRootAsync();
        }

        public async Task PushAsync(Page page)
        {
            await Application.Current?.MainPage?.Navigation?.PushAsync(page);
        }
    }
}
