/*using APPTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace APPTest.Controllers
{
    public class CacheController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;

        public CacheController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("{Id}")]
        public IActionResult GetProductFromCache(int Id)
        {
            string key = $"Product_{Id}";
            var cachedProduct = _memoryCache.Get<Produit>(key);

            if (cachedProduct != null)
            {
                return Ok(cachedProduct);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("{Id}")]
        public IActionResult AddProductToCache(int Id, [FromBody] Produit product)
        {
            string key = $"Product_{Id}";

            // Ajouter l'objet en cache avec une durée de vie de 5 minutes
            _memoryCache.Set(key, product, TimeSpan.FromMinutes(5));

            return Ok();
        }
    }
}
*/