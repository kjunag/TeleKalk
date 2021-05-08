using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kalk.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hamming_code : ContentPage
    {
        public Hamming_code()
        {
            InitializeComponent();
        }

        private void encode_7_4(object sender, EventArgs e)
        {
            if (btn_7_4.IsChecked == true)
            {
                hamming_data_out.Text = Hamming_Methods.hamming_7_4_encode(hamming_data_in.Text);
            }
            if (btn_15_11.IsChecked == true)
            {
                hamming_data_out.Text = Hamming_Methods.hamming_15_11_encode(hamming_data_in.Text);
            }
        }
    }
}