using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp_04_Korngold_Chinski.Models;

namespace Tp_04_Korngold_Chinski.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
