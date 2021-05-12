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
    public partial class AMI_page : ContentPage
    {
        public AMI_page()
        {
            InitializeComponent();
        }

        private void btn_encode_Clicked(object sender, EventArgs e)
        {
            
            ami_data_out.Text = AMI_Methods.ami_encode(ami_data_in.Text);
        }
    }
}