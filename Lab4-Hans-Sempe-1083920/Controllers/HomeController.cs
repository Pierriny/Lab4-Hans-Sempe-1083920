using Lab4_Hans_Sempe_1083920.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HEAP.TreeStructure;

namespace Lab4_Hans_Sempe_1083920.Controllers
{
    public class HomeController : Controller
    {
        private static HEAPTree<int, Pacientes> ColaDeEspera = new HEAPTree<int, Pacientes>(new Models.Prioridad().Compare, new Models.Prioridad().CalcularPrioridad);

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        // Views

        public IActionResult RecibirUnPaciente() { return View(); }

        public IActionResult GuardarPacienteEnCola (String _n, String _a, DateTime _f, int _s, int _e, int _i)
        {
            Pacientes nuevoPaciente = new Pacientes(_n, _a, _f, _s, _e, _i);
            ColaDeEspera.Insertar(nuevoPaciente);
            return View();
        }



    }
}
