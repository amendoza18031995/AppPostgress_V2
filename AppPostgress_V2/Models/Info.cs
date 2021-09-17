using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPostgress_V2.Models
{
    public class Info
    {
        public string tipoDocumento { get; set; }
        public int arl { get; set; }
        public string nombrecargo { get; set; } 
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
