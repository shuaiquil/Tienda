using CapaNegocio;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Index(string Nombre, string Correo, string Asunto, string Mensaje)
         {

            var respuesta = CNTienda.RealizarConsulta(Nombre, Correo, Asunto, Mensaje);

            if (respuesta) {
                ViewBag.Message = "Se envió el formulario Correctamente";
            }
            else
            {
                ViewBag.Message = "Por favor, revise los campos e intente nuevamente";
            }
            return Json(data: new { respuesta = ViewBag.Message} , JsonRequestBehavior.AllowGet);
        }

       
    }
}