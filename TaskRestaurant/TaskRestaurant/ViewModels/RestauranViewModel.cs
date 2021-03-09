using FormsControls.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaskRestaurant.Common;
using TaskRestaurant.Models;
using Xamarin.Forms;

namespace TaskRestaurant.ViewModels
{
    class RestauranViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products
        {
            get => new ObservableCollection<Product>(StaticValues.AllProducts.Values);
        }
        public Command LogoutCommand { get; set; }
        public Command AddToCartCommand { get; set; }
        public Command IncreaseCartAmountCommand { get; set; }
        public Command DecreaseCartAmountCommand { get; set; }
        public RestauranViewModel()
        {
            IncreaseCartAmountCommand = new Command(DoIncreaseCartAmount);
            DecreaseCartAmountCommand = new Command(DoDecreaseCartAmount);
            LogoutCommand = new Command(DoLogout);
        }

        private void DoLogout()
        {
            StaticValues.CurrentUser = null;
            StaticValues.Cart.Clear();
            Device.BeginInvokeOnMainThread(() =>
            {
                Application.Current.MainPage = new AnimationNavigationPage(new Views.LoginPage());
            });
        }

        private void DoDecreaseCartAmount(object obj)
        {
            Label control = obj as Label;
            if (control == null)
                return;
            int value = Convert.ToInt32(control.Text);
            value--;
            Device.BeginInvokeOnMainThread(() =>
            {
                control.Text = value.ToString();
            });
        }

        private void DoIncreaseCartAmount(object obj)
        {
            Label control = obj as Label;
            if (control == null)
                return;
            int value = Convert.ToInt32(control.Text);
            value++;
            Device.BeginInvokeOnMainThread(() =>
            {
                control.Text = value.ToString();
            });

        }

    }
}
