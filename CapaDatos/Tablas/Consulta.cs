using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Tablas
{
    [Table("Consultas")]
    public class Consulta
    {
        public Consulta() { }

        [Key]
        [Column("Id_Consulta", Order = 1)]
        public int IdConsulta { get; set; }

        [Required, MaxLength(50)]
        [Column("Nombre", Order = 2)]
        public string Nombre { get; set; }

        [Required, MaxLength(50)]
        [Column("Correo", Order = 3)]
        public string Correo { get; set; }

        [Required, MaxLength(20)]
        [Column("Asunto", Order = 4)]
        public string Asunto { get; set; }

        [Required, MaxLength(100)]
        [Column("Mensaje", Order = 5)]
        public string Mensaje { get; set; }
    }
}
