using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommonServiceLocator;
using Xamarin.Forms;
using XamarinFormsModule.ViewModels;

namespace XamarinFormsModule.Views
{
    public partial class AddToDoEventPage : ContentPage
    {
        public AddToDoEventPage(Func<Task> getToDoEvents = null)
        {
            BindingContext = ServiceLocator.Current.GetInstance(typeof(AddToDoEventViewModel));

            if (BindingContext is AddToDoEventViewModel bc) bc.GetToDoEvents = getToDoEvents;

            InitializeComponent();
        }
    }
}
