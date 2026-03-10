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
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            button6 = new Button();
            button3 = new Button();
            Inscripciones = new Button();
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
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(396, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 482);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button5.Image = Properties.Resources.grafico_histograma;
            button5.Location = new Point(71, 333);
            button5.Name = "button5";
            button5.Size = new Size(268, 106);
            button5.TabIndex = 2;
            button5.Text = "Reportes";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
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
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Image = Properties.Resources.agregar_usuario;
            button1.Location = new Point(71, 78);
            button1.Name = "button1";
            button1.Size = new Size(268, 106);
            button1.TabIndex = 0;
            button1.Text = "Participantes";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(Inscripciones);
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
            Inscripciones.BackColor = SystemColors.GradientActiveCaption;
            Inscripciones.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            Inscripciones.Image = Properties.Resources.editar__1_;
            Inscripciones.Location = new Point(58, 78);
            Inscripciones.Name = "Inscripciones";
            Inscripciones.Size = new Size(268, 106);
            Inscripciones.TabIndex = 3;
            Inscripciones.Text = "Inscripciones";
            Inscripciones.TextAlign = ContentAlignment.BottomCenter;
            Inscripciones.UseVisualStyleBackColor = false;
            Inscripciones.Click += button4_Click;
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
        private Button button5;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Button button6;
        private Button button3;
        private Button Inscripciones;
    }
}