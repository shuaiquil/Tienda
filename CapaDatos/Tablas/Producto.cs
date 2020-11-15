using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Tablas
{
    [Table("Productos")]
    public class Producto
    {
        public Producto() { }

        [Key]
        [Column("Id_Producto", Order = 1)]
        public int IdProducto { get; set; }

        [Required, MaxLength(50)]
        [Column("Nombre", Order = 2)]
        public string Nombre { get; set; }

        [Required]
        [Column("Precio", Order = 3)]
        public float Precio { get; set; }

        [Required, MaxLength(100)]
        [Column("Url_Imagen", Order = 4)]
        public string UrlImagen { get; set; }

        [Required]
        [Column("EsOferta", Order = 5)]
        public Boolean EsOferta { get; set; }

        [Required]
        [Column("EsDestacado", Order = 6)]
        public Boolean EsDestacado { get; set; }

    }
}
