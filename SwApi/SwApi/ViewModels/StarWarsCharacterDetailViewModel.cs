using SwApi.Models;
using SwApi.Services;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SwApi.ViewModels
{
    [QueryProperty(nameof(CharacterID), nameof(CharacterID))]
    public class StarWarsCharacterDetailViewModel
    {
        private int characterId;
        public Character Character { get; set; }
        private ISwService service => DependencyService.Get<ISwService>();

        public int CharacterID
        {
            get => characterId;
            set
            {
                characterId = value;
                LoadCharactedIdAsync(value);
            }
        }

        private async void LoadCharactedIdAsync(int value)
        {
            IEnumerable<Character> characters = await service.GetStarWarsCharactersAsync();
            Character = characters.FirstOrDefault(x => x.Id == value);
        }
    }
}