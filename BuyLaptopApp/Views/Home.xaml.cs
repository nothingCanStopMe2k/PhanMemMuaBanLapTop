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
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            HienThiNSX();
        }

        private async void HienThiNSX()
        {
            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync("http://www.qllt.somee.com/api/serviceController/layNSX");
            var nsxs = JsonConvert.DeserializeObject<List<NhaSanXuat>>(kq);
            lstnsx.ItemsSource = nsxs;
        }

        public Home(string TenNguoiDung)
        {
            InitializeComponent();
            HienThiNSX();
            lstChao1.Text = "Xin chào, " + TenNguoiDung;
        }

        private void BtnCart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cart());
        }

        private void Lstnsx_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            NhaSanXuat nsx = (NhaSanXuat)lstnsx.SelectedItem;
            Navigation.PushAsync(new Item(nsx));
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cart());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Search());
        }
    }
}