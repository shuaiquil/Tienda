using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class SubCategoria
    {
        public int IdSubCategoria { get; set; }

        public int IdCategoria { get; set; }

        public string Nombre { get; set; }

    }
}