using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskRestaurant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : AnimationPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void Resturant_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.RestaurantPage());
        }

        private void Spa_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Oops", "This Part Under Construction.", "OK");
        }

        private void Family_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Oops", "This Part Under Construction.", "OK");
        }
    }
}