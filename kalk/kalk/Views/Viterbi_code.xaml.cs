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
    public partial class Viterbi_code : ContentPage
    {
        public Viterbi_code()
        {
            InitializeComponent();
        }

        private void encode(object sender, EventArgs e)
        {
            string localisation;
            if (lvl_d.IsChecked == true)
            {
                localisation = "d";
            }
            else if (lvl_b.IsChecked == true)
            {
                localisation = "b";
            }
            else if (lvl_c.IsChecked == true)
            {
                localisation = "c";
            }
            else
            {
                localisation = "a";
            }
            viterbi_data_out.Text = Viterbi_Methods.code(viterbi_data_in.Text, localisation);
        }
    }
}