using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FULBO9.Models
{
    public class Campeonato
    {
        public int IdCampeonato { get; set; }
        public string? NombreCampeonato { get; set; }
        public decimal CostoInscripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? TipoPago { get; set; }
        public int TiempoPartido { get; set; }
        public string? NombreCancha { get; set; }
        public string? EstadoCampeonato { get; set; }
        public int NumeroGrupos { get; set; }

    }
}
