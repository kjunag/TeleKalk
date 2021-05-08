using kalk.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace kalk.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}