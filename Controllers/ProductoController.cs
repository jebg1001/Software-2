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
    public class ProductoController : Controller
    {

       private readonly ILogger<ProductoController> _logger;
       private readonly InventarioContext _context;


        public ProductoController(ILogger<ProductoController> logger,
            InventarioContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult RegistrarSalidaCalzado()
        {
            return View();
        }

        public IActionResult Estado()
        {
           var listProductos=_context.RegistroS.ToList();
            return View(listProductos);
        }

        public IActionResult Salidas()
        {
            var listProductos=_context.RegistroS.ToList();
            return View(listProductos);
        }

        public async Task<IActionResult> MostrarCaracteristica(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrarH = await _context.RegistrarH.FindAsync(id);
            if (registrarH == null)
            {
                return NotFound();
            }
            return View(registrarH);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MostrarCaracteristica(int id, [Bind("ID,Nombre,Codigo,Color,Tipo,Descripcion,Talla40,Talla41,Talla42,Talla43")] ProductoH registrarH)
        {
            if (id != registrarH.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                TempData["prueba02"] = "prueba02";
                return RedirectToAction(nameof(ListarH));
            }
            return View(registrarH); 

        }


        public IActionResult InventarioH()
        {
            var listProductos=_context.RegistrarH.ToList();
            return View(listProductos);
        }

        public IActionResult InventarioM()
        {
            var listProductos=_context.RegistrarM.ToList();
            return View(listProductos);
        }

        public IActionResult InventarioN()
        {
            var listProductos=_context.RegistrarN.ToList();
            return View(listProductos);
        }
        
        public IActionResult Registrar(RegistroS objFormulario)
        {
              if (ModelState.IsValid)
                {
                _context.Add(objFormulario);
                _context.SaveChanges();
                TempData["prueba"] = "prueba01";
                objFormulario.Respuesta = "Gracias. Formulario enviado";
                return RedirectToAction("Salidas");  
                }
            return View("RegistrarSalidaCalzado", objFormulario);
        }

        public async Task<IActionResult> ListarH(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.CurrentSort = sortOrder;
                var registrarH = from s in _context.RegistrarH
                    select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    registrarH = registrarH.Where(s => s.Nombre.Contains(searchString)
                                || s.Codigo.Contains(searchString)  || s.Color.Contains(searchString) || s.Tipo.Contains(searchString) || s.Descripcion.Contains(searchString)
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
                                || s.Codigo.Contains(searchString)  || s.Color.Contains(searchString) || s.Tipo.Contains(searchString) || s.Descripcion.Contains(searchString)
                                || s.Talla35.ToString().Contains(searchString) || s.Talla36.ToString().Contains(searchString)
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
                                || s.Tipo.Contains(searchString) || s.Descripcion.Contains(searchString)
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

        public IActionResult DeleteH(int? id)
        {
            var registrarH = _context.RegistrarH.Find(id);
            _context.RegistrarH.Remove(registrarH);
            _context.SaveChanges();
            return RedirectToAction(nameof(ListarH));
        }

        public IActionResult DeleteM(int? id)
        {
            var registrarM = _context.RegistrarM.Find(id);
            _context.RegistrarM.Remove(registrarM);
            _context.SaveChanges();
            return RedirectToAction(nameof(ListarM));
        }

        public IActionResult DeleteN(int? id)
        {
            var registrarN = _context.RegistrarN.Find(id);
            _context.RegistrarN.Remove(registrarN);
            _context.SaveChanges();
            return RedirectToAction(nameof(ListarN));
        }


          public async Task<IActionResult> AsignarCaracteristica(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrarH = await _context.RegistrarH.FindAsync(id);
            if (registrarH == null)
            {
                return NotFound();
            }
            return View(registrarH);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AsignarCaracteristica(int id, [Bind("ID,Nombre,Codigo,Color,Tipo,Descripcion,Talla40,Talla41,Talla42,Talla43")] ProductoH registrarH)
        {
            if (id != registrarH.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrarH);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                TempData["prueba02"] = "prueba02";
                return RedirectToAction(nameof(ListarH));
            }
            return View(registrarH);
        }

        public async Task<IActionResult> EditM(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrarM = await _context.RegistrarM.FindAsync(id);
            if (registrarM == null)
            {
                return NotFound();
            }
            return View(registrarM);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditM(int id, [Bind("ID,Nombre,Codigo,Color,talla36,talla37,talla38,talla39")] ProductoM registrarM)
        {
            if (id != registrarM.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrarM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                TempData["prueba02"] = "prueba02";
                return RedirectToAction(nameof(ListarM));
            }
            return View(registrarM);
        }
        
        
        public IActionResult RegistroH()
        {
            return View();
        }

        public IActionResult RegistroM()
        {
            return View();
        }

        public IActionResult RegistroN()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarH(ProductoH objRegistrar){
            if(ModelState.IsValid){
                _context.Add(objRegistrar);
                _context.SaveChanges();   
                                TempData["registro"] = "regisH";
         
                objRegistrar.Respuesta="Se registro correctamente";
                                return RedirectToAction("ListarH");  

            }
            return View("RegistroH",objRegistrar);
        }

        [HttpPost]
        public IActionResult RegistrarM(ProductoM objRegistrar){
            if(ModelState.IsValid){
                _context.Add(objRegistrar);
                _context.SaveChanges();   
                                TempData["registro"] = "regisM";
         
                objRegistrar.Respuesta="Se registro correctamente";
                                return RedirectToAction("ListarM");  

            }
            return View("RegistroM",objRegistrar);
        }

        [HttpPost]
        public IActionResult RegistrarN(ProductoN objRegistrar){
            if(ModelState.IsValid){
                _context.Add(objRegistrar);
                _context.SaveChanges();   
                                TempData["registro"] = "regisN";
         
                objRegistrar.Respuesta="Se registro correctamente";
                                return RedirectToAction("ListarN");  

            }
            return View("RegistroN",objRegistrar);
        }

        public async Task<IActionResult> Listar(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.CurrentSort = sortOrder;
                var productos = from s in _context.Productos
                    select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    productos = productos.Where(s => s.product.Contains(searchString)
                                || s.color.Contains(searchString)  || s.tallas.Contains(searchString) || s.modelo.Contains(searchString)
                                || s.sexo.Contains(searchString) || s.cantidad.ToString().Contains(searchString));
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
                    return View(await PaginatedList<Producto>.CreateAsync(productos.AsNoTracking(), pageNumber ?? 1, pageSize));

       
        }
                
        // GET: Contacto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,product,color,tallas,sexo,cantidad,modelo")] Producto producto)
        {
            if (id != producto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                
                TempData["prueba02"] = "prueba02";

                return RedirectToAction(nameof(Listar));

            }
            return View(producto);
        }
        

        public IActionResult Delete(int? id)
        {
            var producto = _context.Productos.Find(id);
            _context.Productos.Remove(producto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Listar));
        }

        public IActionResult Enviar(Producto objFormulario)
        {
              if (ModelState.IsValid)
                {
                _context.Add(objFormulario);
                _context.SaveChanges();
                TempData["prueba"] = "prueba01";
                objFormulario.Response = "Gracias. Formulario enviado";
                return RedirectToAction("Listar");  
                }
            return View("index", objFormulario);
        }

        public async Task<IActionResult> EntradaProducto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoH = await _context.RegistrarH.FindAsync(id);
            if (productoH == null)
            {
                return NotFound();
            }
            return View(productoH);
        }

        public async Task<IActionResult> SalidaProducto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoH = await _context.RegistrarH.FindAsync(id);
            if (productoH == null)
            {
                return NotFound();
            }
            return View(productoH);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EntradaProducto(int id, [Bind("ID,Nombre,Codigo,Color,Tipo,Descripcion,Talla40,Talla41,Talla42,Talla43")] ProductoH productoH)
        {
            if (id != productoH.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var listarRegistrarH = _context.RegistrarH.Where(x => x.ID == id).Select(y => y.Talla40).ToList();
                    int listarP = int.Parse(listarRegistrarH.First().ToString());

                    
                    productoH.Talla40 = productoH.Talla40 + listarP;
                    _context.RegistrarH.Attach(productoH);
                    _context.Entry(productoH).Property(x => x.Talla40).IsModified = true;
                    await _context.SaveChangesAsync();  
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                
                return RedirectToAction(nameof(ListarH));

            }
            return View(productoH);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SalidaProducto(int id, [Bind("ID,Nombre,Codigo,Color,Tipo,Descripcion,Talla40,Talla41,Talla42,Talla43")] ProductoH productoH)
        {
            if (id != productoH.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var listarRegistrarH = _context.RegistrarH.Where(x => x.ID == id).Select(y => y.Talla40).ToList();
                    int listarP = int.Parse(listarRegistrarH.First().ToString());

                    
                    productoH.Talla40 = listarP - productoH.Talla40;
                    _context.RegistrarH.Attach(productoH);
                    _context.Entry(productoH).Property(x => x.Talla40).IsModified = true;
                    await _context.SaveChangesAsync();  
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                
                return RedirectToAction(nameof(ListarH));

            }
            return View(productoH);
        }

        public async Task<IActionResult> EntradaSalida(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.RegistroS.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EntradaSalida(int id, [Bind("ID,Nombre,Codigo,Color,Sexo,Cantidad")] RegistroS producto)
        {
            if (id != producto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var listarRegistrar = _context.RegistroS.Where(x => x.ID == id).Select(y => y.Cantidad).ToList();
                    int listarP = int.Parse(listarRegistrar.First().ToString());

                    
                    producto.Cantidad = producto.Cantidad + listarP;
                    _context.RegistroS.Attach(producto);
                    _context.Entry(producto).Property(x => x.Cantidad).IsModified = true;
                    await _context.SaveChangesAsync();  
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                
                return RedirectToAction(nameof(Salidas));

            }
            return View(producto);
        }

    }
}