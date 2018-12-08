using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsModule.Interfaces;
using XamarinFormsModule.Models.BaseVMModels;
using XamarinFormsModule.Services;
using XamarinFormsModule.Views;

namespace XamarinFormsModule.ViewModels
{
    public class MenuViewModel : BaseViewModel<MenuModel>
    {
        #region FIELDS
        INavigationService _navigationService;
        #endregion

        #region COMMANDS
        public ICommand NavigateCommand { get; private set; }

        public string Name { get; set; }
        #endregion

        public MenuViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new Command<string>(Navigate);
        }

        #region COMMAND_ACTIONS
        private void Navigate(string navOption)
        {
            if (string.IsNullOrEmpty(navOption)) return;

            switch (navOption)
            {
                case "Gallery":
                    //_navigationService.PushAsync(new MyPage());
                    break;
                case "ToDoList":
                    _navigationService.PushAsync(new ToDoBoardPage());
                    break;
                default:
                    break;
            }
        }
        #endregion



    }
}
