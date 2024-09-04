using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace PT_SIxDegrees.Api.DataAccess.Data
{
    public class Usuario
    {
        [Key]
        public decimal usuID { get; set; }
        public string nombre { get; set;}
        public string apellido { get; set; }
    }
}
