using Microsoft.AspNetCore.Mvc;

namespace Minia.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if (Request.Headers["HX-Request"].Count > 0)
        {
            return PartialView("./Partials/_IndexPartial");
        }
        return View();
    }

    public IActionResult Privacy()
    {
        if (Request.Headers["HX-Request"].Count > 0)
        {
            return PartialView("./Partials/_PrivacyPartial");
        }
        return View();
    }

    public IActionResult About()
    {
        if (Request.Headers["HX-Request"].Count > 0)
        {
            return PartialView("./Partials/_AboutPartial");
        }
        return View();
    }
}
