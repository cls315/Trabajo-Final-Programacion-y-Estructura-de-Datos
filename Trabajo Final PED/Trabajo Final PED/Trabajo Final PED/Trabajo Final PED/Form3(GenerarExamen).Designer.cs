namespace Trabajo_Final_PED
{
    partial class Form3_GenerarExamen_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGenerarExamen = new Label();
            lblFecha = new Label();
            lblAsignatura = new Label();
            lblUnidades = new Label();
            cmbAsignatura = new ComboBox();
            clbUnidades = new CheckedListBox();
            btnCrear = new Button();
            lblCabecera = new Label();
            lblUniversidad = new Label();
            lblCarrera = new Label();
            lblContenidodelExamen = new Label();
            txtFecha = new TextBox();
            txtUniversidad = new TextBox();
            txtCarrera = new TextBox();
            rtbListaExamenes = new RichTextBox();
            btnVolver = new Button();
            btnImprimirExamen = new Button();
            SuspendLayout();
            // 
            // lblGenerarExamen
            // 
            lblGenerarExamen.AutoSize = true;
            lblGenerarExamen.Location = new Point(312, 9);
            lblGenerarExamen.Name = "lblGenerarExamen";
            lblGenerarExamen.Size = new Size(108, 15);
            lblGenerarExamen.TabIndex = 0;
            lblGenerarExamen.Text = "GENERAR EXAMEN";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(42, 223);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(42, 267);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 3;
            lblAsignatura.Text = "Asignatura";
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(42, 313);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(56, 15);
            lblUnidades.TabIndex = 4;
            lblUnidades.Text = "Unidades";
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(145, 259);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(121, 23);
            cmbAsignatura.TabIndex = 8;
            cmbAsignatura.SelectedIndexChanged += cmbAsignatura_SelectedIndexChanged;
            // 
            // clbUnidades
            // 
            clbUnidades.FormattingEnabled = true;
            clbUnidades.Location = new Point(145, 302);
            clbUnidades.Name = "clbUnidades";
            clbUnidades.Size = new Size(120, 94);
            clbUnidades.TabIndex = 9;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(170, 439);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear Examen";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblCabecera
            // 
            lblCabecera.AutoSize = true;
            lblCabecera.Location = new Point(42, 34);
            lblCabecera.Name = "lblCabecera";
            lblCabecera.Size = new Size(56, 15);
            lblCabecera.TabIndex = 12;
            lblCabecera.Text = "Cabecera";
            // 
            // lblUniversidad
            // 
            lblUniversidad.AutoSize = true;
            lblUniversidad.Location = new Point(42, 84);
            lblUniversidad.Name = "lblUniversidad";
            lblUniversidad.Size = new Size(69, 15);
            lblUniversidad.TabIndex = 13;
            lblUniversidad.Text = "Universidad";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(42, 122);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 14;
            lblCarrera.Text = "Carrera";
            // 
            // lblContenidodelExamen
            // 
            lblContenidodelExamen.AutoSize = true;
            lblContenidodelExamen.Location = new Point(42, 183);
            lblContenidodelExamen.Name = "lblContenidodelExamen";
            lblContenidodelExamen.Size = new Size(127, 15);
            lblContenidodelExamen.TabIndex = 15;
            lblContenidodelExamen.Text = "Contenido del examen";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(145, 215);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 16;
            // 
            // txtUniversidad
            // 
            txtUniversidad.Location = new Point(145, 76);
            txtUniversidad.Name = "txtUniversidad";
            txtUniversidad.Size = new Size(100, 23);
            txtUniversidad.TabIndex = 17;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(145, 112);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 18;
            // 
            // rtbListaExamenes
            // 
            rtbListaExamenes.Location = new Point(397, 71);
            rtbListaExamenes.Name = "rtbListaExamenes";
            rtbListaExamenes.Size = new Size(332, 325);
            rtbListaExamenes.TabIndex = 19;
            rtbListaExamenes.Text = "";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(53, 439);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 20;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnImprimirExamen
            // 
            btnImprimirExamen.Location = new Point(492, 402);
            btnImprimirExamen.Name = "btnImprimirExamen";
            btnImprimirExamen.Size = new Size(138, 33);
            btnImprimirExamen.TabIndex = 21;
            btnImprimirExamen.Text = "Imprimir Examen";
            btnImprimirExamen.UseVisualStyleBackColor = true;
            btnImprimirExamen.Click += btnImprimirExamen_Click;
            // 
            // Form3_GenerarExamen_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(btnImprimirExamen);
            Controls.Add(btnVolver);
            Controls.Add(rtbListaExamenes);
            Controls.Add(txtCarrera);
            Controls.Add(txtUniversidad);
            Controls.Add(txtFecha);
            Controls.Add(lblContenidodelExamen);
            Controls.Add(lblCarrera);
            Controls.Add(lblUniversidad);
            Controls.Add(lblCabecera);
            Controls.Add(btnCrear);
            Controls.Add(clbUnidades);
            Controls.Add(cmbAsignatura);
            Controls.Add(lblUnidades);
            Controls.Add(lblAsignatura);
            Controls.Add(lblFecha);
            Controls.Add(lblGenerarExamen);
            Name = "Form3_GenerarExamen_";
            Text = "Form3_GenerarExamen_";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenerarExamen;
        private Label lblFecha;
        private Label lblAsignatura;
        private Label lblUnidades;
        private ComboBox cmbAsignatura;
        private CheckedListBox clbUnidades;
        private Button btnCrear;
        private Label lblCabecera;
        private Label lblUniversidad;
        private Label lblCarrera;
        private Label lblContenidodelExamen;
        private TextBox txtFecha;
        private TextBox txtUniversidad;
        private TextBox txtCarrera;
        private RichTextBox rtbListaExamenes;
        private Button btnVolver;
        private Button btnImprimirExamen;
    }
}