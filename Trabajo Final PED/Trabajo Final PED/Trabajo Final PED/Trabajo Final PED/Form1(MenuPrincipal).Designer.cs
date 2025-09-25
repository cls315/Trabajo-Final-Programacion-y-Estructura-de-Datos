namespace Trabajo_Final_PED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMenuPrincipal = new Label();
            btnAdmBancoPreg = new Button();
            btnGenerarExamen = new Button();
            btnCorreccionExamen = new Button();
            btnTerminar = new Button();
            SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.Location = new Point(290, 49);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(101, 15);
            lblMenuPrincipal.TabIndex = 0;
            lblMenuPrincipal.Text = "MENU PRINCIPAL";
            // 
            // btnAdmBancoPreg
            // 
            btnAdmBancoPreg.Location = new Point(218, 91);
            btnAdmBancoPreg.Name = "btnAdmBancoPreg";
            btnAdmBancoPreg.Size = new Size(235, 29);
            btnAdmBancoPreg.TabIndex = 1;
            btnAdmBancoPreg.Text = "ADMINISTRAR BANCO DE PREGUNTAS";
            btnAdmBancoPreg.UseVisualStyleBackColor = true;
            btnAdmBancoPreg.Click += btnAdmBancoPreg_Click;
            // 
            // btnGenerarExamen
            // 
            btnGenerarExamen.Location = new Point(218, 141);
            btnGenerarExamen.Name = "btnGenerarExamen";
            btnGenerarExamen.Size = new Size(235, 29);
            btnGenerarExamen.TabIndex = 2;
            btnGenerarExamen.Text = "GENERAR EXAMEN";
            btnGenerarExamen.UseVisualStyleBackColor = true;
            btnGenerarExamen.Click += btnGenerarExamen_Click;
            // 
            // btnCorreccionExamen
            // 
            btnCorreccionExamen.Location = new Point(218, 194);
            btnCorreccionExamen.Name = "btnCorreccionExamen";
            btnCorreccionExamen.Size = new Size(235, 29);
            btnCorreccionExamen.TabIndex = 4;
            btnCorreccionExamen.Text = "CORRECCION DE EXAMEN";
            btnCorreccionExamen.UseVisualStyleBackColor = true;
            btnCorreccionExamen.Click += btnCorreccionExamen_Click;
            // 
            // btnTerminar
            // 
            btnTerminar.Location = new Point(218, 250);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(235, 29);
            btnTerminar.TabIndex = 5;
            btnTerminar.Text = "TERMINAR";
            btnTerminar.UseVisualStyleBackColor = true;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 374);
            Controls.Add(btnTerminar);
            Controls.Add(btnCorreccionExamen);
            Controls.Add(btnGenerarExamen);
            Controls.Add(btnAdmBancoPreg);
            Controls.Add(lblMenuPrincipal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuPrincipal;
        private Button btnAdmBancoPreg;
        private Button btnGenerarExamen;
        private Button btnCorreccionExamen;
        private Button btnTerminar;
    }
}
