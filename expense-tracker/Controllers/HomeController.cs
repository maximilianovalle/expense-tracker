using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using expense_tracker.Models;

namespace expense_tracker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // default Home Page
    public IActionResult Index()
    {
        return View();  // references Views > Home > Index.cshtml view
    }

    public IActionResult Expenses()
    {
        return View();   // references Views > Home > Expenses.cshtml
    }

    // default Privacy Policy Page
    public IActionResult Privacy()
    {
        return View();  // references Views > Home > Privacy.cshtml view
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
