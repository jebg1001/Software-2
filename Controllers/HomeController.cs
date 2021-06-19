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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InventarioContext _context;

        public HomeController(ILogger<HomeController> logger,
            InventarioContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Productos()
        {
            return View();
        }

         public IActionResult Login()
        {
            return View();
        }
        public IActionResult Listar()
        {
            var listUsu=_context.Registrar.ToList();
            return View(listUsu);
        }

         public async Task<IActionResult> ListarH(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.CurrentSort = sortOrder;
                var registrarH = from s in _context.RegistrarH
                    select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    registrarH = registrarH.Where(s => s.Nombre.Contains(searchString)
                                || s.Codigo.Contains(searchString)  || s.Color.Contains(searchString)
                                || s.Talla40.ToString().Contains(searchString) || s.Talla41.ToString().Contains(searchString) || s.Talla42.ToString().Contains(searchString)
                                || s.Talla43.ToString().Contains(searchString) );
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
                    return View(await PaginatedList<ProductoH>.CreateAsync(registrarH.AsNoTracking(), pageNumber ?? 1, pageSize));

       
        }

         public async Task<IActionResult> ListarM(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.CurrentSort = sortOrder;
                var registrarM = from s in _context.RegistrarM
                    select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    registrarM = registrarM.Where(s => s.Nombre.Contains(searchString)
                                || s.Codigo.Contains(searchString)  || s.Color.Contains(searchString) || s.Talla36.ToString().Contains(searchString)
                                || s.Talla37.ToString().Contains(searchString) || s.Talla38.ToString().Contains(searchString) || s.Talla39.ToString().Contains(searchString));
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
                    return View(await PaginatedList<ProductoM>.CreateAsync(registrarM.AsNoTracking(), pageNumber ?? 1, pageSize));

       
        }

         public async Task<IActionResult> ListarN(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.CurrentSort = sortOrder;
                var registrarN = from s in _context.RegistrarN
                    select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    registrarN = registrarN.Where(s => s.Nombre.Contains(searchString)
                                || s.Codigo.Contains(searchString)  || s.Color.Contains(searchString) || s.Sexo.Contains(searchString)
                                || s.Talla25.ToString().Contains(searchString) || s.Talla26.ToString().Contains(searchString) || s.Talla27.ToString().Contains(searchString)
                                || s.Talla28.ToString().Contains(searchString)  || s.Talla29.ToString().Contains(searchString)  || s.Talla30.ToString().Contains(searchString) );
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
                    return View(await PaginatedList<ProductoN>.CreateAsync(registrarN.AsNoTracking(), pageNumber ?? 1, pageSize));

       
        }
         public IActionResult Delete(int? id)
        {
            var usuario = _context.Registrar.Find(id);
            _context.Registrar.Remove(usuario);
            _context.SaveChanges();
            return RedirectToAction(nameof(Listar));
        }

        
    
    }
}
