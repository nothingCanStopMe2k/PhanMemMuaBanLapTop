using BuyLaptopApp.Models;
using Newtonsoft.Json;
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

        private async void DangNhapVoiFB_Clicked(object sender, EventArgs e)
        {

                String kq = "[{'SODT': '0333619358', 'HOTEN': 'Nguyễn Hữu Tiến', 'MATKHAU': '123456'}]";
                Database db = new Database();
                var khs = JsonConvert.DeserializeObject<List<KhachHang>>(kq);
                db.Them_Khachhang(khs[0]);
                await Navigation.PushAsync(new MasterDetailPage1("Nguyễn Hữu Tiến"));
            
           
        }
    }
}