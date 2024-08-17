using CryptoApi.Repository.ExternalServices.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptoApi.Repository.ExternalServices
{
    public class CryptoCoinGeckoApi : ICryptoCoinGeckoApi
    {
        private readonly IHttpClient _httpClient;

        public CryptoCoinGeckoApi(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CryptoDetailsDto> GetCryptoDetailsDto(string id)
        {
            var url = $"https://api.coingecko.com/api/v3/coins/{id}?localization=false&tickers=false&market_data=true&community_data=false&developer_data=false";
            var response = await _httpClient.GetAsync(url);
            return JsonConvert.DeserializeObject<CryptoDetailsDto>(response);
        }

        public async Task<List<CryptocurrenciesDto>> GetCryptosApi()
        {
            var url = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1";
            var response = await _httpClient.GetAsync(url);
            return JsonConvert.DeserializeObject<List<CryptocurrenciesDto>>(response);
        }
    }
}
