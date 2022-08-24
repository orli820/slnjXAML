using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prjXAML
{
    public partial class MainPage : ContentPage
    {
        
       
        public MainPage()
        {
            InitializeComponent();
            lbhello.Text = "Hello C#";
            Random r = new Random();
            List<string> a=new List<string>() { "紅", " 黃", "藍", "綠" };            
            int i = r.Next(0,a.Count);
            lab1.Text = a[i];
            a.RemoveAt(i);
             i = r.Next(0, a.Count);
            lab2.Text = a[i];
            a.RemoveAt(i);
             i = r.Next(0, a.Count);
            lab3.Text = a[i];
            a.RemoveAt(i);
            lab4.Text = a[0];

        }
       
       
        

    }

}
