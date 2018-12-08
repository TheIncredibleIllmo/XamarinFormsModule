using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsModule.Helpers
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableObject()
        {
        }

        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <param name="currentValue">Current value.</param>
        /// <param name="value">Value.</param>
        /// <param name="propertyName">Property name.</param>
        /// <param name="onChanged">On changed.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        protected void SetProperty<T>(ref T currentValue,
                                      T value,
                                      [CallerMemberName] string propertyName = "",
                                      Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(currentValue, value)) return;

            currentValue = value;
            OnPropertyChanged(propertyName);
            onChanged?.Invoke();
        }


        /// <summary>
        /// Triggers once that the property has changed.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            //1.-Know the name of the property
            //[CallerMemberName] takes the name (string) value from the property or
            //method that was called from.

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
