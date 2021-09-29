using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace App5.ViewModel
{
    public class BaseModel : INotifyPropertyChanged

    {

        public BaseModel(INavigation navigation) {
            Navigation = navigation;
        }
        //INavigation navigation;

        public INavigation Navigation
        {
            get; set;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPorpertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
