using Newtonsoft.Json;
using SwApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwApi.Services
{
    public class SwService : ISwService
    {
        private const string ApiUrl = "https://starwars.egghead.training/people";

        public async Task<IEnumerable<Character>> GetStarWarsCharactersAsync()
        {
            var client = new HttpClient();
            var message = await client.GetAsync(ApiUrl);
            IEnumerable<Character> characters = new List<Character>();

            if (message.IsSuccessStatusCode)
            {
                characters = await GetEntitiesFromJsonAsync(message);
            }

            return characters;
        }

        private async Task<IEnumerable<Character>> GetEntitiesFromJsonAsync(HttpResponseMessage message)
        {
            string json = await message.Content.ReadAsStringAsync();

            try
            {
                var result = JsonConvert.DeserializeObject<IEnumerable<Character>>(json);
                return (result ?? Array.Empty<Character>()).Take(10);
            }
            catch (Exception e)
            {
                throw new JsonSerializationException("Cannot convert from entity", e);
            }
        }
    }
}