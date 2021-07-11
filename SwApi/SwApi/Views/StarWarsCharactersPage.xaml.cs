using SwApi.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarWarsCharactersPage : ContentPage
    {
        private readonly StarWarsCharactersViewModel _viewModel;

        public StarWarsCharactersPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new StarWarsCharactersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}