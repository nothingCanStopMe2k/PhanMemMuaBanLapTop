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
    public partial class Detail : ContentPage
    {
        Laptop l = new Laptop();

        public Detail()
        {
            InitializeComponent();
        }

        public Detail(Laptop lt)
        {
            InitializeComponent();
            List<Laptop> lstlt = new List<Laptop>();
            lstlt.Add(lt);
            ctsp.ItemsSource = lstlt;
            l = lt;
        }

        private void btnAddtoCart_Clicked(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.Them_Laptop(l) == true)
            {
                DisplayAlert("Thông báo", "Thêm thành công", "Đồng ý");
                Navigation.PushAsync(new Home());
            }
        }
    }
}