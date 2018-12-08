using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsModule.Interfaces;
using XamarinFormsModule.Models;
using XamarinFormsModule.Models.BaseVMModels;

namespace XamarinFormsModule.ViewModels
{
    public class ToDoBoardViewModel : BaseViewModel<ToDoBoardModel>
    {
        #region FIELDS
        private INavigationService _navigationService;
        private Func<Task> _getToDoEvents;
        #endregion

        #region PROPERTIES
        public ObservableCollection<ToDoEvent> ToDoEventLst
        {
            get { return Model.ToDoEventLst; }
            set { SetProperty(ref Model.ToDoEventLst, value); }
        }
        #endregion

        #region COMMANDS
        public ICommand AddToDoEventCommand { get; private set; }
        #endregion

        public ToDoBoardViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            AddToDoEventCommand = new Command(AddToDoEvent);
        }

        #region METHODS
        public async Task InitViewModel()
        {
            _getToDoEvents = GetToDoEvents;

            await GetToDoEvents();
        }

        private async Task GetToDoEvents()
        {
            var dbToDoEventLst = await App.SQLConnection?.Table<ToDoEvent>()
                                                        ?.ToListAsync();

            ToDoEventLst = null;
            ToDoEventLst = new ObservableCollection<ToDoEvent>(dbToDoEventLst);
        }
        #endregion

        #region COMMANDS_ACTIONS
        private void AddToDoEvent()
        {
            //_navigationService.PushAsync(new MyPage());
        }
        #endregion
    }
}
