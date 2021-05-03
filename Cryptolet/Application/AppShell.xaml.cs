using Autofac;
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
        }
    }
}
