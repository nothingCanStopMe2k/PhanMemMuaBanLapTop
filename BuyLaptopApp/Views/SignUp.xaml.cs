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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void ClickDangNhap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void DangKiVoiEmail_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Signupwithemail());
        }

        private void DangNhapVoiFB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home("Tiến"));
        }
    }
}