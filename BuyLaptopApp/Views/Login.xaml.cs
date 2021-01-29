using BuyLaptopApp.Models;
using BuyLaptopApp.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
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
            txtSdt.Text = Email;
            txtMatKhau.Text = MatKhau;
            TenNguoiDung = Ten;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterDetailPage1(TenNguoiDung));
        }
    }
}