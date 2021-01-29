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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync("http://www.qllt.somee.com/api/serviceController/dangnhap?sodt=" + txtSdt.Text + "&matkhau=" + txtMatKhau.Text);
            if(kq != "[{\"Column1\":\"fail\"}]")
            {
                Database db = new Database();
                var khs = JsonConvert.DeserializeObject<List<KhachHang>>(kq);
                db.Them_Khachhang(khs[0]);
                await Navigation.PushAsync(new MasterDetailPage1(TenNguoiDung));
            }
            else
            {
                await DisplayAlert("Thông báo", "Đăng nhập thất bại", "Đồng ý");
            }

            
        }

        private Task DisplayAlert(string v, List<KhachHang> khs)
        {
            throw new NotImplementedException();
        }
    }
}