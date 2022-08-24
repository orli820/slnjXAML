using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prjXAML
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PGCal();
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
