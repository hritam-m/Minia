using Microsoft.AspNetCore.Mvc;

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
                return HandleView("Product", "_Products");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while serving the Index view.");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
