using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace doancuoiki
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnDangNhap_Clicked(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            var a = await http.GetStringAsync("http://www.qllh.somee.com/api/serviceController/dangnhap?msnv=" + msnv.Text + "&mk=" + mk.Text);
            if (a.Length > 2)
            {
                await Navigation.PushAsync(new Home_Tabbed(a));
            }
            else
                await DisplayAlert("Thông báo", "Đăng nhập thất bại", "cancel");
        }

        private void navDangKy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangKy());
        }
    }
}
