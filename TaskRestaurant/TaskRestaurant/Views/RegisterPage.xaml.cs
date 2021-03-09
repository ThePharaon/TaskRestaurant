using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRestaurant.Common;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskRestaurant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : AnimationPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void btnSignUp_Clicked(object sender, EventArgs e)
        {
            if (StaticOperations.IsValidInput(txtUsername.Text)
                && StaticOperations.IsValidInput(txtPassword.Text)
                & StaticOperations.IsValidInput(txtphone.Text))
            {
                if (!StaticValues.AllUsers.ContainsKey(txtUsername.Text))
                {
                    StaticValues.AllUsers.Add(txtUsername.Text, new Models.User()
                    {
                        Username = txtUsername.Text,
                        Pasword = txtPassword.Text,
                        Phone = txtphone.Text
                    });
                    await DisplayAlert("Success", "User created.", "OK");
                    btnBack_Clicked(btnBack, new EventArgs());
                }
                else
                    await DisplayAlert("Error", "This User Exist !", "OK");
            }
            else
                await DisplayAlert("Error", "Please Enter Username, Password and Phone number !", "OK");
        }

        private void btnShowHide_Clicked(object sender, EventArgs e)
        {
            txtPassword.IsPassword = !txtPassword.IsPassword;
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}