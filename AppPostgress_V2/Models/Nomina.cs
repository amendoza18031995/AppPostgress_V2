using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppPostgress_V2.Models
{
    public class Nomina
    {
        [Key]
        public int idnovedadnomina { get; set; }
        public int idcontrato { get; set; }
        public int periodolaborado { get; set; }
        public int horaslaboradas { get; set; }
        public int? horaextradiurna { get; set; }
        public int? horaextradominical { get; set; }
        public int horaextrafestiva { get; set; }
        public int descuentos { get; set; }
        public string usuariocreacion { get; set; }
        public DateTime fechacreacion { get; set; }


    }
}
