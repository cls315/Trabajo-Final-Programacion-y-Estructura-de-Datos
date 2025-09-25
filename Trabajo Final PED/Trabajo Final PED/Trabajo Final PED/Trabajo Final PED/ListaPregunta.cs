using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_PED
{
    public class ListaPregunta
    {
        public Pregunta Inicio { get; set; }

        public void AgregarPregunta(int idPregunta, string tituloPregunta, string[] listaRespuestas, string resputestaCorrecta, string asignatura, string unidad, string subunidad)
        {
            Pregunta pregunta = new Pregunta
            {
                PreguntaId = idPregunta,
                TituloPregunta = tituloPregunta,
                ListaRespuestas = listaRespuestas.ToList(),
                RespustaCorrecta = resputestaCorrecta,
                Asignatura = asignatura,
                Unidad = unidad,
                Subunidad = subunidad
            };

            if (Inicio == null)
            {
                Inicio = pregunta;
            }
            else
            {
                Pregunta ultimoNodo = BuscarUltimo(Inicio);
                ultimoNodo.Siguiente = pregunta;
            }
        }

        Pregunta BuscarUltimo(Pregunta nodo)
        {
            if (nodo == null) return null;

            if (nodo.Siguiente != null)
                return BuscarUltimo(nodo.Siguiente);
            else
                return nodo;
        }

        public void ModificarPregunta(int idPregunta, string nuevoTituloPregunta, string[] nuevaListaRespuestas, string nuevaResputestaCorrecta, string nuevaAsignatura, string nuevaUnidad, string nuevaSubunidad)
        {
            Pregunta preguntaEncontrada = BuscarPregunta(idPregunta, Inicio);

            if (preguntaEncontrada != null)
            {
                preguntaEncontrada.TituloPregunta = nuevoTituloPregunta;
                preguntaEncontrada.ListaRespuestas = nuevaListaRespuestas.ToList();
                preguntaEncontrada.RespustaCorrecta = nuevaResputestaCorrecta;
                preguntaEncontrada.Asignatura = nuevaAsignatura;
                preguntaEncontrada.Unidad = nuevaUnidad;
                preguntaEncontrada.Subunidad = nuevaSubunidad;
            }
        }

        Pregunta BuscarPregunta(int idPregunta, Pregunta nodo)
        {
            if (nodo.PreguntaId == idPregunta)
            {
                return nodo;
            }
            else
            {
                if (nodo.Siguiente != null)
                {
                    return BuscarPregunta(idPregunta, nodo.Siguiente);
                }
                else
                {
                    return null;
                }
            }
        }

        public void EliminarPregunta(int idPregunta)
        {
            if (Inicio != null)
            {
                QuitarPrimero();
            }
            else
            {
                Pregunta ultima = BuscarUltimo(Inicio);

                if (ultima != null && ultima.PreguntaId == idPregunta)
                    QuitarUltimo();
                else
                {
                    Pregunta nodoAnteriorAlElegido = BuscarAnterior(idPregunta, Inicio);

                    if (nodoAnteriorAlElegido != null && nodoAnteriorAlElegido.Siguiente != null)
                    {
                        nodoAnteriorAlElegido.Siguiente = nodoAnteriorAlElegido.Siguiente.Siguiente;
                    }
                }
            }
        }

        public void QuitarPrimero()
        {
            if (Inicio != null)
            {
                Inicio = Inicio.Siguiente;
            }
        }

        public void QuitarUltimo()
        {
            Pregunta anteultimo = BuscarAnteultimo(Inicio);

            if (anteultimo != null)
            {
                anteultimo.Siguiente = null;
            }
            else
            {
                Inicio = null;
            }
        }

        private Pregunta BuscarAnteultimo(Pregunta nodo)
        {
            if (nodo == null) return null;

            if (nodo.Siguiente == null) return null;

            if (nodo.Siguiente.Siguiente != null)
                return BuscarAnteultimo(nodo.Siguiente);
            else
                return nodo;
        }

        private Pregunta BuscarAnterior(int idPregunta, Pregunta nodo)
        {
            if (nodo.Siguiente != null && nodo.Siguiente.PreguntaId == idPregunta)
            {
                return nodo;
            }

            if (nodo.Siguiente != null)
            {
                return BuscarAnterior(idPregunta, nodo.Siguiente);
            }

            return null;
        }

        public List<Pregunta> ObtenerPreguntas()
        {
            List<Pregunta> lista = new List<Pregunta>();
            Pregunta actual = Inicio;

            while (actual != null)
            {
                lista.Add(actual);
                actual = actual.Siguiente;
            }

            return lista;
        }

        public List<Pregunta> ObtenerPreguntasOrdenadasPorUnidad()
        {
            return ObtenerPreguntas().OrderBy(p => p.Unidad).ToList();
        }

        public int CantidadPreguntas()
        {
            int contador = 0;
            Pregunta actual = Inicio;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        public List<Pregunta> ObtenerPreguntasComoLista()
        {
            List<Pregunta> lista = new List<Pregunta>();
            Pregunta actual = Inicio;
            while (actual != null)
            {
                lista.Add(actual);
                actual = actual.Siguiente;
            }
            return lista;
        }

        // Datos Hardcodeados
        public void CargarPreguntasDePrueba()
        {
            // Matemáticas
            AgregarPregunta(1, "¿Cuánto es 15 + 23?", new string[] { "38", "35", "42", "28" }, "38", "Matemáticas", "1", "Operaciones básicas");
            AgregarPregunta(2, "¿Cuál es el resultado de 3/4 + 1/2?", new string[] { "5/4", "4/6", "1", "2/3" }, "5/4", "Matemáticas", "1", "Fracciones");
            AgregarPregunta(3, "Resuelve para x: 2x + 5 = 15", new string[] { "x = 5", "x = 10", "x = 7.5", "x = -5" }, "x = 5", "Matemáticas", "2", "Ecuaciones lineales");
            AgregarPregunta(4, "Factoriza: x² - 9", new string[] { "(x+3)(x-3)", "(x-3)²", "(x+9)(x-1)", "No se puede factorizar" }, "(x+3)(x-3)", "Matemáticas", "2", "Factorización");

            // Historia
            AgregarPregunta(5, "¿Qué civilización se desarrolló entre los ríos Tigris y Éufrates?", new string[] { "Mesopotamia", "Egipto", "India", "China" }, "Mesopotamia", "Historia", "1", "Civilizaciones fluviales");
            AgregarPregunta(6, "¿Qué filósofo fue maestro de Alejandro Magno?", new string[] { "Aristóteles", "Platón", "Sócrates", "Pitágoras" }, "Aristóteles", "Historia", "1", "Grecia clásica");
            AgregarPregunta(7, "¿Qué grupo social era el más numeroso en el feudalismo?", new string[] { "Siervos", "Nobles", "Reyes", "Clérigos" }, "Siervos", "Historia", "2", "Feudalismo");
            AgregarPregunta(8, "¿Cuántas Cruzadas principales hubo?", new string[] { "8", "5", "3", "12" }, "8", "Historia", "2", "Cruzadas");

            // Ciencias Naturales
            AgregarPregunta(9, "¿Qué orgánulo es conocido como la 'central energética' de la célula?", new string[] { "Mitocondria", "Núcleo", "Ribosoma", "Cloroplasto" }, "Mitocondria", "Ciencias Naturales", "1", "Célula");
            AgregarPregunta(10, "¿Qué científico es considerado el padre de la genética?", new string[] { "Gregor Mendel", "Charles Darwin", "Louis Pasteur", "James Watson" }, "Gregor Mendel", "Ciencias Naturales", "1", "Genética");
            AgregarPregunta(11, "¿Qué ley establece que 'a toda acción le corresponde una reacción igual y opuesta'?", new string[] { "Tercera Ley de Newton", "Primera Ley de Newton", "Ley de Ohm", "Ley de Gravitación" }, "Tercera Ley de Newton", "Ciencias Naturales", "2", "Movimiento");
            AgregarPregunta(12, "¿Qué tipo de energía tiene un objeto debido a su movimiento?", new string[] { "Cinética", "Potencial", "Térmica", "Química" }, "Cinética", "Ciencias Naturales", "2", "Energía");

            // Lengua y Literatura
            AgregarPregunta(13, "¿Qué tiempo verbal expresa una acción futura respecto al momento del habla?", new string[] { "Futuro simple", "Presente", "Pretérito perfecto", "Condicional" }, "Futuro simple", "Lengua y Literatura", "1", "Verbos");
            AgregarPregunta(14, "¿A qué género pertenece 'Don Quijote de la Mancha'?", new string[] { "Novela", "Poesía", "Teatro", "Ensayo" }, "Novela", "Lengua y Literatura", "1", "Géneros literarios");
            AgregarPregunta(15, "¿Quién escribió 'Romeo y Julieta'?", new string[] { "William Shakespeare", "Miguel de Cervantes", "Homero", "Dante Alighieri" }, "William Shakespeare", "Lengua y Literatura", "2", "Autores clásicos");
            AgregarPregunta(16, "¿Qué figura literaria es 'el murmullo de las olas'?", new string[] { "Onomatopeya", "Metáfora", "Hipérbole", "Personificación" }, "Onomatopeya", "Lengua y Literatura", "2", "Figuras literarias");

        }
    }
}
