using SwApi.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarWarsCharacterDetailPage : ContentPage
    {
        public StarWarsCharacterDetailPage()
        {
            InitializeComponent();
            BindingContext = new StarWarsCharacterDetailViewModel();
        }
    }
}