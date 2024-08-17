using CryptoApi.Domain.Models;
using CryptoApi.Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi.Domain.Contracts
{
    public interface IFavoriteCryptocurrenciesRepository
    {
        Task<List<FavoriteCryptocurrencies>> GetFavorites();
        Task<FavoriteCryptocurrencies> AddFavorite(AddFavoriteCryptocurrencies request);
        Task<bool> DeleteAsync(int Id);
        Task<bool> ExistsAsync(string name, string symbol);
    }
}
