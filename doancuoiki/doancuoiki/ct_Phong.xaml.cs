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
    public partial class ct_Phong : ContentPage
    {
        public ct_Phong()
        {
            InitializeComponent();
        }
        string mp = "";
        string ms = "";
        private async void HienThiCTPhong(string maphong, string msnv)
        {

            HttpClient http = new HttpClient();
            var a = await http.GetStringAsync("http://www.qllh.somee.com/api/serviceController/laychitietphong?maphong=" + maphong);
            var kq = JsonConvert.DeserializeObject<List<Phong>>(a);
            lstctphong.ItemsSource = kq;
            mp = maphong;
            ms = msnv;
        }
        public ct_Phong(string maphong, string msnv)
        {
            InitializeComponent();
            HienThiCTPhong(maphong, msnv);
            HienThiAnh(maphong);
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            await http.GetStringAsync("http://www.qllh.somee.com/api/serviceController/doitrangthai?maphong=" + mp +"&msnv=" + ms);
            await DisplayAlert("Thành công", "OK"+mp, "Thoát");
        }

        void HienThiAnh(string maphong)
        {
            if (maphong.Contains("A"))
            {
                imgphong.Source = "nhaa.jpg";
            }else if (maphong.Contains("B"))
            {
                imgphong.Source = "nhab.jpg";
            }else if (maphong.Contains("C"))
            {
                imgphong.Source = "nhac.jpg";
            }else if(maphong.Contains("E"))
            {
                imgphong.Source = "nhae.jpg";
            }
        }
    }
}