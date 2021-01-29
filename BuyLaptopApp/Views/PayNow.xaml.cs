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
    public partial class PayNow : ContentPage
    {
        public PayNow()
        {
            InitializeComponent();
            List<bank> bank = new List<bank>();
            bank.Add(new bank() { Name = "Ngân hàng Vietcombank" });
            bank.Add(new bank() { Name = "Ngân hàng BIDV" });
            bank.Add(new bank() { Name = "Ngân hàng TPBANK" });
            bank.Add(new bank() { Name = "Ngân hàng Sacombank" });
            bank.Add(new bank() { Name = "Thanh toán MoMo" });
            bank.Add(new bank() { Name = "Khác" });
            lstNganhang.ItemsSource = bank;
        }
    }
}