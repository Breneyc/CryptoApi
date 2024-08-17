using CryptoApi.Repository.ExternalServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi.Repository.ExternalServices
{
    public interface ICryptoCoinGeckoApi
    {
        Task<List<CryptocurrenciesDto>> GetCryptosApi();
        Task<CryptoDetailsDto> GetCryptoDetailsDto(string id);
    }
}
