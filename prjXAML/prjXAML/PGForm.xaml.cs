using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prjXAML.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PGForm : ContentPage
    {
        List<C假單> list = new List<C假單>();

        public PGForm()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            list.Add(new C假單() { id = 1, 日期 = "2022/08/26", 核可 = false, 申請人 = "Gina", 理由 = "不想上班", 核可人 = "Holt" });
            list.Add(new C假單() { id = 123, 日期 = "2022/09/26", 核可 = false, 申請人 = "Jake", 理由 = "結婚", 核可人 = "Holt" });
            list.Add(new C假單() { id = 189, 日期 = "2022/11/26", 核可 = true, 申請人 = "Terry", 理由 = "照顧小孩", 核可人 = "Holt" });
        }

        private void btnfirst_Clicked(object sender, EventArgs e)
        {
            position = 0;
            NewMethod();
        }
        int position;
        private void btnlast_Clicked(object sender, EventArgs e)
        {
            position = list.Count - 1;
            
            NewMethod();
        }

        private void NewMethod()
        {
            txtdate.Text = list[position].日期;
            txtid.Text = list[position].id.ToString();
            txtname.Text = list[position].申請人;
            txtmanager.Text = list[position].核可人;
            txtreason.Text = list[position].理由;
            ckb核可.IsChecked = list[position].核可;
        }

        private void btpre_Clicked(object sender, EventArgs e)
        {
            position--;
            if (position < 0)
                position = 0;
            NewMethod();
        }

        private void btnnext_Clicked(object sender, EventArgs e)
        {
            position++;
            if (position >=list.Count)
                position = list.Count-1;
            NewMethod();
        }

        private void btnsearch_Clicked(object sender, EventArgs e)
        {
           
        }

        private void btnlist_Clicked(object sender, EventArgs e)
        {
            (Application.Current as App).forms = this.list;
            Navigation.PushAsync(new PGList());
        }
    }
}