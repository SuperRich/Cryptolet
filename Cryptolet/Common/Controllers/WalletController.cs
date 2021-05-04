using Cryptolet.Common.Models;
using Cryptollet.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cryptolet.Common.Controllers
{
    public interface IWalletController
    {
        Task<List<Transaction>> GetTransactions(bool forceReload = false);
        Task<List<Coin>> GetCoins(bool forceReload = false);
    }
    public class WalletController : IWalletController
    {

        private List<Coin> _defaultAssets = new List<Coin>
        {
                new Coin
                {
                    Name = "Bitcoin",
                    Amount = 1,
                    Symbol = "BTC",
                    DollarValue = 60000
                },
                new Coin
                {
                    Name = "Ethereum",
                    Amount = 2,
                    Symbol = "ETH",
                    DollarValue = 3000
                },
                new Coin
                {
                    Name = "Litecoin",
                    Amount = 3,
                    Symbol = "LTC",
                    DollarValue = 500
                },
        };

        private List<Transaction> _defaultTransactions= new List<Transaction>
        {
                new Transaction
                {
                    Amount = 1,
                    Symbol = "BTC",
                    DollarValue = 60000,
                    TransactionDate = DateTime.Now,
                    Status = Constants.TRANSACTION_DEPOSITED,
                    StatusImageSource = Constants.TRANSACTION_DEPOSITED_IMAGE
                },
                new Transaction
                {
                    Amount = 1,
                    Symbol = "ETH",
                    DollarValue = 3000,
                    TransactionDate = DateTime.Now,
                    Status = Constants.TRANSACTION_DEPOSITED,
                    StatusImageSource = Constants.TRANSACTION_DEPOSITED_IMAGE
                },
                new Transaction
                {
                    Amount = 1,
                    Symbol = "LTC",
                    DollarValue = 500,
                    TransactionDate = DateTime.Now,
                    Status = Constants.TRANSACTION_DEPOSITED,
                    StatusImageSource = Constants.TRANSACTION_DEPOSITED_IMAGE
                }
        };
        public Task<List<Coin>> GetCoins(bool forceReload = false)
        {
            return Task.FromResult(_defaultAssets);
        }

        public Task<List<Transaction>> GetTransactions(bool forceReload = false)
        {
            return Task.FromResult(_defaultTransactions);
        }
    }
}
