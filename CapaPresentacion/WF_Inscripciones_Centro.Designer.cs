namespace CapaPresentacion
{
    partial class WF_Inscripciones_Centro
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
            btnAñadir = new Button();
            panel3 = new Panel();
            btnAdministrar = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 6);
            label1.Name = "label1";
            label1.Size = new Size(727, 53);
            label1.TabIndex = 0;
            label1.Text = "Centro de Gestión de Inscripciones";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(btnAñadir);
            panel2.Location = new Point(1, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 367);
            panel2.TabIndex = 1;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = SystemColors.GradientActiveCaption;
            btnAñadir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.Image = Properties.Resources.agregar_usuario;
            btnAñadir.Location = new Point(65, 115);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(223, 108);
            btnAñadir.TabIndex = 1;
            btnAñadir.Text = "Añadir";
            btnAñadir.TextAlign = ContentAlignment.BottomCenter;
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnAdministrar);
            panel3.Location = new Point(422, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 367);
            panel3.TabIndex = 2;
            // 
            // btnAdministrar
            // 
            btnAdministrar.BackColor = SystemColors.GradientActiveCaption;
            btnAdministrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdministrar.Image = Properties.Resources.caja__1_;
            btnAdministrar.Location = new Point(67, 115);
            btnAdministrar.Name = "btnAdministrar";
            btnAdministrar.Size = new Size(223, 108);
            btnAdministrar.TabIndex = 0;
            btnAdministrar.Text = "Administrar";
            btnAdministrar.TextAlign = ContentAlignment.BottomCenter;
            btnAdministrar.UseVisualStyleBackColor = false;
            btnAdministrar.Click += btnAdministrar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Image = Properties.Resources.salir_alt;
            button1.Location = new Point(308, 309);
            button1.Name = "button1";
            button1.Size = new Size(55, 58);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // WF_Inscripciones_Centro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WF_Inscripciones_Centro";
            Text = "WF_Inscripciones_Centro";
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
        private Panel panel3;
        private Button btnAdministrar;
        private Button btnAñadir;
        private Button button1;
    }
}