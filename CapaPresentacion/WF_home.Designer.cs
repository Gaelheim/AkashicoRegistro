namespace CapaPresentacion
{
    partial class WF_home
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnReportes = new Button();
            btnDocente = new Button();
            btnParticipantes = new Button();
            panel3 = new Panel();
            btnPrograma = new Button();
            btnCurso = new Button();
            btnInscripciones = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(389, 53);
            label1.TabIndex = 0;
            label1.Text = "Registro Akashico";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReportes);
            panel2.Controls.Add(btnDocente);
            panel2.Controls.Add(btnParticipantes);
            panel2.Location = new Point(396, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 482);
            panel2.TabIndex = 1;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.GradientActiveCaption;
            btnReportes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnReportes.Image = Properties.Resources.grafico_histograma;
            btnReportes.Location = new Point(71, 333);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(268, 106);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.BottomCenter;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnDocente
            // 
            btnDocente.BackColor = SystemColors.GradientActiveCaption;
            btnDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDocente.Image = Properties.Resources.usuarios;
            btnDocente.Location = new Point(71, 206);
            btnDocente.Name = "btnDocente";
            btnDocente.Size = new Size(268, 106);
            btnDocente.TabIndex = 1;
            btnDocente.Text = "Docentes";
            btnDocente.TextAlign = ContentAlignment.BottomCenter;
            btnDocente.UseVisualStyleBackColor = false;
            btnDocente.Click += btnDocente_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.BackColor = SystemColors.GradientActiveCaption;
            btnParticipantes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnParticipantes.Image = Properties.Resources.agregar_usuario;
            btnParticipantes.Location = new Point(71, 78);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(268, 106);
            btnParticipantes.TabIndex = 0;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.TextAlign = ContentAlignment.BottomCenter;
            btnParticipantes.UseVisualStyleBackColor = false;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPrograma);
            panel3.Controls.Add(btnCurso);
            panel3.Controls.Add(btnInscripciones);
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 482);
            panel3.TabIndex = 2;
            // 
            // btnPrograma
            // 
            btnPrograma.BackColor = SystemColors.GradientActiveCaption;
            btnPrograma.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnPrograma.Image = Properties.Resources.lapiz;
            btnPrograma.Location = new Point(58, 333);
            btnPrograma.Name = "btnPrograma";
            btnPrograma.Size = new Size(268, 106);
            btnPrograma.TabIndex = 3;
            btnPrograma.Text = "Programas";
            btnPrograma.TextAlign = ContentAlignment.BottomCenter;
            btnPrograma.UseVisualStyleBackColor = false;
            btnPrograma.Click += btnPrograma_Click;
            // 
            // btnCurso
            // 
            btnCurso.BackColor = SystemColors.GradientActiveCaption;
            btnCurso.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnCurso.Image = Properties.Resources.gorro_de_graduacion;
            btnCurso.Location = new Point(58, 206);
            btnCurso.Name = "btnCurso";
            btnCurso.Size = new Size(268, 106);
            btnCurso.TabIndex = 2;
            btnCurso.Text = "Cursos";
            btnCurso.TextAlign = ContentAlignment.BottomCenter;
            btnCurso.UseVisualStyleBackColor = false;
            btnCurso.Click += btnCurso_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.BackColor = SystemColors.GradientActiveCaption;
            btnInscripciones.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnInscripciones.Image = Properties.Resources.editar__1_;
            btnInscripciones.Location = new Point(58, 78);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(268, 106);
            btnInscripciones.TabIndex = 3;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.TextAlign = ContentAlignment.BottomCenter;
            btnInscripciones.UseVisualStyleBackColor = false;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // WF_home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(813, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WF_home";
            Text = "WF_home";
            FormClosing += WF_home_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnReportes;
        private Button btnDocente;
        private Button btnParticipantes;
        private Panel panel3;
        private Button btnPrograma;
        private Button btnCurso;
        private Button btnInscripciones;
    }
}