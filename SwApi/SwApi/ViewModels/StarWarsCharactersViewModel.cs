using System;
using SwApi.Models;
using SwApi.Services;
using SwApi.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace SwApi.ViewModels
{
    public class StarWarsCharactersViewModel : BaseViewModel
    {
        private ISwService _service => DependencyService.Get<ISwService>();
        private Character _selectedCharacter;

        public ObservableCollection<Character> Characters { get; set; } = new ObservableCollection<Character>();
        public Command LoadItemsCommand { get; }
        public Command<Character> ItemTapped { get; }

        public StarWarsCharactersViewModel()
        {
            LoadItemsCommand = new Command(async () => await ExecuteLoadCharactersCommand());
            ItemTapped = new Command<Character>(OnItemSelected);
        }

        private async Task ExecuteLoadCharactersCommand()
        {
            IsBusy = true;
            Characters.Clear();

            IEnumerable<Character> characters = await _service.GetStarWarsCharactersAsync();

            foreach (Character character in characters)
            {
                if (Device.RuntimePlatform == Device.Android)
                {
                    if (character.Image.Contains("-"))
                    {
                        character.Image = character.Image.Replace("-", "");
                    }
                }
                Characters.Add(character);
            }

            IsBusy = false;
        }

        public Character SelectedCharacter
        {
            get => _selectedCharacter;
            set
            {
                SetProperty(ref _selectedCharacter, value);
                OnItemSelected(value);
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedCharacter = null;
        }

        private async void OnItemSelected(Character character)
        {
            if (character == null)
            {
                return;
            }

            await Shell.Current.GoToAsync($"{nameof(StarWarsCharacterDetailPage)}?{nameof(StarWarsCharacterDetailViewModel.CharacterID)}={character.Id}");
        }
    }
}