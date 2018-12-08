using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsModule.Interfaces;
using XamarinFormsModule.Models;
using XamarinFormsModule.Models.BaseVMModels;

namespace XamarinFormsModule.ViewModels
{
    public class AddToDoEventViewModel : BaseViewModel<AddToDoEventModel>
    {
        #region FIELDS
        private readonly INavigationService _navigationService;
        #endregion

        #region PROPERTIES
        public Func<Task> GetToDoEvents { get; set; }

        public string CurrentTitle
        {
            get => Model.CurrentTitle;
            set => SetProperty(ref Model.CurrentTitle, value);
        }

        public string CurrentDescription
        {
            get => Model.CurrentDescription;
            set => SetProperty(ref Model.CurrentDescription, value);
        }
        #endregion

        #region COMMANDS
        public ICommand SaveToDoEventCommand { get; private set; }
        #endregion

        #region CONSTRUCTOR
        public AddToDoEventViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            SaveToDoEventCommand = new Command(async () => await SaveToDoEvent());
        }
        #endregion

        #region METHODS
        #endregion

        #region COMMANDS_ACTIONS
        private async Task SaveToDoEvent()
        {
            if (string.IsNullOrEmpty(CurrentTitle) || string.IsNullOrEmpty(CurrentDescription)) return;

            var toDoEvent = new ToDoEvent
            {
                Title = CurrentTitle,
                Description = CurrentDescription
            };

            //DependencyService.Get<IHideKeyboard>().HideKeyboard();

            await App.SQLConnection.InsertAsync(toDoEvent);

            await GetToDoEvents?.Invoke();

            await _navigationService.PopAsync();
        }
        #endregion



    }
}
