using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cryptolet.Modules.Loading
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingView : ContentPage
    {
        public LoadingView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<LoadingViewModel>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await (BindingContext as LoadingViewModel).InitializeAsync(null);
        }
    }
}