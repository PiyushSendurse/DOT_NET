using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflStore.Models;

namespace tflStore.Controllers;

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
    public IActionResult Welcome()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult validate(string emailName, string passName)
    {
        if(emailName=="saifu@gmail.com" && passName=="salma") {
            return Redirect("/home/AccntLogin");
        }
       return View();
    }
    public IActionResult AccntLogin()
    {
        return View();
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
