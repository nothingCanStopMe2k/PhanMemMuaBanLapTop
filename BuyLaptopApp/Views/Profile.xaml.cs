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
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
            HienThi();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cart());
        }

        private async void HienThi()
        {
            Database db = new Database();
            List<KhachHang> kh = db.LayThongTinKH();
            info.ItemsSource = kh;

            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync("http://www.qllt.somee.com/api/serviceController/layHD?sodt=" + kh[0].SODT);
            var hds = JsonConvert.DeserializeObject<List<HoaDon>>(kq);
            lsthd.ItemsSource = hds;
        }
        private void BtnDangXuat_Clicked(object sender, EventArgs e)
        {
            Database db = new Database();
            db.DeleteDatabase();
            Navigation.PushAsync(new SignUp());
        }
    }
}