using Microsoft.AspNetCore.Mvc;

namespace Minia.Controllers;

public abstract class BaseController : Controller
{
    protected IActionResult HandleView(string? viewName = "Index", string partialViewName = "_Index")
    {
        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView(partialViewName);
        }

        if (!string.IsNullOrEmpty(viewName))
        {
            return View(viewName);
        }

        return View();
    }
}
