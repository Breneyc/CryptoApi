using CryptoApi.Domain.Models.Request;
using CryptoApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi.Domain.Contracts
{
    public interface IFavoriteCryptocurrenciesService
    {
        Task<bool> DeleteFavoriteAsync(int id);
        Task<List<FavoriteCryptocurrencies>> GetFavorites();
        Task<FavoriteCryptocurrencies> AddFavorite(AddFavoriteCryptocurrencies request);
    }
}
