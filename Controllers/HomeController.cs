using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp_final_bimestre_1.Models;

namespace tp_final_bimestre_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        ViewBag.grupo = grupo.DevolverIntegrantes();
        return View();
    }
    public IActionResult SelectIntegrante(int dni)
    {
        Grupo grupo = new Grupo();
        ViewBag.miIntegrante = grupo.GetIntegrante(dni);
        ViewBag.DNI = dni;
        return infoIntegrante();
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
