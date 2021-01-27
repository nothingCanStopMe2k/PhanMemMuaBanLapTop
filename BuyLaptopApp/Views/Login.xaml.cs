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
        string TenNguoiDung;
        public Login()
        {
            InitializeComponent();
        }

        public Login(string Ten, string Email, string MatKhau)
        {
            InitializeComponent();
            lstEmail.Text = Email;
            lstMatKhau.Text = MatKhau;
            TenNguoiDung = Ten;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterDetailPage1(TenNguoiDung));
        }
    }
}