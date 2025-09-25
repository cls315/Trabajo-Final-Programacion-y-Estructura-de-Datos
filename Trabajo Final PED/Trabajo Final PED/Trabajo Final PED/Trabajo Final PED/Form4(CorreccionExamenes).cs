using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Final_PED
{
    public partial class Form4_CorreccionExamenes_ : Form
    {
        private List<Pregunta> preguntas;

        public Form4_CorreccionExamenes_()
        {
            InitializeComponent();
            preguntas = new List<Pregunta>();
        }

        private void btnCargarExamen_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdExamen.Text, out int idExamen))
            {
                MessageBox.Show("Ingrese un ID de examen válido.");
                return;
            }

            preguntas = CargarExamen(idExamen);

            if (preguntas == null || preguntas.Count == 0)
            {
                MessageBox.Show("No se encontró el examen con el ID especificado o no tiene preguntas.");
                return;
            }

            MostrarPreguntas();
        }

        private List<Pregunta> CargarExamen(int idExamen)
        {
            List<Pregunta> preguntas = new List<Pregunta>();

            string rutaExamen = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Trabajo Final PED",
                "Trabajo Final PED",
                "Archivos TXT",
                "Examenes.txt"
            );

            if (!File.Exists(rutaExamen))
            {
                MessageBox.Show("El archivo Examenes.txt no existe.");
                return preguntas;
            }

            string[] lineasExamenes = File.ReadAllLines(rutaExamen);

            bool examenEncontrado = false;

            foreach (string linea in lineasExamenes)
            {
                string[] partes = linea.Split('|');

                if (partes.Length == 6 && int.Parse(partes[0]) == idExamen)
                {
                    examenEncontrado = true;

                    List<int> idsPreguntas = partes[5].Split(',').Select(int.Parse).ToList();

                    preguntas = CargarPreguntasPorIds(idsPreguntas);

                    if (preguntas.Count == 0)
                    {
                        MessageBox.Show("No se encontraron preguntas para el examen.");
                    }

                    break;
                }
            }

            if (!examenEncontrado)
            {
                MessageBox.Show($"No se encontró un examen con el ID {idExamen}.");
            }

            return preguntas;
        }

        private List<Pregunta> CargarPreguntasPorIds(List<int> idsPreguntas)
        {
            List<Pregunta> preguntas = new List<Pregunta>();

            string rutaPreguntas = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Trabajo Final PED",
                "Trabajo Final PED",
                "Archivos TXT",
                "Preguntas.txt"
            );

            if (!File.Exists(rutaPreguntas))
            {
                MessageBox.Show("El archivo Preguntas.txt no existe.");
                return preguntas;
            }

            string[] lineasPreguntas = File.ReadAllLines(rutaPreguntas);

            foreach (string linea in lineasPreguntas)
            {
                string[] partes = linea.Split('|');

                if (partes.Length == 10 && idsPreguntas.Contains(int.Parse(partes[0])))
                {
                    Pregunta pregunta = new Pregunta
                    {
                        PreguntaId = int.Parse(partes[0]),
                        TituloPregunta = partes[1],
                        ListaRespuestas = new List<string> { partes[2], partes[3], partes[4], partes[5] },
                        RespustaCorrecta = partes[6],
                        Asignatura = partes[7],
                        Unidad = partes[8],
                        Subunidad = partes[9]
                    };

                    preguntas.Add(pregunta);
                }
            }

            if (preguntas.Count != idsPreguntas.Count)
            {
                MessageBox.Show("Algunas preguntas no se encontraron en el archivo Preguntas.txt.");
            }

            return preguntas;
        }

        private void MostrarPreguntas()
        {
            lsbPreguntas.Items.Clear();

            foreach (var pregunta in preguntas)
            {
                lsbPreguntas.Items.Add(pregunta.TituloPregunta);
            }
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el apellido y nombre del alumno.");
                return;
            }

            if (preguntas == null || preguntas.Count == 0)
            {
                MessageBox.Show("No hay preguntas cargadas para corregir.");
                return;
            }

            List<int> respuestasUsuario = new List<int>();
            for (int i = 0; i < preguntas.Count; i++)
            {
                string respuesta = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Ingrese la respuesta para la pregunta {i + 1} (1, 2, 3):",
                    "Respuesta del Usuario");

                if (int.TryParse(respuesta, out int respuestaInt) && respuestaInt >= 1 && respuestaInt <= 4)
                {
                    respuestasUsuario.Add(respuestaInt - 1);
                }
                else
                {
                    MessageBox.Show("Respuesta inválida. Ingrese un número entre 1 y 3.");
                    return;
                }
            }

            Correccion correccion = new Correccion
            {
                ExamenId = int.Parse(txtIdExamen.Text),
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                PUntuacion = 0
            };

            StringBuilder feedback = new StringBuilder();

            for (int i = 0; i < preguntas.Count; i++)
            {
                if (preguntas[i] == null)
                {
                    MessageBox.Show($"Error: La pregunta {i + 1} no está cargada correctamente.");
                    return;
                }

                string respuestaUsuarioTexto = preguntas[i].ListaRespuestas[respuestasUsuario[i]];
                bool esCorrecta = respuestaUsuarioTexto.Trim().Equals(preguntas[i].RespustaCorrecta.Trim(), StringComparison.OrdinalIgnoreCase);
                correccion.RespuestasCorrectas.Add(esCorrecta);

                if (esCorrecta)
                {
                    correccion.PUntuacion++;
                    feedback.AppendLine($"Pregunta {i + 1}: Correcta");
                }
                else
                {
                    feedback.AppendLine($"Pregunta {i + 1}: Incorrecta (Respuesta correcta: {preguntas[i].RespustaCorrecta})");
                }
            }

            rtbFeedBack.Text = feedback.ToString();

            GuardarCorreccion(correccion);
        }

        private void GuardarCorreccion(Correccion correccion)
        {
            string rutaCarpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Trabajo Final PED",
                "Trabajo Final PED",
                "Archivos TXT"
            );

            Directory.CreateDirectory(rutaCarpeta);

            string rutaCorrecciones = Path.Combine(rutaCarpeta, "Correcciones.txt");

            int nuevoId = 1;

            if (File.Exists(rutaCorrecciones))
            {
                string[] lineas = File.ReadAllLines(rutaCorrecciones);
                if (lineas.Length > 0)
                {
                    string ultimaLinea = lineas.Last();
                    string[] partes = ultimaLinea.Split('|');

                    if (partes.Length > 0 && int.TryParse(partes[0], out int ultimoId))
                    {
                        nuevoId = ultimoId + 1;
                    }
                }
            }

            string linea = $"{correccion.ExamenId}|{correccion.Apellido}|{correccion.Nombre}|{correccion.PUntuacion}|{string.Join(",", correccion.RespuestasCorrectas)}";
            File.AppendAllText(rutaCorrecciones, linea + Environment.NewLine);

            MessageBox.Show("Corrección guardada correctamente.");
        }
    }
}
