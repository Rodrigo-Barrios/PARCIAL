using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PARCIAL.Data;
using PARCIAL.Models;
using PARCIAL.ViewModel;

namespace PARCIAL.Controllers
{
    public class RemesaController : Controller
    {
        private readonly ILogger<RemesaController> _logger;
        private readonly ApplicationDbContext _context;

        public RemesaController(ILogger<RemesaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var remesas = from o in _context.DataRemesa select o;
            var viewModel = new RemesaViewModel
            {
                FormRemesa = new Remesa(),
                ListRemesa = remesas.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Registrar(RemesaViewModel viewModel)
        {
            if (viewModel.FormRemesa.Id == 0)
            {
                _context.Add(viewModel.FormRemesa);
                TempData["Message"] = "Remesa registrada";
            }

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}