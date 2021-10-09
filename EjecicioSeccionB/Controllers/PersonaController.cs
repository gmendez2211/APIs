using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EjecicioSeccionB.Connection;
using EjecicioSeccionB.Models;
using Microsoft.EntityFrameworkCore;

namespace EjecicioSeccionB.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;
        private readonly Conn _context;

        public PersonaController(Conn context)
        {
            _context = context;
        }
        
        public IActionResult Personas()
        {
            return View();
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.tbl_personas.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Personas([Bind("CodigoPersona, NombrePersona, ApellidoPersona, Edad, EstadoPersona")] PersonaModel personamodel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personamodel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personamodel);
        }
        
    }
}
