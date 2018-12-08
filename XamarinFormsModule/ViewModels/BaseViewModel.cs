using System;
using XamarinFormsModule.Helpers;

namespace XamarinFormsModule.ViewModels
{
    public class BaseViewModel<T> : ObservableObject where T : new()
    {
        public T Model { get; set; }

        public BaseViewModel()
        {
            Model = new T();
        }
    }
}
