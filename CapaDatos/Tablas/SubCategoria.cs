using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Tablas
{
    [Table ("SubCategorias")]
    public class SubCategoria
    {
        public SubCategoria() { }

        [Key]
        [Column("Id_Subcategoria", Order = 1)]
        public int IdSubCategoria { get; set; }

        [ForeignKey("FK_Id_Categoria")]
        [Column("FK_Id_Categoria", Order = 2)]
        public int IdCategoria { get; set; }

        [Required, MaxLength(50)]
        [Column("Nombre", Order = 3)]
        public string Nombre { get; set; }

        //Relacion 
        public virtual Categoria FK_Id_Categoria { get; set; }
    }
}
