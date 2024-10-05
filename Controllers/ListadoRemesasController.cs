using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PARCIAL.Data;
using PARCIAL.Models;
using PARCIAL.ViewModel;

namespace PARCIAL.Controllers
{
    public class ListadoRemesasController : Controller
    {
        private readonly ILogger<ListadoRemesasController> _logger;
        private readonly ApplicationDbContext _context;

        public ListadoRemesasController(ILogger<ListadoRemesasController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var remisiones = _context.DataRemesa.ToList();

            var viewModel = new RemesaViewModel
            {
                ListRemesa = remisiones
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}