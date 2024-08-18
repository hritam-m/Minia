using Microsoft.AspNetCore.Mvc;
using Minia.Models;

namespace Minia.Controllers
{
    public class ShopController : BaseController
    {
        private readonly ILogger<ShopController> _logger;

        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;
        }

        public IActionResult Products()
        {
            try
            {
                var products = new List<ProductModel>
                {
                    new ProductModel { Title = "Teddy Bear Coats", Description = "Some quick example text...", Price = 1250.00m, ImageUrl = "~/assets/images/products/product-1.jpg" },
                    new ProductModel { Title = "Fine-knit Sweater", Description = "Some quick example text...", Price = 1250.00m, ImageUrl = "~/assets/images/products/product-2.jpg" },
                    new ProductModel { Title = "Checkered Crop Top", Description = "Some quick example text...", Price = 1250.00m, ImageUrl = "~/assets/images/products/product-3.jpg" },
                    new ProductModel { Title = "Plaid Long-sleeve Shirt", Description = "Some quick example text...", Price = 1250.00m, ImageUrl = "~/assets/images/products/product-4.jpg" }
                };
                return HandleView("Products", "_Products", products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while serving the Index view.");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
