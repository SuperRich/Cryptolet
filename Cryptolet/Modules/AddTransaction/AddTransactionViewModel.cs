using Cryptollet.Common.Base;
using Cryptollet.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cryptolet.Modules.AddTransaction
{
    [QueryProperty("Id", "id")]
    public class AddTransactionViewModel : BaseViewModel
    {

        public AddTransactionViewModel()
        {
            AvailableAssets = new ObservableCollection<Coin>(Coin.GetAvailableAssets());
        }

        private string _id;
        public string Id
        {
            set
            {
                _id = Uri.UnescapeDataString(value);
            }
        }

        private bool _isDeposit;
        public bool IsDeposit
        {
            get => _isDeposit;
            set { SetProperty(ref _isDeposit, value); }
        }

        private ObservableCollection<Coin> _availableAssets;
        public ObservableCollection<Coin> AvailableAssets
        {
            get => _availableAssets;
            set { SetProperty(ref _availableAssets, value); }
        }

        private Coin _selectedCoin;
        public Coin SelectedCoin
        {
            get => _selectedCoin;
            set { SetProperty(ref _selectedCoin, value); }
        }

        private DateTime _transactionDate = DateTime.Now;
        public DateTime TransactionDate
        {
            get => _transactionDate;
            set { SetProperty(ref _transactionDate, value); }
        }

        public ICommand AddTransactionCommand { get => new Command(async () => await AddTransaction(), () => IsNotBusy); }

        private async Task AddTransaction()
        {
           
        }
    }
}
