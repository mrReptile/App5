using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App5.ViewModel
{
    public class PageTwoViewModel : BaseModel
    {
        Command goToRoot;

        public PageTwoViewModel(INavigation navigation) : base(navigation){

        }

        public Command GoToRoot {
            get => goToRoot ?? (goToRoot = new Command(GoToRootAction));
                }

        public void GoToRootAction() {
            Navigation.PopToRootAsync();
        }
    }
}
