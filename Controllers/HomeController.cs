using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using abkl_plt_procon.Models;
using Microsoft.Extensions.Options;

namespace abkl_plt_procon.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly SSRS _SSRS;

    public HomeController(ILogger<HomeController> logger, IOptions<SSRS> SSRS)
    {
        _logger = logger;
        _SSRS = SSRS.Value;
    }

    public IActionResult Index()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ObProduction()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult CoalProduction()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult PaUa()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult Productivity()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult ProblemProd()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult Breakdown()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult Losttime()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult RainSlippery()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }

    public IActionResult HmAkhirUnit()
    {
        ViewBag.ReportUrl = _SSRS.ReportUrl;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
