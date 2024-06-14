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

        

        Paquete paq1 = new Paquete(ORTWorld.ListaHoteles[Hotel - 1], ORTWorld.ListaAereos[Aereo - 1], ORTWorld.ListaExcursiones[Excursion - 1]);


        if (ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino - 1], paq1))
        {
            return RedirectToAction("Index");
        }
        else{
            return RedirectToAction("SelectPaquete");
        }


    }





}
