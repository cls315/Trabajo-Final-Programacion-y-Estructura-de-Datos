using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_PED
{
    internal class Correccion
    {
        public int ExamenId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int PUntuacion { get; set; }
        public List<bool> RespuestasCorrectas { get; set; }

        public Correccion()
        {
            RespuestasCorrectas = new List<bool>();
        }
    }
}
