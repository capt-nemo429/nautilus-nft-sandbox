using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NautilusNFTSandbox.Models;

namespace NautilusNFTSandbox.Controllers;

public class HomeController : Controller
{
    public IActionResult Index([FromQuery]string url, [FromQuery]string height, [FromQuery]string fit, [FromQuery]string overflow)
    {
        ViewBag.url = url;
        ViewBag.height = height;
        ViewBag.fit = fit;
        ViewBag.overflow = overflow;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
