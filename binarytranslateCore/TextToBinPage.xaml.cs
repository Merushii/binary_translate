using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace binarytranslate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void irPagBinToText(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new BinToTextPage());
        }

       
    }
}
