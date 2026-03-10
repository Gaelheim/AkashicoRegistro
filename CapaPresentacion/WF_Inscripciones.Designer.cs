namespace CapaPresentacion
{
    partial class WF_Inscripciones
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
            cbxParticipante = new ComboBox();
            cbxCurso = new ComboBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.BackgroundColor = SystemColors.ActiveCaption;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(2, 101);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 51;
            dgvInscripciones.Size = new Size(969, 488);
            dgvInscripciones.TabIndex = 0;
            // 
            // cbxParticipante
            // 
            cbxParticipante.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxParticipante.FormattingEnabled = true;
            cbxParticipante.Location = new Point(1046, 175);
            cbxParticipante.Name = "cbxParticipante";
            cbxParticipante.Size = new Size(243, 28);
            cbxParticipante.TabIndex = 1;
            // 
            // cbxCurso
            // 
            cbxCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCurso.FormattingEnabled = true;
            cbxCurso.Location = new Point(1046, 273);
            cbxCurso.Name = "cbxCurso";
            cbxCurso.Size = new Size(243, 28);
            cbxCurso.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1046, 376);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1165, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Image = Properties.Resources.salir_alt;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(61, 59);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1046, 152);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 6;
            label1.Text = "Matricula Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1046, 250);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 7;
            label2.Text = "Programa a Inscribir";
            // 
            // WF_Inscripciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1365, 691);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(cbxCurso);
            Controls.Add(cbxParticipante);
            Controls.Add(dgvInscripciones);
            Name = "WF_Inscripciones";
            Text = "WF_Inscripciones";
            Load += WF_Inscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInscripciones;
        private ComboBox cbxParticipante;
        private ComboBox cbxCurso;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}