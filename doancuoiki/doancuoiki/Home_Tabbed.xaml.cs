
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Newtonsoft.Json;


namespace doancuoiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home_Tabbed : ContentPage
    {
        public string nv = "";
        public string msnv = "";

        public Home_Tabbed()
        {
            InitializeComponent();
        
        }

        public Home_Tabbed(string a)
        {
            InitializeComponent();
            nv = a;
            var kq = JsonConvert.DeserializeObject<List<NhanVien>>(a);
            msnv = kq[0].MSNV;
            lstChao.Text = "Chúc " + kq[0].HOTEN + " một ngày mới tốt lành!";
        }

        private void Lsttoa_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Toa t = (Toa)e.SelectedItem;
            Navigation.PushAsync(new mh_Phong(t.MATOA, msnv));
        }

        private void LstTA_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new mh_Phong("TA", msnv));
        }

        private void LstTB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new mh_Phong("TB", msnv));
        }

        private void LstTC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new mh_Phong("TC", msnv));
        }

        private void LstTE_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new mh_Phong("TE", msnv));
        }

        private void navhome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home_Tabbed());
        }

        private void navprofile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile_Tabbed(nv));
        }

        private void navnofi_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Setting_Tabbed());
        }
    }
}