using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Software_2.Models;
using Software_2.Data;

namespace Software_2.Controllers
{
    public class ClienteController : Controller
    {

       private readonly ILogger<ClienteController> _logger;
       private readonly InventarioContext _context;


        public ClienteController(ILogger<ClienteController> logger,
            InventarioContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Listar(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.CurrentSort = sortOrder;
                var clientes = from c in _context.Cliente
                    select c;
                if (!String.IsNullOrEmpty(searchString))
                {
                    clientes = clientes.Where(c => c.Nombre.Contains(searchString)
                                || c.Celular.Contains(searchString)  || c.Direccion.Contains(searchString) || c.Cantidad.ToString().Contains(searchString));
                }

                if (searchString != null)
                {
                    pageNumber  = 1;
                }
                else
                {
                    searchString = currentFilter;
                }

                ViewBag.CurrentFilter = searchString;
                   

                int pageSize = 10;
                    return View(await PaginatedList<Cliente>.CreateAsync(clientes.AsNoTracking(), pageNumber ?? 1, pageSize));

       
        }
                
        // GET: Contacto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Celular,Direccion,Cantidad")] Cliente cliente)
        {
            if (id != cliente.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                
                TempData["prueba02"] = "prueba02";

                return RedirectToAction(nameof(Listar));

            }
            return View(cliente);
        }
        

        public IActionResult Delete(int? id)
        {
            var Cliente = _context.Cliente.Find(id);
            _context.Cliente.Remove(Cliente);
            _context.SaveChanges();
            return RedirectToAction(nameof(Listar));
        }

        public IActionResult Enviar(Cliente objFormulario)
        {
              if (ModelState.IsValid)
                {
                _context.Add(objFormulario);
                _context.SaveChanges();
                TempData["prueba"] = "prueba01";
                objFormulario.Respuesta = "Gracias. Formulario enviado";
                return RedirectToAction("Listar");  
                }
            return View("index", objFormulario);
        }
    }
}
