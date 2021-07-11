using SwApi.Views;
using System;
using Xamarin.Forms;

namespace SwApi
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(StarWarsCharactersPage), typeof(StarWarsCharactersPage));
            Routing.RegisterRoute(nameof(StarWarsCharacterDetailPage), typeof(StarWarsCharacterDetailPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}