namespace CapaPresentacion
{
    partial class WF_Inscripciones_Administrar
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
            dgvInscripciones = new DataGridView();
            btnInscrito = new Button();
            btnRetirado = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.BackgroundColor = SystemColors.ActiveCaption;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(57, 61);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 51;
            dgvInscripciones.Size = new Size(863, 375);
            dgvInscripciones.TabIndex = 0;
            // 
            // btnInscrito
            // 
            btnInscrito.BackColor = SystemColors.GradientInactiveCaption;
            btnInscrito.Location = new Point(273, 449);
            btnInscrito.Name = "btnInscrito";
            btnInscrito.Size = new Size(94, 29);
            btnInscrito.TabIndex = 1;
            btnInscrito.Text = "Inscrito";
            btnInscrito.UseVisualStyleBackColor = false;
            btnInscrito.Click += btnInscrito_Click;
            // 
            // btnRetirado
            // 
            btnRetirado.BackColor = SystemColors.GradientInactiveCaption;
            btnRetirado.Location = new Point(445, 449);
            btnRetirado.Name = "btnRetirado";
            btnRetirado.Size = new Size(94, 29);
            btnRetirado.TabIndex = 2;
            btnRetirado.Text = "Retirado";
            btnRetirado.UseVisualStyleBackColor = false;
            btnRetirado.Click += btnRetirado_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Image = Properties.Resources.salir_alt;
            button1.Location = new Point(953, 12);
            button1.Name = "button1";
            button1.Size = new Size(55, 58);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // WF_Inscripciones_Administrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1020, 490);
            Controls.Add(button1);
            Controls.Add(btnRetirado);
            Controls.Add(btnInscrito);
            Controls.Add(dgvInscripciones);
            Name = "WF_Inscripciones_Administrar";
            Text = "WF_Inscripciones_Administrar";
            FormClosing += WF_Inscripciones_Administrar_FormClosing;
            Load += WF_Inscripciones_Administrar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInscripciones;
        private Button btnInscrito;
        private Button btnRetirado;
        private Button button1;
    }
}