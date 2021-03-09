using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TaskRestaurant.Common;
using Xamarin.Forms;

namespace TaskRestaurant.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public string LoginDate
        {
            get
            {
                return DateTime.Now.ToLongDateString();
            }

        }
        public string CurrUser
        {
            get
            {
                return Common.StaticValues.CurrentUser.Username;
            }
        }
        public Command LogoutCommand { get; set; }

        public WelcomeViewModel()
        {
            StaticOperations.InitData();
            LogoutCommand = new Command(() => DoLogout());
        }

        private void DoLogout()
        {
            Common.StaticValues.CurrentUser = null;
            Common.StaticValues.Cart.Clear();
            Device.BeginInvokeOnMainThread(() =>
            {
                Application.Current.MainPage = new AnimationNavigationPage(new Views.LoginPage());
            });
            
        }
    }
}
