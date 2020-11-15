using CapaDatos.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Metodos
{
    public class EF
    {

        public static List<Producto> ObtenerProductos()
        {
            try
            {
                using (var context = new Tienda())
                {
                    return context.Productos.ToList();
                }

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<Categoria> ObtenerCategorias()
        {
            try
            {
                using (var context = new Tienda()) 
                {
                    return context.Categorias.ToList();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<SubCategoria> ObtenerSubCategorias()
        {
            try
            {
                using (var context = new Tienda())
                {
                    return context.SubCategorias.ToList();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool RealizarConsulta(string Nombre, string Correo, string Asunto, string Mensaje)
        {
            try
            {
                using (var context = new Tienda())
                {
                    var nuevo = new Consulta
                    {
                        Nombre = Nombre,
                        Correo = Correo,
                        Asunto = Asunto,
                        Mensaje =  Mensaje
                    };

                    context.Consultas.Add(nuevo);

                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 
    }
}
