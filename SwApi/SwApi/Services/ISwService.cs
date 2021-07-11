using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using SwApi.Models;

namespace SwApi.Services
{
    public interface ISwService
    {
        Task<IEnumerable<Character>> GetStarWarsCharactersAsync();
    }
}