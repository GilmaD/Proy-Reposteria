using Reposteria.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reposteria.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriaBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriaBL();
       
        }
        // GET: Categorias
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBL.ObtenerCategorias();
           
            return View(listadeCategorias);
        }

        public ActionResult Crear()
        {
            var nuevoCategoria = new Categoria();

            return View(nuevoCategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria producto)
        {
            _categoriasBL.GuardarCategoria(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);
        }
        [HttpPost]
        public ActionResult Editar(Categoria producto)
        {
            _categoriasBL.GuardarCategoria(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);

            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);

            return View(producto);
        }
        [HttpPost]
        public ActionResult Eliminar(Categoria producto)
        {
            _categoriasBL.EliminarCategoria(producto.Id);

            return RedirectToAction("Index");
        }
    }
}