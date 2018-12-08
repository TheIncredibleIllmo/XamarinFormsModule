using System;
using XamarinFormsModule.Interfaces;
using XamarinFormsModule.Models.BaseVMModels;
using XamarinFormsModule.Services;

namespace XamarinFormsModule.ViewModels
{
    public class MenuViewModel : BaseViewModel<MenuModel>
    {
        #region FIELDS

        #endregion

        #region PROPERTIES

        #endregion

        #region COMMANDS

        #endregion
        INavigationService _navigationService;

        public MenuViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        #region COMMAND_ACTIONS
        private void Navigate()
        {
            //_navigationService.PushAsync(new MyPage());
        }

        #endregion
    }
}
