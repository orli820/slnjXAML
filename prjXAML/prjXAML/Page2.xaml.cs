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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            App a = Application.Current as App;
            if (a == null)
                return;
            labname.Text = "歡迎" + a.username + "登入聊天室";
        }

        private void btngoback_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}