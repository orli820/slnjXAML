using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prjXAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page : ContentPage
    {
        public Page()
        {
            InitializeComponent();
        }

        private void btngotopage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void btnuser_Clicked(object sender, EventArgs e)
        {
            App a = Application.Current as App;
            if (a == null)
                return;
            a.username = "Marco";
            Navigation.PushAsync(new Page2());

        }
    }
}