using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prjXAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PGCal : ContentPage
    {
        public PGCal()
        {
            InitializeComponent();
        }
        //string str上一組 = "";
        //string str這一組 = "";
        //string str符號 = "";


        string num當下, num紀錄符號 ,num暫存;
        string num上次 = "";
        bool flag = false;
        bool flag1 = false;
        private void clickbtn(object sender, EventArgs e)
        {
            Button b = sender as Button;

            //num上次 += b.Text;
            if (flag == true)
            {

                labTo.Text = "";
                flag = false;

            }

            labTo.Text += b.Text;
            num當下 = labTo.Text;
            
            
        }
       //int count=0;
        private void clickari(object sender, EventArgs e)
        {
            //count++;
            //if(str上一組!="")
            //{
            //    str上一組 = str這一組;
            //}
            //Button bu = sender as Button;
            //str符號+= bu.Text;
            Button bu = sender as Button;
            num紀錄符號 = bu.Text;
            flag = true;
            flag1 = false;
            num上次 = labTo.Text;

            if (flag == true)
            {

                labTo.Text = method2();
                num暫存 = labTo.Text;
            }
            //if (count % 2 == 0)
            //{
            //    labTo.Text = method1();
            //    num上次 = labTo.Text;
            //}

            //if (flag1 == true)
            //{
            //    labTo.Text = method1();
            //}
            //else
            //    flag1 = true;
            //if (flag1 == true)   //+=功能
            //{
            //    labTo.Text = method1();
            //    num上次 = labTo.Text;
            //    num當下 = labTo.Text;
            //    //flag1 = false;
            //}
            //else
            //    flag1 = true;

        }
        bool flag2 = false;
        private void clickeq(object sender, EventArgs e)
        {
            //if (count != 0)
            //{
            //    num紀錄符號
            //}
            labTo.Text = method1();
            if (flag2 == true)
            {
                num上次 = labTo.Text;
                labTo.Text = method1();
            
            }
            else
                flag2 = true;
            //s = "";
        }

        string method1()
        {
            //if(str這一組=="")
            //{

            //}
            //if(str上一組!="")
            //{

            //}
            //DataTable dt = new DataTable();
            //var a = dt.Compute(str, "");
            //labTo.Text=
            #region
            var p = num上次 + num紀錄符號 + num當下;
            //double result;
            DataTable dt = new DataTable();
            var a = dt.Compute(p, "");
            //result =a.ToString();             
            return a.ToString();
            #endregion
        }
        string method2()
        {
            
            var p = num暫存 + num紀錄符號 + num當下;           
            DataTable dt = new DataTable();
            var a = dt.Compute(p, "");                   
            return a.ToString();          
        }
        private void clickbac(object sender, EventArgs e)
        {
            labTo.Text = "";
            num當下 = "";
            num紀錄符號 = "";
            num暫存 = "";
            num上次 = "";
        }
    }
}