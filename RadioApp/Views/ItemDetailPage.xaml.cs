using System.ComponentModel;
using Xamarin.Forms;
using RadioApp.ViewModels;

namespace RadioApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}