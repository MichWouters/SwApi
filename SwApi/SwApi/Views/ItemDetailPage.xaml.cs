using SwApi.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SwApi.Views
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