using Cryptolet.Modules.Register;
using Cryptollet.Common.Base;
using Cryptollet.Common.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cryptolet.Modules.Login
{
    public class LoginViewModel : BaseViewModel
    {
        private INavigationService _navigationService;

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand RegisterCommand { get => new Command(async () => await GoToRegister()); }

        private async Task GoToRegister()
        {
            await _navigationService.InsertAsRoot<RegisterViewModel>();
        }
    }
}
