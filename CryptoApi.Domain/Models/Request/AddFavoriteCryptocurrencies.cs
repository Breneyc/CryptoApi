using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi.Domain.Models.Request
{
    public class AddFavoriteCryptocurrencies
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string UrlImage { get; set; }
    }
}
