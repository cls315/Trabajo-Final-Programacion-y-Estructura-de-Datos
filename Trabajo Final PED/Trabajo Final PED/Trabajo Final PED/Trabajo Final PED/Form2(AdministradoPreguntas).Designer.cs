namespace Trabajo_Final_PED
{
    partial class Form2
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
            lblAdministrarBancoPreguntas = new Label();
            lsbListaPreguntas = new ListBox();
            btnAgregarPregunta = new Button();
            btnModificarPregunta = new Button();
            btnEliminarPregunta = new Button();
            btnListarGeneral = new Button();
            btnListarUnidad = new Button();
            btnVolver = new Button();
            txtIdPregunta = new TextBox();
            txtPregunta = new TextBox();
            txtRespuestas = new TextBox();
            txtAsignatura = new TextBox();
            txtUnidad = new TextBox();
            txtSubunidad = new TextBox();
            cmbRespuestaCorrecta = new ComboBox();
            lblIdPregunta = new Label();
            lblPregunta = new Label();
            lblRespuestas = new Label();
            lblRespuestaCorrecta = new Label();
            lblAsignatura = new Label();
            lblUnidad = new Label();
            lblSubunidad = new Label();
            btnCargarRespuestas = new Button();
            SuspendLayout();
            // 
            // lblAdministrarBancoPreguntas
            // 
            lblAdministrarBancoPreguntas.AutoSize = true;
            lblAdministrarBancoPreguntas.Location = new Point(277, 28);
            lblAdministrarBancoPreguntas.Name = "lblAdministrarBancoPreguntas";
            lblAdministrarBancoPreguntas.Size = new Size(211, 15);
            lblAdministrarBancoPreguntas.TabIndex = 0;
            lblAdministrarBancoPreguntas.Text = "ADMINISTRAR BANCO DE PREGUNTAS";
            // 
            // lsbListaPreguntas
            // 
            lsbListaPreguntas.FormattingEnabled = true;
            lsbListaPreguntas.ItemHeight = 15;
            lsbListaPreguntas.Location = new Point(12, 91);
            lsbListaPreguntas.Name = "lsbListaPreguntas";
            lsbListaPreguntas.Size = new Size(350, 214);
            lsbListaPreguntas.TabIndex = 1;
            lsbListaPreguntas.SelectedIndexChanged += lsbListaPreguntas_SelectedIndexChanged;
            // 
            // btnAgregarPregunta
            // 
            btnAgregarPregunta.Location = new Point(581, 87);
            btnAgregarPregunta.Name = "btnAgregarPregunta";
            btnAgregarPregunta.Size = new Size(180, 29);
            btnAgregarPregunta.TabIndex = 2;
            btnAgregarPregunta.Text = "Agregar Nueva Pregunta";
            btnAgregarPregunta.UseVisualStyleBackColor = true;
            btnAgregarPregunta.Click += btnAgregarPregunta_Click;
            // 
            // btnModificarPregunta
            // 
            btnModificarPregunta.Location = new Point(581, 122);
            btnModificarPregunta.Name = "btnModificarPregunta";
            btnModificarPregunta.Size = new Size(180, 29);
            btnModificarPregunta.TabIndex = 3;
            btnModificarPregunta.Text = "Modificar Pregunta";
            btnModificarPregunta.UseVisualStyleBackColor = true;
            btnModificarPregunta.Click += btnModificarPregunta_Click;
            // 
            // btnEliminarPregunta
            // 
            btnEliminarPregunta.Location = new Point(581, 157);
            btnEliminarPregunta.Name = "btnEliminarPregunta";
            btnEliminarPregunta.Size = new Size(180, 29);
            btnEliminarPregunta.TabIndex = 4;
            btnEliminarPregunta.Text = "Eliminar Pregunta";
            btnEliminarPregunta.UseVisualStyleBackColor = true;
            btnEliminarPregunta.Click += btnEliminarPregunta_Click;
            // 
            // btnListarGeneral
            // 
            btnListarGeneral.Location = new Point(581, 192);
            btnListarGeneral.Name = "btnListarGeneral";
            btnListarGeneral.Size = new Size(180, 29);
            btnListarGeneral.TabIndex = 5;
            btnListarGeneral.Text = "Listar Preguntas General";
            btnListarGeneral.UseVisualStyleBackColor = true;
            btnListarGeneral.Click += btnListarGeneral_Click;
            // 
            // btnListarUnidad
            // 
            btnListarUnidad.Location = new Point(581, 227);
            btnListarUnidad.Name = "btnListarUnidad";
            btnListarUnidad.Size = new Size(180, 29);
            btnListarUnidad.TabIndex = 6;
            btnListarUnidad.Text = "Listar Pregunas Unidad";
            btnListarUnidad.UseVisualStyleBackColor = true;
            btnListarUnidad.Click += btnListarUnidad_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(581, 262);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(180, 29);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver al Menu Principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtIdPregunta
            // 
            txtIdPregunta.Location = new Point(388, 91);
            txtIdPregunta.Name = "txtIdPregunta";
            txtIdPregunta.Size = new Size(100, 23);
            txtIdPregunta.TabIndex = 8;
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(388, 139);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(100, 23);
            txtPregunta.TabIndex = 9;
            // 
            // txtRespuestas
            // 
            txtRespuestas.Location = new Point(388, 190);
            txtRespuestas.Name = "txtRespuestas";
            txtRespuestas.Size = new Size(100, 23);
            txtRespuestas.TabIndex = 10;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(389, 288);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(99, 23);
            txtAsignatura.TabIndex = 11;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(388, 335);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(100, 23);
            txtUnidad.TabIndex = 12;
            // 
            // txtSubunidad
            // 
            txtSubunidad.Location = new Point(388, 379);
            txtSubunidad.Name = "txtSubunidad";
            txtSubunidad.Size = new Size(100, 23);
            txtSubunidad.TabIndex = 13;
            // 
            // cmbRespuestaCorrecta
            // 
            cmbRespuestaCorrecta.FormattingEnabled = true;
            cmbRespuestaCorrecta.Location = new Point(389, 244);
            cmbRespuestaCorrecta.Name = "cmbRespuestaCorrecta";
            cmbRespuestaCorrecta.Size = new Size(99, 23);
            cmbRespuestaCorrecta.TabIndex = 14;
            // 
            // lblIdPregunta
            // 
            lblIdPregunta.AutoSize = true;
            lblIdPregunta.Location = new Point(404, 73);
            lblIdPregunta.Name = "lblIdPregunta";
            lblIdPregunta.Size = new Size(69, 15);
            lblIdPregunta.TabIndex = 15;
            lblIdPregunta.Text = "ID Pregunta";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(410, 121);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(55, 15);
            lblPregunta.TabIndex = 16;
            lblPregunta.Text = "Pregunta";
            // 
            // lblRespuestas
            // 
            lblRespuestas.AutoSize = true;
            lblRespuestas.Location = new Point(407, 172);
            lblRespuestas.Name = "lblRespuestas";
            lblRespuestas.Size = new Size(65, 15);
            lblRespuestas.TabIndex = 17;
            lblRespuestas.Text = "Respuestas";
            // 
            // lblRespuestaCorrecta
            // 
            lblRespuestaCorrecta.AutoSize = true;
            lblRespuestaCorrecta.Location = new Point(380, 223);
            lblRespuestaCorrecta.Name = "lblRespuestaCorrecta";
            lblRespuestaCorrecta.Size = new Size(108, 15);
            lblRespuestaCorrecta.TabIndex = 18;
            lblRespuestaCorrecta.Text = "Respuesta Correcta";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(404, 270);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 19;
            lblAsignatura.Text = "Asignatura";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(410, 317);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(45, 15);
            lblUnidad.TabIndex = 20;
            lblUnidad.Text = "Unidad";
            // 
            // lblSubunidad
            // 
            lblSubunidad.AutoSize = true;
            lblSubunidad.Location = new Point(404, 361);
            lblSubunidad.Name = "lblSubunidad";
            lblSubunidad.Size = new Size(64, 15);
            lblSubunidad.TabIndex = 21;
            lblSubunidad.Text = "Subunidad";
            // 
            // btnCargarRespuestas
            // 
            btnCargarRespuestas.Location = new Point(494, 181);
            btnCargarRespuestas.Name = "btnCargarRespuestas";
            btnCargarRespuestas.Size = new Size(72, 40);
            btnCargarRespuestas.TabIndex = 22;
            btnCargarRespuestas.Text = "Cargar Respuestas";
            btnCargarRespuestas.UseVisualStyleBackColor = true;
            btnCargarRespuestas.Click += btnCargarRespuestas_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarRespuestas);
            Controls.Add(lblSubunidad);
            Controls.Add(lblUnidad);
            Controls.Add(lblAsignatura);
            Controls.Add(lblRespuestaCorrecta);
            Controls.Add(lblRespuestas);
            Controls.Add(lblPregunta);
            Controls.Add(lblIdPregunta);
            Controls.Add(cmbRespuestaCorrecta);
            Controls.Add(txtSubunidad);
            Controls.Add(txtUnidad);
            Controls.Add(txtAsignatura);
            Controls.Add(txtRespuestas);
            Controls.Add(txtPregunta);
            Controls.Add(txtIdPregunta);
            Controls.Add(btnVolver);
            Controls.Add(btnListarUnidad);
            Controls.Add(btnListarGeneral);
            Controls.Add(btnEliminarPregunta);
            Controls.Add(btnModificarPregunta);
            Controls.Add(btnAgregarPregunta);
            Controls.Add(lsbListaPreguntas);
            Controls.Add(lblAdministrarBancoPreguntas);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdministrarBancoPreguntas;
        private ListBox lsbListaPreguntas;
        private Button btnAgregarPregunta;
        private Button btnModificarPregunta;
        private Button btnEliminarPregunta;
        private Button btnListarGeneral;
        private Button btnListarUnidad;
        private Button btnVolver;
        private TextBox txtIdPregunta;
        private TextBox txtPregunta;
        private TextBox txtRespuestas;
        private TextBox txtAsignatura;
        private TextBox txtUnidad;
        private TextBox txtSubunidad;
        private ComboBox cmbRespuestaCorrecta;
        private Label lblIdPregunta;
        private Label lblPregunta;
        private Label lblRespuestas;
        private Label lblRespuestaCorrecta;
        private Label lblAsignatura;
        private Label lblUnidad;
        private Label lblSubunidad;
        private Button btnCargarRespuestas;
    }
}