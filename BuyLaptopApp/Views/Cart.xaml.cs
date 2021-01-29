using BuyLaptopApp.Models;
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
    public partial class Cart : ContentPage
    {
        string sohd, sodt, trigia;
        List<Laptop> carts = new List<Laptop>();

        public Cart()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            Database db = new Database();
            List<KhachHang> kh = new List<KhachHang>();

            carts = db.LayThongTinLaptop();
            kh = db.LayThongTinKH();

            lstcart.ItemsSource = carts;
            sodt = kh[0].SODT;
            sum.Text = tinhTongGia(carts).ToString() + "vnd";
            trigia = tinhTongGia(carts).ToString();
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

        public async void themct(List<Laptop> carts, string sohd)
        {
            HttpClient http = new HttpClient();
            foreach (Laptop cart in carts)
            {
                await http.GetStringAsync("http://www.qllt.somee.com/api/serviceController/themCTHD?sohd="+ sohd +"&malt=" + cart.MALT);
            }
        }

        private async void Btnbook_Clicked(object sender, EventArgs e)
        {
            if(trigia != "0")
            {
                Random r = new Random();
                sohd = r.Next(2, 100).ToString();

                HttpClient http = new HttpClient();
                var kq = await http.GetStringAsync("http://www.qllt.somee.com/api/serviceController/themHD?sohd=" + sohd + "&sodt=" + sodt + "&trigia=" + trigia);
                if (kq != "[{\"Column1\":\"fail\"}]")
                {
                    await DisplayAlert("Thông báo", "Đặt hàng thành công", "Đồng ý");
                    themct(carts, sohd);
                    await Navigation.PushAsync(new PayNow());
                }
                else
                {
                    await DisplayAlert("Thông báo", "Đặt hàng thất bại. Vui lòng thử lại", "Đồng ý");
                }
            }
            else
            {
                await DisplayAlert("Thông báo", "Đặt hàng thất bại. Vui lòng thử lại", "Đồng ý");
            }
        }
    }
}