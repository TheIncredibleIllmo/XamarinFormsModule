using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsModule.Interfaces
{
    public interface INavigationService
    {
        Task PopAsync();
        Task PopToRootAsync();
        Task PushAsync(Page page);
    }
}
