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
    public partial class mh_Phong : ContentPage
    {
        public string ms = "";

        public mh_Phong()
        {
            InitializeComponent();
        }

        async void LayPhongTheoToa(string matoa, string msnv)
        {
            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync("http://www.qllh.somee.com/api/serviceController/getphong?matoa=" + matoa);
            var phongs = JsonConvert.DeserializeObject<List<Phong>>(kq);
            lstphong.ItemsSource = phongs;
            ms = msnv;
        }

        public mh_Phong(string matoa, string msnv)
        {
            InitializeComponent();
            LayPhongTheoToa(matoa, msnv);
        }

        private void Lstphong_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Phong t = (Phong)e.SelectedItem;
            Navigation.PushAsync(new ct_Phong(t.MAPHONG, ms));
        }
    }
}