using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppPostgress_V2.Models
{
    //[Keyless]
    public class Arl
    {
        [Key]
        public int idarl { get; set; }
        public int valor { get; set; }
        public string usuariocreacion { get; set; }
        public DateTime fechacreacion { get; set; }
        public bool habilitado { get; set; }
        public contralaborales contrato { get;set; }
    }
}
