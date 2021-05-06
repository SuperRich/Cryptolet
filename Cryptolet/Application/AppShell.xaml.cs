using Autofac;
using Cryptolet.Modules.AddTransaction;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Cryptolet
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<AppShellViewModel>();
            Routing.RegisterRoute(nameof(AddTransactionViewModel), typeof(AddTransactionView));
        }
    }
}
