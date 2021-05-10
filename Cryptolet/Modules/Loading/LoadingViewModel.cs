
using Cryptolet.Modules.Login;
using Cryptollet.Common.Base;
using Cryptollet.Common.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Cryptolet.Modules.Loading
{
    public class LoadingViewModel : BaseViewModel
    {

        private INavigationService _navigationService;

        public LoadingViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task InitializeAsync(object parameter)
        {

#if DEBUG
            Xamarin.Essentials.Preferences.Clear();
#endif


            if (!Preferences.ContainsKey(Constants.SHOWN_ONBOARDING))
            {
                Preferences.Set(Constants.SHOWN_ONBOARDING, true);

                _navigationService.GoToLoginFlow();
                return Task.CompletedTask;
            }

            if (Preferences.ContainsKey(Constants.IS_USER_LOGGED_IN) && Preferences.Get(Constants.IS_USER_LOGGED_IN, false) == true)
            {
                _navigationService.GoToMainFlow();
                return Task.CompletedTask;
            }

            _navigationService.GoToLoginFlow();
            return _navigationService.InsertAsRoot<LoginViewModel>();

        }
    }
}
