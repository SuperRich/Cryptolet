using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cryptolet.Modules.Onboarding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnboardingView : ContentPage
    {
        public OnboardingView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<OnboardingViewModel>();
        }
    }
}