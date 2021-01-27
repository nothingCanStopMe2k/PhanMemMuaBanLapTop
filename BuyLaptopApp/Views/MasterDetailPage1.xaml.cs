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
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        string TEN;
        public MasterDetailPage1()
        {
            InitializeComponent();
            //MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }
        public MasterDetailPage1(string Ten)
        {
            InitializeComponent();
            //MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            TEN = Ten;
        }

        private void LstCaNhan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
        }

        private void LstGioHang_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cart());
        }

        private void LstTrangChu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home(TEN));
        }

        /*private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }*/
    }
}