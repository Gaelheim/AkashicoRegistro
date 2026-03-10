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
            button2 = new Button();
            btnParticipantes = new Button();
            panel3 = new Panel();
            button6 = new Button();
            button3 = new Button();
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
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnParticipantes);
            panel2.Location = new Point(396, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 482);
            panel2.TabIndex = 1;
            // 
            // button5
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
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Image = Properties.Resources.usuarios;
            button2.Location = new Point(71, 206);
            button2.Name = "button2";
            button2.Size = new Size(268, 106);
            button2.TabIndex = 1;
            button2.Text = "Docentes";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            btnParticipantes.BackColor = SystemColors.GradientActiveCaption;
            btnParticipantes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnParticipantes.Image = Properties.Resources.agregar_usuario;
            btnParticipantes.Location = new Point(71, 78);
            btnParticipantes.Name = "button1";
            btnParticipantes.Size = new Size(268, 106);
            btnParticipantes.TabIndex = 0;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.TextAlign = ContentAlignment.BottomCenter;
            btnParticipantes.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(btnInscripciones);
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 482);
            panel3.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GradientActiveCaption;
            button6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            button6.Image = Properties.Resources.lapiz;
            button6.Location = new Point(58, 333);
            button6.Name = "button6";
            button6.Size = new Size(268, 106);
            button6.TabIndex = 3;
            button6.Text = "Programas";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            button3.Image = Properties.Resources.gorro_de_graduacion;
            button3.Location = new Point(58, 206);
            button3.Name = "button3";
            button3.Size = new Size(268, 106);
            button3.TabIndex = 2;
            button3.Text = "Cursos";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Inscripciones
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
        private Button button2;
        private Button btnParticipantes;
        private Panel panel3;
        private Button button6;
        private Button button3;
        private Button btnInscripciones;
    }
}