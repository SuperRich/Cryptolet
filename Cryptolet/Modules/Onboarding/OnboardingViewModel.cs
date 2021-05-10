using Cryptolet.Common.Models;
using Cryptolet.Modules.Login;
using Cryptollet.Common.Base;
using Cryptollet.Common.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cryptolet.Modules.Onboarding
{
    public class OnboardingViewModel : BaseViewModel
    {

        private INavigationService _navigationService;

        public OnboardingViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public ObservableCollection<OnboardingItem> OnboardingSteps { get; set; } = new ObservableCollection<OnboardingItem>
        {
            new OnboardingItem("welcome.png",
                "Welcome to Cryptolet",
                "Your own crypto wallet"),
            new OnboardingItem("welcome.png",
                "Welcome to your portfolio app",
                "The coolest crypto app out there"),
            new OnboardingItem("security.png",
                "Your Safety is Our Top Priority",
                "Your assets are secure with cryptolet")
        };

        public ICommand SkipCommand { get => new Command(async () => await FinishOnboarding()); }

        private async Task FinishOnboarding()
        {
            await _navigationService.InsertAsRoot<LoginViewModel>();
        }
    }
}
