using prjXAML.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prjXAML
{
    public partial class App : Application
    {
        public string username { get; set; }
        public List<C假單> forms{ get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PGForm());
            //MainPage = new NavigationPage(new Page());
            //MainPage = new PGCal();
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
