﻿using Microsoft.AspNetCore.Mvc;

namespace Minia.Controllers;

public abstract class BaseController : Controller
{
    protected IActionResult HandleView(string? viewName = "Index", string partialViewName = "_Index", object? model = null)
    {
        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView(partialViewName, model);
        }

        if (!string.IsNullOrEmpty(viewName))
        {
            return View(viewName, model);
        }

        return View(model);
    }
}
