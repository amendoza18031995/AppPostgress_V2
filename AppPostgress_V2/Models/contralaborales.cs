using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppPostgress_V2.Models
{
    //[Keyless]
    public class contralaborales
    {
        [Key]
        public int idcontrato { get; set; }
        public int idestado { get; set; }
        public int idarl { get; set; }
        public int idcargo { get; set; }
        public int idtipodocumento { get; set; }
        public int numerodocumento { get; set; }
        public string primerapellido { get; set; }
        public string segundoapellido { get; set; }
        public string primernombre { get; set; }
        public string segundonombre { get; set; }
        public DateTime? fechainicio { get; set; }
        public DateTime? fechafin { get; set; }
        public int salario { get; set; }
        public string usuariocreacion { get; set; }
        public DateTime fechacreacion { get; set; }

    }
}
