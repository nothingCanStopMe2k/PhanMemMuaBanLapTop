using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace doancuoiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DangKy : ContentPage
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private async void btnDangky_Clicked(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            var a = await http.GetStringAsync("http://www.qllh.somee.com/api/serviceController/themnv?msnv=" + ms.Text + "&mk=" + pass.Text + "&ten=" + name.Text + "&cv=" + cv.Text);
               
            if (ms.Text != "" && pass.Text != "" && name.Text != "" && cv.Text != "")
            {
                await DisplayAlert("Thông báo", "Đăng ký thành công", "OK");
                await Navigation.PushAsync(new MainPage());
            }
            else
                await DisplayAlert("Thông báo", "Vui lòng nhập đủ thông tin", "OK");

        }
    }
}