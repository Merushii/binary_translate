using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace binarytranslate
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BinToTextPage : ContentPage
	{
		public BinToTextPage ()
		{
			InitializeComponent ();
		}

        private void irPagTextToBin(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}