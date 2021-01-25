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
    public partial class DangKi : ContentPage
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void ClickDangNhap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangNhap());
        }

        private void DangKiVoiEmail_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangKiVoiEmail());
        }

        private void DangNhapVoiFB_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrangChu("Tiến"));
        }
    }
}