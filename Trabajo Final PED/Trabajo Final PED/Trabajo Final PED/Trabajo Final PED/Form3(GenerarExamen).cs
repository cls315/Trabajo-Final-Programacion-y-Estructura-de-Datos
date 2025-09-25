using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Final_PED
{
    public partial class Form3_GenerarExamen_ : Form
    {
        private List<Pregunta> preguntas;
        public Form3_GenerarExamen_()
        {
            InitializeComponent();
            CargarPreguntas();
            CargarAsignaturas();

            cmbAsignatura.SelectedIndexChanged += cmbAsignatura_SelectedIndexChanged;
        }

        private void CargarPreguntas()
        {
            preguntas = DatosCompartidos.ListaGlobalPreguntas.ObtenerPreguntasComoLista();
        }

        private void CargarAsignaturas()
        {
            var asignaturas = preguntas.Select(p => p.Asignatura).Distinct().ToList();

            cmbAsignatura.DataSource = asignaturas;
        }

        private void cmbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarUnidades();
        }

        private void CargarUnidades()
        {
            if (cmbAsignatura.SelectedItem == null)
                return;

            string asignaturaSeleccioanda = cmbAsignatura.SelectedItem.ToString();

            var preguntasAsignatura = preguntas.Where(p => p.Asignatura == asignaturaSeleccioanda).ToList();

            var unidades = preguntasAsignatura.Select(p => p.Unidad).Distinct().OrderBy(u => u).ToList();

            clbUnidades.Items.Clear();

            foreach (var unidad in unidades)
            {
                clbUnidades.Items.Add($"Unidad {unidad}");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(txtFecha.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaExamen))
            {
                MessageBox.Show("Por favor, ingrese una fecha valida en el formato DD/MM/AAAA");
                return;
            }

            if (clbUnidades.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una unidad");
                return;
            }

            string asignaturasSeleccionada = cmbAsignatura.SelectedItem.ToString();
            List<string> unidadesSeleccionadas = new List<string>();

            foreach (var item in clbUnidades.CheckedItems)
            {
                unidadesSeleccionadas.Add(item.ToString().Replace("Unidad ", ""));
            }

            List<Pregunta> examen = GenerarExamenAleatorio(asignaturasSeleccionada, unidadesSeleccionadas);

            MostrarExamen(examen, fechaExamen);

            GuardarExamenEnArchivo(examen, asignaturasSeleccionada, fechaExamen);
        }

        private List<Pregunta> GenerarExamenAleatorio(string asignatura, List<string> unidades)
        {
            var examen = new List<Pregunta>();
            var random = new Random();

            var preguntasFiltradas = preguntas.Where(p => p.Asignatura == asignatura && unidades.Contains(p.Unidad)).ToList();

            var preguntasPorSubunidad = preguntasFiltradas.GroupBy(p => new { p.Unidad, p.Subunidad }).ToList();


            foreach (var grupo in preguntasPorSubunidad)
            {
                var preguntaAleatoria = grupo.OrderBy(x => random.Next()).First();
                examen.Add(preguntaAleatoria);
            }

            return examen;
        }

        private void MostrarExamen(List<Pregunta> examen, DateTime fechaExamen)
        {
            rtbListaExamenes.Clear();

            rtbListaExamenes.AppendText("=== Preguntas Cargadas ===\n");
            rtbListaExamenes.AppendText($"Asignatura: {cmbAsignatura.SelectedItem}\n");
            rtbListaExamenes.AppendText($"Fecha: {fechaExamen.ToShortDateString()}\n\n");

            for (int i = 0; i < examen.Count; i++)
            {
                rtbListaExamenes.AppendText($"Pregunta {i + 1}: {examen[i].TituloPregunta}\n");

                for (int j = 0; j < examen[i].ListaRespuestas.Count; j++)
                {
                    rtbListaExamenes.AppendText($"   {j + 1}. {examen[i].ListaRespuestas[j]}\n");
                }
            }
        }

        private void GuardarExamenEnArchivo(List<Pregunta> examen, string asignatura, DateTime fechaExamen)
        {
            string rutaCarpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Trabajo Final PED",
                "Trabajo Final PED",
                "Archivos TXT"
            );

            Directory.CreateDirectory(rutaCarpeta);

            string rutaExamenes = Path.Combine(rutaCarpeta, "Examenes.txt");

            int nuevoId = 1;

            if (File.Exists(rutaExamenes))
            {
                string[] lineas = File.ReadAllLines(rutaExamenes);
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

            string idsPreguntas = string.Join(",", examen.Select(p => p.PreguntaId));
            string lineaExamen = $"{nuevoId}|{fechaExamen:dd/MM/yyyy}|{asignatura}|{txtUniversidad.Text}|{txtCarrera.Text}|{idsPreguntas}";
            File.AppendAllText(rutaExamenes, lineaExamen + Environment.NewLine);

            string rutaImpresion = Path.Combine(rutaCarpeta, "ImpresionExamen.txt");
            using (StreamWriter writer = new StreamWriter(rutaImpresion, true))
            {
                writer.WriteLine("=== EXAMEN GENERADO ===");
                writer.WriteLine($"ID Examen: {nuevoId}");
                writer.WriteLine($"Fecha: {fechaExamen:dd/MM/yyyy}");
                writer.WriteLine($"Universidad: {txtUniversidad.Text}");
                writer.WriteLine($"Carrera: {txtCarrera.Text}");
                writer.WriteLine($"Asignatura: {asignatura}");
                writer.WriteLine("\nPreguntas:\n");

                for (int i = 0; i < examen.Count; i++)
                {
                    writer.WriteLine($"Pregunta {i + 1} (ID: {examen[i].PreguntaId}): {examen[i].TituloPregunta}");

                    for (int j = 0; j < examen[i].ListaRespuestas.Count; j++)
                    {
                        writer.WriteLine($"   {j + 1}. {examen[i].ListaRespuestas[j]}");
                    }

                    writer.WriteLine();
                }
                writer.WriteLine("=================================\n");
            }
            MessageBox.Show("Examen guardado correctamente.");
        }

        private List<Pregunta> CargarPreguntasDesdeArchivo()
        {
            List<Pregunta> preguntas = new List<Pregunta>();

            if (!File.Exists("Preguntas.txt"))
            {
                MessageBox.Show("El arcivo Preguntas.txt no existe");
                return preguntas;
            }

            string[] lineas = File.ReadAllLines("Preguntas.txt");

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] partes = linea.Split('|');

                if (partes.Length != 9)
                {
                    MessageBox.Show($"Error en el formato de la linea: {linea}");
                    continue;
                }

                Pregunta pregunta = new Pregunta
                {
                    PreguntaId = int.Parse(partes[0]),
                    TituloPregunta = partes[1],
                    ListaRespuestas = new List<string> { partes[2], partes[3], partes[4], partes[5] },
                    Asignatura = partes[6],
                    Unidad = partes[7],
                    Subunidad = partes[8]
                };

                preguntas.Add(pregunta);
            }
            return preguntas;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimirExamen_Click(object sender, EventArgs e)
        {
            if (rtbListaExamenes.Text == string.Empty)
            {
                MessageBox.Show("Primero debe generar un examen");
                return;
            }

            Form formularioImpresion = new Form();
            formularioImpresion.Text = "Version Imprimible del Examen";
            formularioImpresion.StartPosition = FormStartPosition.CenterScreen;
            formularioImpresion.Size = new Size(800, 600);
            formularioImpresion.FormBorderStyle = FormBorderStyle.FixedDialog;
            formularioImpresion.MaximizeBox = false;

            RichTextBox rtbImpresion = new RichTextBox();
            rtbImpresion.Dock = DockStyle.Fill;
            rtbImpresion.ReadOnly = true;
            rtbImpresion.Font = new Font("Arial", 12);
            rtbImpresion.Text = GenerarTextoImprimible();

            Button btnImprimirAhora = new Button();
            btnImprimirAhora.Text = "Imprimir";
            btnImprimirAhora.Dock = DockStyle.Bottom;
            btnImprimirAhora.Height = 40;
            btnImprimirAhora.Click += (s, args) => { ImprimirExamen(rtbImpresion.Text); };

            formularioImpresion.Controls.Add(rtbImpresion);
            formularioImpresion.Controls.Add(btnImprimirAhora);
            formularioImpresion.ShowDialog();
        }

        private string GenerarTextoImprimible()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("EXAMEN ACADEMICO");
            sb.AppendLine("============================");
            sb.AppendLine($"Asignatura: {cmbAsignatura.SelectedItem}");
            sb.AppendLine($"Fecha: {txtFecha.Text}");
            sb.AppendLine($"Universidad: {txtUniversidad.Text}");
            sb.AppendLine($"Carrera: {txtCarrera.Text}");
            sb.AppendLine();
            sb.AppendLine("INSTRUCCIONES:");
            sb.AppendLine("- Marque con una X la respuesta correcta");
            sb.AppendLine("============================");
            sb.AppendLine();

            string[] lineas = rtbListaExamenes.Text.Split('\n');

            foreach (string linea in lineas)
            {
                if (linea.Contains("=== Preguntas Cargadas ===")) continue;
                if (linea.Contains("Asignatura:")) continue;
                if (linea.Contains("Fecha:")) continue;

                string lineaImpresion = linea.Replace("Pregunta", "\nPregunta").Replace("   ", "   ").Replace("1. ", "[ ] ").Replace("2. ", "[ ] ").Replace("3. ", "[ ] ").Replace("4. ", "[ ] ");

                sb.AppendLine(lineaImpresion);
            }

            sb.AppendLine();
            sb.AppendLine("_________________________");
            sb.AppendLine("Firma del estudiante");
            sb.AppendLine();
            sb.AppendLine("_________________________");
            sb.AppendLine("Firma del profesor");

            return sb.ToString();
        }

        private void ImprimirExamen(string textoExamen)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += (sender, e) => { e.Graphics.DrawString(textoExamen, new Font("Arial", 12), Brushes.Black, new RectangleF(50, 50, e.PageBounds.Width - 100, e.PageBounds.Height - 100)); };

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
