using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Tablas
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria() { }

        [Key]
        [Column("Id_Categoria", Order = 1)]
        public int IdCategoria { get; set; }

        [Required, MaxLength(50)]
        [Column("Nombre", Order = 2)]
        public string Nombre { get; set; }

        [Required]
        [Column("Tiene_SubCategoria", Order = 3)]
        public Boolean SubCategoria { get; set; }
    }
}
