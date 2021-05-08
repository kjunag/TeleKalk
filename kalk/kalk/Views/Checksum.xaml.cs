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
    public partial class Checksum : ContentPage
    {
        public Checksum()
        {
            InitializeComponent();
        }

        private void add_word(object sender, EventArgs e)
        {
            try
            {
                Checksum_Methods.addToList(checksum_data_in.Text);
                word_list_view.Items.Add(checksum_data_in.Text);
            }
            catch (FormatException)
            {
                DisplayAlert("zły format", "wprowadź prawidłowy ciąg znaków", "OK");
            }
            checksum_data_in.Text = null;
        }

        private void reset(object sender, EventArgs e)
        {
            word_list_view.Items.Clear();
            Checksum_Methods.clearList();
            checksum_data_in.Text = null;
            checksum_data_out.Text = null;
        }

        private void calc(object sender, EventArgs e)
        {
            checksum_data_out.Text = Checksum_Methods.CalcChecksum().ToString();
        }

        
    }
}