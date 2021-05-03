using Cryptolet.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Cryptolet.Views
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