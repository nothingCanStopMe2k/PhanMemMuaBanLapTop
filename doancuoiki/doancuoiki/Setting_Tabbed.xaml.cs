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
    public partial class Setting_Tabbed : ContentPage
    {
        public Setting_Tabbed()
        {
            InitializeComponent();
            laythongbao();
        }

        public async void laythongbao()
        {
            HttpClient http = new HttpClient();
            var a = await http.GetStringAsync("http://www.qllh.somee.com/api/serviceController/laythongbao");
            var kq = JsonConvert.DeserializeObject<List<ThongBao>>(a);
            lstnofi.ItemsSource = kq;
        }

        private void navhome2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home_Tabbed());
        }

        private void navprofile2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile_Tabbed());
        }

        private void navsetting2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Setting_Tabbed());
        }
    }
}