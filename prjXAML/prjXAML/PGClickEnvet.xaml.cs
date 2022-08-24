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
    public partial class PGClickEnvet : ContentPage
    {
        public PGClickEnvet()
        {
            InitializeComponent();
        }

        private void btnok_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtx.Text);
            double b = Convert.ToDouble(txty.Text);
            double c = Convert.ToDouble(txtz.Text);
            double d = b * b - 4 * a * c;
            //d = Math.Sqrt(d);
            //ans.Text = "X=" + ((-b + d) / (2 * a)).ToString();
            double r = b * b - 4 * a * c;
            r = Math.Sqrt(r);
            ans.Text = "X=" + ((-b + r) / (2 * a)).ToString("0.0#") +
                " OR X=" + ((-b - r) / (2 * a)).ToString("0.0#");


        }
    }
}