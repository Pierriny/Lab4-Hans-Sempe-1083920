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

        public IActionResult GuardarPacienteEnCola (String nombre, String apellido, DateTime fecha, int sexo, int especialidad, int ingreso)
        {
            Pacientes nuevoPaciente = new Pacientes(nombre, apellido, fecha, sexo, especialidad, ingreso);
            ColaDeEspera.Insertar(nuevoPaciente);
            return View();
        }

        public IActionResult MostrarColaPacientes (int eliminacion)
        {
            if ( eliminacion != 0) { ColaDeEspera.Eliminar(); }
            ViewData["Pacientes"] = ColaDeEspera.treeToList();
            return View();
        }
    }
}
