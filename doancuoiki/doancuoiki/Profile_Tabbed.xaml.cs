using Newtonsoft.Json;
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
    public partial class Profile_Tabbed : ContentPage
    {
        public Profile_Tabbed()
        {
            InitializeComponent();
        }

        public Profile_Tabbed(string nv)
        {
            InitializeComponent();
            var kq = JsonConvert.DeserializeObject<List<NhanVien>>(nv);
            lstnv.ItemsSource = kq;
            LayThongBaoCaNhan(kq[0].MSNV);
        }

        public async void LayThongBaoCaNhan(string msnv)
        {
            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync("http://www.qllh.somee.com/api/serviceController/laytbnhanvien?msnv=" + msnv);
            var tb = JsonConvert.DeserializeObject<List<ThongBao>>(kq);
            lsttb.ItemsSource = tb;
        }

        private void navhome1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home_Tabbed());
        }

        private void navprofile1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile_Tabbed());
        }

        private void navsetting1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Setting_Tabbed());
        }
    }
}