using CryptoApi.Repository.ExternalServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace CryptoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoCoinGeckoApiController : ControllerBase
    {
        private readonly ICryptoCoinGeckoApi _cryptoCoinGeckoApi;

        public CryptoCoinGeckoApiController(ICryptoCoinGeckoApi cryptoCoinGeckoApi)
        {
            _cryptoCoinGeckoApi = cryptoCoinGeckoApi;
        }

        [HttpGet]
        public async Task<IActionResult> GetCryptosApi()
        {
            var data = await _cryptoCoinGeckoApi.GetCryptosApi();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCryptoDetailsDto(string id)
        {
            var data = await _cryptoCoinGeckoApi.GetCryptoDetailsDto(id);
            return Ok(data);
        }
    }
}
