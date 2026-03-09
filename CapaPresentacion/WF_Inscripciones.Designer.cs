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
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // dgvInscripciones
            // 
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
            cbxParticipante.Location = new Point(1062, 101);
            cbxParticipante.Name = "cbxParticipante";
            cbxParticipante.Size = new Size(243, 28);
            cbxParticipante.TabIndex = 1;
            // 
            // cbxCurso
            // 
            cbxCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCurso.FormattingEnabled = true;
            cbxCurso.Location = new Point(1062, 199);
            cbxCurso.Name = "cbxCurso";
            cbxCurso.Size = new Size(243, 28);
            cbxCurso.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1062, 302);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1181, 302);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // WF_Inscripciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 691);
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
        }

        #endregion

        private DataGridView dgvInscripciones;
        private ComboBox cbxParticipante;
        private ComboBox cbxCurso;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}