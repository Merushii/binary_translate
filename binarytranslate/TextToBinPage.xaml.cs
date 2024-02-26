using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace binarytranslate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        private void translateToBinary(object sender, EventArgs e)
        {
            var texto = entryText.Text;
            if (entryText.Text == null)
            {
                DisplayAlert("Error", "La entrada de texto se encuentra vacía, por favor agregue un texto para traducir", "Aceptar");
            }
            else
            {
                var binaryString = ToBinary(ConvertToByteArray(texto, Encoding.ASCII));
                textInBinary.Text = binaryString;
            }
        }

        private async void copyBinaryText(object sender, EventArgs e)
        {
            if (textInBinary.Text == null)
            {
                _ = DisplayAlert("", "El campo está vacío, traduzca un texto para poder copiar su traducción en código binario", "Aceptar");
            }
            else
            {
                await Clipboard.SetTextAsync(textInBinary.Text);
                await DisplayAlert("", "Se ha copiado correctamente al portapapeles", "Aceptar");
            }
        }

        private void borrarTexto(object sender, EventArgs e)
        {
            entryText.Text = null;
        }

        private void irPagBinToText(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new BinToTextPage());
        }



       
    }
}
