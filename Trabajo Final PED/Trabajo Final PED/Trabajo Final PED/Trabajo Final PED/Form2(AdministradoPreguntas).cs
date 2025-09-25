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
    public partial class Form2 : Form
    {
        ListaPregunta lista = DatosCompartidos.ListaGlobalPreguntas;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarLista();

            string rutaCarpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Trabajo Final PED",
                "Trabajo Final PED",
                "Archivos TXT"
            );

            Directory.CreateDirectory(rutaCarpeta);
            string rutaArchivo = Path.Combine(rutaCarpeta, "Preguntas.txt");

            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                Pregunta actual = lista.Inicio;
                while (actual != null)
                {
                    string linea = $"{actual.PreguntaId}|{actual.TituloPregunta}|{actual.ListaRespuestas[0]}|{actual.ListaRespuestas[1]}|{actual.ListaRespuestas[2]}|{actual.ListaRespuestas[3]}|{actual.RespustaCorrecta}|{actual.Asignatura}|{actual.Unidad}|{actual.Subunidad}";
                    writer.WriteLine(linea);
                    actual = actual.Siguiente;
                }
            }
        }

        private void btnCargarRespuestas_Click(object sender, EventArgs e)
        {
            // Cargar ComboBox con Resputestas.txt
            string texto = txtRespuestas.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Debe ingresar al menos una respuesta.");
                return;
            }

            string[] respuestasSeparadas = texto.Split(';');

            cmbRespuestaCorrecta.Items.Clear();

            if (respuestasSeparadas.Length > 4)
            {
                MessageBox.Show("No se pueden agregar mas de 4 respuestas.");
            }
            else
            {
                foreach (string r in respuestasSeparadas)
                {
                    string respuestaLimpia = r.Trim();
                    if (!string.IsNullOrEmpty(respuestaLimpia))
                    {
                        cmbRespuestaCorrecta.Items.Add(respuestaLimpia);
                    }
                }
            }
        }

        private void btnAgregarPregunta_Click(object sender, EventArgs e)
        {
            // Cargar infromacion a ListaPreguntas()
            int idPregunta;

            if (!int.TryParse(txtIdPregunta.Text, out idPregunta))
            {
                MessageBox.Show("Ingrese un ID valido");
                return;
            }

            if (string.IsNullOrEmpty(txtPregunta.Text) || string.IsNullOrEmpty(txtRespuestas.Text) || cmbRespuestaCorrecta.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos y seleccione una respuesta correcta.");
                return;
            }

            string[] respuestas = txtRespuestas.Text.Split(";");    
            lista.AgregarPregunta(idPregunta, txtPregunta.Text, respuestas, cmbRespuestaCorrecta.Text, txtAsignatura.Text, txtUnidad.Text, txtSubunidad.Text);
            MostrarLista();

            string registro = $"{idPregunta}|{txtPregunta.Text}|{respuestas[0]}|{respuestas[1]}|{respuestas[2]}|{respuestas[3]}|{cmbRespuestaCorrecta.Text}|{txtAsignatura.Text}|{txtUnidad.Text}|{txtSubunidad.Text}";

            string rutaCarpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Trabajo Final PED",
                "Trabajo Final PED",
                "Archivos TXT"
            );

            Directory.CreateDirectory(rutaCarpeta);

            string rutaArchivo = Path.Combine(rutaCarpeta, "Preguntas.txt");

            File.AppendAllText(rutaArchivo, registro + Environment.NewLine);

            txtIdPregunta.Clear();
            txtPregunta.Clear();
            txtRespuestas.Clear();
            cmbRespuestaCorrecta.Items.Clear();
            txtAsignatura.Clear();
            txtUnidad.Clear();
            txtSubunidad.Clear();
        }

        private void btnModificarPregunta_Click(object sender, EventArgs e)
        {
            Pregunta preguntaSeleccionada = (Pregunta)lsbListaPreguntas.SelectedItem;
            string[] respuestas = txtRespuestas.Text.Split(';');

            lista.ModificarPregunta(preguntaSeleccionada.PreguntaId, txtPregunta.Text, respuestas, cmbRespuestaCorrecta.Text, txtAsignatura.Text, txtUnidad.Text, txtSubunidad.Text);

            MostrarLista();

            string rutaArchivo = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Trabajo Final PED",
                "Trabajo Final PED",
                "Archivos TXT",
                "Preguntas.txt"
            );
            List<string> lineas = File.ReadAllLines(rutaArchivo).ToList();

            int idBuscado = preguntaSeleccionada.PreguntaId;
            bool encontrado = false;

            for (int i = 0; i < lineas.Count; i++)
            {
                string[] campos = lineas[i].Split('|');

                if (campos.Length > 0 && int.TryParse(campos[0].Trim(), out int idExistente) && idExistente == idBuscado)
                {
                    string nuevaLista = $"{idBuscado}|{txtPregunta.Text}|{respuestas[0]}|{respuestas[1]}|{respuestas[2]}|{respuestas[3]}|{cmbRespuestaCorrecta.Text}|{txtAsignatura.Text}|{txtUnidad.Text}|{txtSubunidad.Text}";

                    lineas[i] = nuevaLista;
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(rutaArchivo, lineas);
                MessageBox.Show("Pregunta modificada correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontro una pregunta con ese ID.");
            }
        }

        private void btnEliminarPregunta_Click(object sender, EventArgs e)
        {
            Pregunta preguntaSeleccionada = (Pregunta)lsbListaPreguntas.SelectedItem;
            lista.EliminarPregunta(preguntaSeleccionada.PreguntaId);

            if (lista.Inicio != null)
                MostrarLista();
            else
                lsbListaPreguntas.Items.Clear();

            string rutaArchivo = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Trabajo Final PED",
                "Trabajo Final PED",
                "Archivos TXT",
                "Preguntas.txt"
            );

            List<string> lineas = File.ReadAllLines(rutaArchivo).ToList();

            int idBuscado = preguntaSeleccionada.PreguntaId;
            bool encontrado = false;

            for (int i = 0; i < lineas.Count; i++)
            {
                string[] campos = lineas[i].Split('|');

                if (campos.Length > 0 && int.TryParse(campos[0].Trim(), out int idExistente) && idExistente == idBuscado)
                {
                    string elementoBorrado = null;

                    lineas[i] = elementoBorrado;
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(rutaArchivo, lineas);
                MessageBox.Show("Pregunta eliminada correctamente.");

                txtIdPregunta.Clear();
                txtPregunta.Clear();
                txtRespuestas.Clear();
                cmbRespuestaCorrecta.Items.Clear();
                txtAsignatura.Clear();
                txtUnidad.Clear();
                txtSubunidad.Clear();
            }
            else
            {
                MessageBox.Show("No se encontro una pregunta con ese ID.");
            }
        }

        private void btnListarGeneral_Click(object sender, EventArgs e)
        {
            lsbListaPreguntas.DataSource = null;
            lsbListaPreguntas.DataSource = lista.ObtenerPreguntas();
        }

        private void btnListarUnidad_Click(object sender, EventArgs e)
        {
            lsbListaPreguntas.DataSource = null;
            lsbListaPreguntas.DataSource = lista.ObtenerPreguntasOrdenadasPorUnidad();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Funciones ListBox
        void MostrarLista()
        {
            lsbListaPreguntas.Items.Clear();
            Pregunta actual = lista.Inicio;

            while (actual != null)
            {
                lsbListaPreguntas.Items.Add($"[{actual.PreguntaId}] {actual.TituloPregunta}");
                actual = actual.Siguiente;
            }
        }

        void AgregarNodoAlListBox(Pregunta nodo)
        {
            if (nodo != null)
                this.lsbListaPreguntas.Items.Add(nodo);
            else
                MessageBox.Show("El nodo no es valido y no puede ser agregado.");

            if (nodo?.Siguiente != null)
                AgregarNodoAlListBox(nodo.Siguiente);
        }

        private void lsbListaPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbListaPreguntas.SelectedItem != null)
            {
                Pregunta preguntaSeleccionada = (Pregunta)lsbListaPreguntas.SelectedItem;

                txtIdPregunta.Text = preguntaSeleccionada.PreguntaId.ToString();
                txtPregunta.Text = preguntaSeleccionada.TituloPregunta;
                txtRespuestas.Text = string.Join(Environment.NewLine, preguntaSeleccionada.ListaRespuestas);
                cmbRespuestaCorrecta.Text = preguntaSeleccionada.RespustaCorrecta;
                txtAsignatura.Text = preguntaSeleccionada.Asignatura;
                txtUnidad.Text = preguntaSeleccionada.Unidad;
                txtSubunidad.Text = preguntaSeleccionada.Subunidad;
            }
        }
    }
}
