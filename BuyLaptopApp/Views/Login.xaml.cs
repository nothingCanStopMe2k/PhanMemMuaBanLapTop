using BuyLaptopApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuyLaptopApp.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }

        private void btnNavSu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUp());
        }
    }
}