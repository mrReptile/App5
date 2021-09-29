using App5.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App5.ViewModel
{
    class MainPageViewModel : BaseModel
    {
        Command goToViewTwo;

        public MainPageViewModel(INavigation navigation) : base(navigation) {
            Navigation = navigation;
        }

        public Command GoToViewTwo
        {
            get => goToViewTwo ?? (goToViewTwo = new Command(GoToViewTwoAction));
        }

        private void GoToViewTwoAction() {
            Navigation.PushAsync(new NavigationPage(new PageTwo() ));
        }
    }
}
