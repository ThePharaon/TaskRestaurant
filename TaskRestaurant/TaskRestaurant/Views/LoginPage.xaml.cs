using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaskRestaurant.Common;

namespace TaskRestaurant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : AnimationPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OpenSignUp_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.RegisterPage());
        }

        private void btnShowHide_Clicked(object sender, EventArgs e)
        {
            txtPassword.IsPassword = !txtPassword.IsPassword;
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            if(StaticOperations.IsValidInput(txtUsername.Text)
                && StaticOperations.IsValidInput(txtPassword.Text))
            {
                if (StaticValues.AllUsers.ContainsKey(txtUsername.Text))
                {
                    if(StaticValues.AllUsers[txtUsername.Text].Pasword == txtPassword.Text)
                    {
                        StaticValues.CurrentUser = StaticValues.AllUsers[txtUsername.Text];
                        Application.Current.MainPage = new AnimationNavigationPage(new Views.WelcomePage());
                    }
                    else
                        DisplayAlert("Error", "Wrong Password !", "OK");
                }
                else
                    DisplayAlert("Error", "This User not Exist !", "OK");
            }
            else
                DisplayAlert("Error", "Please Enter Username and Password !", "OK");
        }
    }
}