﻿using Microsoft.AspNetCore.Mvc;

namespace Minia.Controllers;

public class DashbordController : BaseController
{
    private readonly ILogger<DashbordController> _logger;

    public DashbordController(ILogger<DashbordController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        try
        {
            return HandleView();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while serving the Index view.");
            return StatusCode(500, "Internal server error");
        }
    }
}
