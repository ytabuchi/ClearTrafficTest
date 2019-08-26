using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_ClearTrafficTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            goButton.Clicked += GoButton_Clicked;
        }

        private void GoButton_Clicked(object sender, EventArgs e)
        {
            webView.Source = urlText.Text;
        }
    }
}
