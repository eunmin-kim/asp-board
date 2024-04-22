using System.Diagnostics;
using AspCoreBoardProject.DataContext;
using Microsoft.AspNetCore.Mvc;
using AspCoreBoardProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AspCoreBoardProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BoardDbContext _boardDbContext;

    public HomeController(ILogger<HomeController> logger, BoardDbContext db)
    {
        _logger = logger;
        this._boardDbContext = db;
    }

    public async Task<IActionResult> Index()
    {
        
        return View(await _boardDbContext.Boards.ToListAsync());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}