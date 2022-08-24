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
    public partial class PGList : ContentPage
    {
        public PGList()
        {
            InitializeComponent();
            List<C假單> list = (Application.Current as App).forms;
            lv假單.ItemsSource = list;
        }

        private void lv假單_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}