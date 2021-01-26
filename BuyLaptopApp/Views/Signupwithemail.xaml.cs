using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuyLaptopApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Signupwithemail : ContentPage
    {
        public Signupwithemail()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            string Ten = lstTen.Text;
            string Email = lstEmail.Text;
            string MatKhau = lstMatKhau.Text;
            Navigation.PushAsync(new Login(Ten, Email, MatKhau));
        }
    }
}