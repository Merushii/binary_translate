using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace binarytranslate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BinToTextPage : ContentPage
    {
        public BinToTextPage()
        {
            InitializeComponent();
        }

        private void irPagTextToBin(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        public void translateTextToBinary(Object sender, EventArgs e)
        {
            string tempString = "";
            string Character = entryBinary.Text;
            byte[] Bytes = new byte[(Character.Length / 8) - 1 + 1];
            for (int Index = 0; Index <= Bytes.Length - 1; Index++)
            {
                Bytes[Index] = Convert.ToByte(Character.Substring(Index * 8, 8), 2);
            }
            tempString = Encoding.ASCII.GetString(Bytes);
            binaryInText.Text = String.Format(tempString);

        }

        private async void copyText(object sender, EventArgs e)
        {
            if (binaryInText.Text == null)
            {
                _ = DisplayAlert("", "El campo está vacío, traduzca un texto para poder copiar su traducción en código binario", "Aceptar");
            }
            else
            {
                await Clipboard.SetTextAsync(binaryInText.Text);
                await DisplayAlert("", "Se ha copiado correctamente al portapapeles", "Aceptar");
            }
        }

        private void borrarTexto(object sender, EventArgs e)
        {
            entryBinary.Text = null;
        }
    }
}