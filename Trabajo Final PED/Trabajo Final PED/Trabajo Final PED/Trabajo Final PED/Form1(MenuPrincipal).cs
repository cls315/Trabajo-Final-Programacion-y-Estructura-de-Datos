namespace Trabajo_Final_PED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Inicializacion de lista Preguntas Hardcodeadas
            DatosCompartidos.ListaGlobalPreguntas = new ListaPregunta();
            DatosCompartidos.ListaGlobalPreguntas.CargarPreguntasDePrueba();
        }

        private void btnAdmBancoPreg_Click(object sender, EventArgs e)
        {
            Form2 nuevaVentana = new Form2();
            nuevaVentana.Show();
        }

        private void btnGenerarExamen_Click(object sender, EventArgs e)
        {
            Form3_GenerarExamen_ nuevaVentana = new Form3_GenerarExamen_();
            nuevaVentana.Show();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCorreccionExamen_Click(object sender, EventArgs e)
        {
            Form4_CorreccionExamenes_ nuevaVentana = new Form4_CorreccionExamenes_();
            nuevaVentana.Show();
        }
    }
}
