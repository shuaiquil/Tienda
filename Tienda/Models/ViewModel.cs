using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class ViewModel
    {
        public List<Producto> Productos{ get; set; }

        public List<Categoria> Categorias { get; set; }

        public List<SubCategoria> SubCategorias { get; set; }

    }
}