using System;
using System.Collections.Generic;
using CommonServiceLocator;
using Xamarin.Forms;
using XamarinFormsModule.ViewModels;

namespace XamarinFormsModule.Views
{
    public partial class ToDoBoardPage : ContentPage
    {
        public ToDoBoardPage()
        {
            BindingContext = ServiceLocator.Current.GetInstance(typeof(ToDoBoardViewModel));

            if (BindingContext is ToDoBoardViewModel bc)
            {
                bc.InitViewModel();
            }

            InitializeComponent();
        }
    }
}
