using CryptoApi.Domain.Contracts;
using CryptoApi.Domain.Models;
using CryptoApi.Domain.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CryptoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteCryptocurrenciesController : ControllerBase
    {
        private readonly IFavoriteCryptocurrenciesService _favoriteCryptocurrenciesService;

        public FavoriteCryptocurrenciesController(IFavoriteCryptocurrenciesService favoriteCryptocurrenciesService)
        {
            _favoriteCryptocurrenciesService = favoriteCryptocurrenciesService;
        }

        // GET: api/<FavoriteCryptocurrenciesController>
        [HttpGet]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetFavorites()
        {
            var response = await _favoriteCryptocurrenciesService.GetFavorites();
            return Ok(response);
        }

        // POST api/<FavoriteCryptocurrenciesController>
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.Created)]
        [SwaggerResponse((int)HttpStatusCode.Conflict, "La criptomoneda ya está en la lista de favoritos.")]
        public async Task<IActionResult> AddFavorite([FromBody] AddFavoriteCryptocurrencies request)
        {
            try
            {
                var response = await _favoriteCryptocurrenciesService.AddFavorite(request);
                return CreatedAtAction(nameof(GetFavorites), response);
            }
            catch (InvalidOperationException e)
            {
                return Conflict(new {message  = e.Message});
            }
        }

        // DELETE api/<FavoriteCryptocurrenciesController>/5
        [HttpDelete("{id}")]
        [SwaggerResponse((int)HttpStatusCode.NoContent)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteFavorite(int id)
        {
            var success = await _favoriteCryptocurrenciesService.DeleteFavoriteAsync(id);
            if (!success)
            {
                return NotFound(new { message = $"La criptomoneda con Id = {id} no fue encontrada." });
            }

            return Ok(new {message = $"La criptomoneda fue eliminada de manera exitosa"});
        }

    }
}
