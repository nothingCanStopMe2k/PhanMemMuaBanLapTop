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

        private void HienThiLT(NhaSanXuat nsx)
        {
            List<Laptop> dslt = new List<Laptop>();
            switch (nsx.MANSX)
            {
                case "dell":
                    dslt.Add(new Laptop { MALT = "de01", MANSX = "dell", TEN = "Dell XPS 17 9700 (2020)", HINH = "dellxps17.jpg", MOTA = "17.3\" Windown 10 Core™ i5 - 10300H / RAM 8GB / SSD 256GB / FHD / Share", GIA = 30000000 });
                    break;
                case "asus":
                    dslt.Add(new Laptop { MALT = "as01", MANSX = "asus", TEN = "Asus ZenBook Duo UX481FL BM048T", HINH = "asuszenbookdouux481xl.jpg", MOTA = "i5 10210U/8GB/512GB SSD/WIN10", GIA = 30990000 });
                    break;
                default:
                    break;
            }
            lstlt.ItemsSource = dslt;
        }

        private void lstlt_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Laptop lt = (Laptop)lstlt.SelectedItem;
            Navigation.PushAsync(new Detail(lt));
        }
    }
}