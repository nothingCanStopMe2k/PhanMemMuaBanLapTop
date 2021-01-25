using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DangNhap : ContentPage
    {
        string TenNguoiDung;
        public DangNhap()
        {
            InitializeComponent();
        }
        public DangNhap(string Ten,string Email,string MatKhau)
        {
            InitializeComponent();
            lstEmail.Text = Email;
            lstMatKhau.Text = MatKhau;
            TenNguoiDung = Ten;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrangChu(TenNguoiDung));
        }
    }
}