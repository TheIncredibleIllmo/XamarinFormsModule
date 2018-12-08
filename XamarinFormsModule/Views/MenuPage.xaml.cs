using System;
using System.Collections.Generic;
using CommonServiceLocator;
using Xamarin.Forms;
using XamarinFormsModule.Services;
using XamarinFormsModule.ViewModels;

namespace XamarinFormsModule.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            BindingContext = ServiceLocator.Current.GetInstance(typeof(MenuViewModel));

            InitializeComponent();
        }
    }
}
