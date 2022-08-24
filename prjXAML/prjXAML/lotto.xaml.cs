using prjXAML.Models;
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
    public partial class lotto : ContentPage
    {
        public lotto()
        {
            InitializeComponent();
        }


        private void btnok_Clicked(object sender, EventArgs e)
        {
            lottop lot = new lottop();
            lo.Text=lot.getnum();
        }
    }
}