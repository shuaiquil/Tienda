using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            var productos = CNTienda.ObtenerProductos();
            var categorias = CNTienda.ObtenerCategorias();
            var subCategorias = CNTienda.ObtenerSubcategorias();

            var modelo = new ViewModel();

            modelo.Productos = productos.Select(x => new Producto
            {
                IdProducto = x.IdProducto,
                Nombre = x.Nombre,
                Precio = x.Precio,
                UrlImagen = x.UrlImagen,
                EsOferta = x.EsOferta,
                EsDestacado = x.EsDestacado
            }).ToList();

            modelo.Categorias = categorias.Select(x => new Categoria
            {
                IdCategoria = x.IdCategoria,
                Nombre = x.Nombre,
                SubCategoria = x.SubCategoria
            }).ToList();

            modelo.SubCategorias = subCategorias.Select( x => new SubCategoria 
            {
                IdSubCategoria = x.IdSubCategoria,
                IdCategoria = x.IdCategoria,
                Nombre = x.Nombre
            }).ToList();
            
            return View(modelo);
        }
    }
}