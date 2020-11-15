using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProducto

    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }

        public float Precio { get; set; }

        public string UrlImagen { get; set; }

        public Boolean EsOferta { get; set; }

        public Boolean EsDestacado { get; set; }

    }
}
