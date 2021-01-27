using BuyLaptopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private void HienThiNSX()
        {
            List<NhaSanXuat> lstsx = new List<NhaSanXuat>();
            lstsx.Add(new NhaSanXuat { MANSX = "acer", TEN = "ACER", HINH = "acer.jpg" });
            lstsx.Add(new NhaSanXuat { MANSX = "asus", TEN = "ASUS", HINH = "asus.jpg" });
            lstsx.Add(new NhaSanXuat { MANSX = "dell", TEN = "DELL", HINH = "dell.jpg" });
            lstnsx.ItemsSource = lstsx;
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
    }
}