using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuyLaptopApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Database db = new Database();
            db.DeleteDatabase();
            db.CreateDatabase();
            MainPage = new NavigationPage(new Views.SignUp());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
