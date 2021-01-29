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
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }

        private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync("http://www.qllt.somee.com/api/serviceController/timkiem?tukhoa=" + search.Text);
            var dstk = JsonConvert.DeserializeObject<List<Laptop>>(kq);
            lstTk.ItemsSource = dstk;
        }

        private void lstTk_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Laptop lt = (Laptop)lstTk.SelectedItem;
            Navigation.PushAsync(new Detail(lt));
        }
    }
}