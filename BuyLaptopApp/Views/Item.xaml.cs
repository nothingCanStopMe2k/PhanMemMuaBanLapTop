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
    public partial class Item : ContentPage
    {
        public Item()
        {
            InitializeComponent();
        }

        public Item(NhaSanXuat nsx)
        {
            InitializeComponent();
            HienThiLT(nsx);
        }

        private async void HienThiLT(NhaSanXuat nsx)
        {
            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync("http://www.qllt.somee.com/api/serviceController/layLT?mansx=" + nsx.MANSX);
            var lts = JsonConvert.DeserializeObject<List<Laptop>>(kq);

            
            lstlt.ItemsSource = lts;
        }

        private void Lstlt_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Laptop lt = (Laptop)lstlt.SelectedItem;
            Navigation.PushAsync(new Detail(lt));
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