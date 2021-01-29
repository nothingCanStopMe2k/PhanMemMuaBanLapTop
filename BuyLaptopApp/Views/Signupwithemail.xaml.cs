using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string Ten = txtTen.Text;
            string Sdt = txtSdt.Text;
            string MatKhau = txtMatKhau.Text;

            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync("http://www.qllt.somee.com/api/serviceController/dangky?sodt="+ Sdt +"&matkhau="+ MatKhau +"&hoten=" + MatKhau);
            if(kq != "[{\"Column1\":\fail\"}]")
            {
                await DisplayAlert("thông báo", "Đăng ký thành công", "Đồng ý");
                await Navigation.PushAsync(new Login(Ten, Sdt, MatKhau));
            }
            else
            {
                await DisplayAlert("thông báo", "Đăng ký thất bại", "Đồng ý");
            }
        }
    }
}