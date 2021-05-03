using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cryptolet.Modules.Wallet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalletView : ContentPage
    {
        public WalletView()
        {
            InitializeComponent();
        }
    }
}