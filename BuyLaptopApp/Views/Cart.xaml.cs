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
    public partial class Cart : ContentPage
    {
        public Cart()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            Database db = new Database();
            List<Laptop> carts = db.LayThongTinLaptop();
            lstcart.ItemsSource = carts;
            sum.Text = tinhTongGia(carts).ToString();
        }

        public long tinhTongGia(List<Laptop> carts)
        {
            long tong = 0;
            if(carts != null)
            {
                foreach (Laptop cart in carts)
                {
                    tong += int.Parse(cart.GIA);
                }
            }
            
            return tong;
        }

        private async void lstcart_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var res = await DisplayAlert("Thông báo", "Bạn có muốn xóa sản phẩm không?", "Đồng ý", "Hủy");

            if (res.ToString() == "True")
            {
                Laptop lt = (Laptop)lstcart.SelectedItem;
                Database db = new Database();
                if (db.Xoa_Laptop(lt.MALT) == true)
                {
                    await DisplayAlert("Thông báo", "Xóa thành công", "Đồng ý");
                    HienThi();
                }
            }
        }
    }
}