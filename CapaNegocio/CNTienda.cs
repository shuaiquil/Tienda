using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapaDatos.Metodos;
namespace CapaNegocio
{
    public class CNTienda
    {
        public static List<CNProducto> ObtenerProductos()
        {
            try
            {
                var capa_datos = EF.ObtenerProductos();
                return capa_datos.Select(x => new CNProducto
                {
                    IdProducto = x.IdProducto,
                    Nombre = x.Nombre,
                    Precio = x.Precio,
                    UrlImagen = x.UrlImagen,
                    EsOferta = x.EsOferta,
                    EsDestacado = x.EsDestacado
                }).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<CNCategoria> ObtenerCategorias()
        {
            try
            {
                var capa_datos = EF.ObtenerCategorias();
                return capa_datos.Select(x => new CNCategoria
                {
                    IdCategoria = x.IdCategoria,
                    Nombre = x.Nombre,
                    SubCategoria = x.SubCategoria
                }).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<CNSubCategoria> ObtenerSubcategorias()
        {
            try
            {
                var capa_datos = EF.ObtenerSubCategorias();
                return capa_datos.Select(x => new CNSubCategoria
                {
                    IdSubCategoria = x.IdSubCategoria,
                    IdCategoria = x.IdCategoria,
                    Nombre = x.Nombre
                }).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool RealizarConsulta(string Nombre, string Correo, string Asunto, string Mensaje)
        {
            try
            {
                if(ValidarNombre(Nombre) && ValidarCorreo(Correo) && ValidarAsunto(Asunto) && ValidarMensaje(Mensaje)) { 

                    var capa_datos = EF.RealizarConsulta(Nombre, Correo, Asunto, Mensaje);

                    if (capa_datos)
                    {
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception) 
            {
                return false;
            }
        }

        public static bool ValidarNombre(string Nombre) {
            Regex rgx = new Regex("[0-9]");

            if (Nombre == "" || Nombre == null) {
                return false;
            }
            else if (Nombre.Length > 0 && Nombre.Length < 4)
            {
                return false;
            }
            else if (Nombre.Length > 30)
            {
                return false;
            }
            else if (rgx.IsMatch(Nombre))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidarCorreo(string Correo) {
            string patronEmail = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Correo == "" || Correo == null) {
                return false;
            }
            else if(!Regex.IsMatch(Correo, patronEmail))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidarAsunto(string Asunto) {
            if (Asunto == "" || Asunto == null)
            {
                return false;
            }
            else if (Asunto.Length > 20) {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidarMensaje(string Mensaje)
        {
            if (Mensaje == "" || Mensaje == null)
            {
                return false;
            }
            else if (Mensaje.Length < 10)
            {
                return false;
            }
            else if (Mensaje.Length > 100)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
