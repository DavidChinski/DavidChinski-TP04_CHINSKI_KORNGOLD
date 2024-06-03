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
        ViewBag.Paquetes = ORTWorld.Paquetes;

        return View();
    }

    public IActionResult SelectPaquete(List<string> ListaDestinos)
    {
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;

        return View();

    }

    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {

        if (!(Destino == 0 || Hotel == 0 || Aereo == 0 || Excursion == 0))
        {
            ViewBag.ListaAereos = ORTWorld.ListaAereos;
            ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
            ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
            ViewBag.ListaDestinos = ORTWorld.ListaDestinos;

            Paquete paq1 = new Paquete(ORTWorld.ListaHoteles[Hotel], ORTWorld.ListaAereos[Aereo], ORTWorld.ListaExcursiones[Excursion]);


            return View();
        }


    }





}
