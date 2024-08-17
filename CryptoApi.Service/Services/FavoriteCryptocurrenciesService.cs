using CryptoApi.Domain.Contracts;
using CryptoApi.Domain.Models;
using CryptoApi.Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi.Service.Services
{
    public class FavoriteCryptocurrenciesService : IFavoriteCryptocurrenciesService
    {
        private readonly IFavoriteCryptocurrenciesRepository _repository;

        public FavoriteCryptocurrenciesService(IFavoriteCryptocurrenciesRepository repository)
        {
            _repository = repository;
        }

        public async Task<FavoriteCryptocurrencies> AddFavorite(AddFavoriteCryptocurrencies request)
        {
            var exists = await _repository.ExistsAsync(request.Name, request.Symbol);
            if (exists)
            {
                throw new InvalidOperationException("La criptomoneda ya está en la lista de favoritos.");
            }
            var response = await _repository.AddFavorite(request);
            return response;
        }

        public async Task<bool> DeleteFavoriteAsync(int id)
        {
            var response = await _repository.DeleteAsync(id);
            return response;
        }

        public async Task<List<FavoriteCryptocurrencies>> GetFavorites()
        {
            var response = await _repository.GetFavorites();
            return response;
        }
    }
}
