using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Contact
    {

        [Required]
        public string nombre { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string asunto { get; set; }

        [Required]
        public string mensaje { get; set; }
    }
}