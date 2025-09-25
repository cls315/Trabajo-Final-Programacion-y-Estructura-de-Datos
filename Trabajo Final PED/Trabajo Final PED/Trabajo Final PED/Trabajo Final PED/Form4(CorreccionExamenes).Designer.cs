namespace Trabajo_Final_PED
{
    partial class Form4_CorreccionExamenes_
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
            lblCorreccionExamenes = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblIdExamen = new Label();
            lsbPreguntas = new ListBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtIdExamen = new TextBox();
            btnCargarExamen = new Button();
            btnCorregir = new Button();
            rtbFeedBack = new RichTextBox();
            SuspendLayout();
            // 
            // lblCorreccionExamenes
            // 
            lblCorreccionExamenes.AutoSize = true;
            lblCorreccionExamenes.Location = new Point(320, 9);
            lblCorreccionExamenes.Name = "lblCorreccionExamenes";
            lblCorreccionExamenes.Size = new Size(160, 15);
            lblCorreccionExamenes.TabIndex = 0;
            lblCorreccionExamenes.Text = "CORRECCION DE EXAMENES";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(47, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(47, 111);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblIdExamen
            // 
            lblIdExamen.AutoSize = true;
            lblIdExamen.Location = new Point(47, 161);
            lblIdExamen.Name = "lblIdExamen";
            lblIdExamen.Size = new Size(63, 15);
            lblIdExamen.TabIndex = 3;
            lblIdExamen.Text = "ID Examen";
            // 
            // lsbPreguntas
            // 
            lsbPreguntas.FormattingEnabled = true;
            lsbPreguntas.ItemHeight = 15;
            lsbPreguntas.Location = new Point(360, 59);
            lsbPreguntas.Name = "lsbPreguntas";
            lsbPreguntas.Size = new Size(389, 139);
            lsbPreguntas.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(145, 103);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtIdExamen
            // 
            txtIdExamen.Location = new Point(145, 153);
            txtIdExamen.Name = "txtIdExamen";
            txtIdExamen.Size = new Size(100, 23);
            txtIdExamen.TabIndex = 7;
            // 
            // btnCargarExamen
            // 
            btnCargarExamen.Location = new Point(47, 210);
            btnCargarExamen.Name = "btnCargarExamen";
            btnCargarExamen.Size = new Size(99, 28);
            btnCargarExamen.TabIndex = 8;
            btnCargarExamen.Text = "Cargar Examen";
            btnCargarExamen.UseVisualStyleBackColor = true;
            btnCargarExamen.Click += btnCargarExamen_Click;
            // 
            // btnCorregir
            // 
            btnCorregir.Location = new Point(170, 210);
            btnCorregir.Name = "btnCorregir";
            btnCorregir.Size = new Size(75, 28);
            btnCorregir.TabIndex = 9;
            btnCorregir.Text = "Corregir";
            btnCorregir.UseVisualStyleBackColor = true;
            btnCorregir.Click += btnCorregir_Click;
            // 
            // rtbFeedBack
            // 
            rtbFeedBack.Location = new Point(47, 263);
            rtbFeedBack.Name = "rtbFeedBack";
            rtbFeedBack.Size = new Size(702, 175);
            rtbFeedBack.TabIndex = 10;
            rtbFeedBack.Text = "";
            // 
            // Form4_CorreccionExamenes_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbFeedBack);
            Controls.Add(btnCorregir);
            Controls.Add(btnCargarExamen);
            Controls.Add(txtIdExamen);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lsbPreguntas);
            Controls.Add(lblIdExamen);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblCorreccionExamenes);
            Name = "Form4_CorreccionExamenes_";
            Text = "Form4_CorreccionExamenes_";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreccionExamenes;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblIdExamen;
        private ListBox lsbPreguntas;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtIdExamen;
        private Button btnCargarExamen;
        private Button btnCorregir;
        private RichTextBox rtbFeedBack;
    }
}