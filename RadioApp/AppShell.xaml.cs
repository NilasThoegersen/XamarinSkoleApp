using System;
using System.Collections.Generic;
using RadioApp.ViewModels;
using RadioApp.Views;
using Xamarin.Forms;

namespace RadioApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
