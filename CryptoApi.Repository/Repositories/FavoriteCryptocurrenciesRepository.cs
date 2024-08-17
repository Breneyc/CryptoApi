using CryptoApi.Domain.Contracts;
using CryptoApi.Domain.Models;
using CryptoApi.Domain.Models.Request;
using CryptoApi.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi.Repository.Repositories
{
    public class FavoriteCryptocurrenciesRepository : IFavoriteCryptocurrenciesRepository
    {
        private readonly AppDbContext _appDbContext;

        public FavoriteCryptocurrenciesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<FavoriteCryptocurrencies> AddFavorite(AddFavoriteCryptocurrencies request)
        {
            var favorite = new FavoriteCryptocurrencies { Name = request.Name, Symbol = request.Symbol, UrlImage = request.UrlImage };
            await _appDbContext.FavoriteCryptocurrencies.AddAsync(favorite);
            await _appDbContext.SaveChangesAsync();
            return favorite;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var favorite = await _appDbContext.FavoriteCryptocurrencies.FirstOrDefaultAsync(f => f.Id == id);
            if (favorite != null)
            {
                _appDbContext.FavoriteCryptocurrencies.Remove(favorite);
                await _appDbContext.SaveChangesAsync();
                return true; 
            }
            return false;
        }

        public async Task<List<FavoriteCryptocurrencies>> GetFavorites()
        {
            var response = await _appDbContext.FavoriteCryptocurrencies.ToListAsync();
            return response;
        }

        public async Task<bool> ExistsAsync(string name, string symbol)
        {
            return await _appDbContext.FavoriteCryptocurrencies
                .AnyAsync(f => f.Name == name && f.Symbol == symbol);
        }
    }
}
