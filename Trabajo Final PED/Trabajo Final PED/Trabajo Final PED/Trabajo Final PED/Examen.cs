using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_PED
{
    internal class Examen
    {
        public int ExamenId { get; set; }
        public DateTime Fecha {  get; set; }
        public string AsignaturaExamen { get; set; }
        public List<Pregunta> PreguntaId { get; set; } = new List<Pregunta>();

        public Examen Siguiente { get; set; }

        public override string ToString()
        {
            return $"{ExamenId} - {Fecha} - {AsignaturaExamen} - {PreguntaId}";
        }
    }
}
