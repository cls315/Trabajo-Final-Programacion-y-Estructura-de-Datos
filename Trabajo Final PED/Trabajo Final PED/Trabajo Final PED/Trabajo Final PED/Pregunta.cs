using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_PED
{
    public class Pregunta
    {
        public int PreguntaId { get; set; }
        public string TituloPregunta {  get; set; }
        public List<string> ListaRespuestas { get; set; }
        public string RespustaCorrecta { get; set; }
        public string Asignatura {  get; set; }
        public string Unidad {  get; set; }
        public string Subunidad { get; set; }

        public Pregunta Siguiente { get; set; }

        public override string ToString()
        {
            return $"{PreguntaId} - {TituloPregunta} - {ListaRespuestas} - {RespustaCorrecta} - {Asignatura} - {Unidad} - {Subunidad}";
        }
    }
}
