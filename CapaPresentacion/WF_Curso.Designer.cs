namespace CapaPresentacion
{
    partial class WF_Curso
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
            dgvCurso = new DataGridView();
            DtFecha = new DateTimePicker();
            txtNombre = new TextBox();
            txtCapacidad = new TextBox();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCurso).BeginInit();
            SuspendLayout();
            // 
            // dgvCurso
            // 
            dgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurso.Location = new Point(12, 12);
            dgvCurso.Name = "dgvCurso";
            dgvCurso.RowHeadersWidth = 51;
            dgvCurso.Size = new Size(846, 474);
            dgvCurso.TabIndex = 0;
            // 
            // DtFecha
            // 
            DtFecha.Location = new Point(997, 167);
            DtFecha.Name = "DtFecha";
            DtFecha.Size = new Size(297, 27);
            DtFecha.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(997, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 27);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Nombre de Curso";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(997, 94);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(297, 27);
            txtCapacidad.TabIndex = 3;
            txtCapacidad.Text = "Capacidad Maxima";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(997, 232);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(305, 54);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Guardar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // WF_Curso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 613);
            Controls.Add(btnInsertar);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombre);
            Controls.Add(DtFecha);
            Controls.Add(dgvCurso);
            Name = "WF_Curso";
            Text = "WF_Curso";
            Load += WF_Curso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCurso;
        private DateTimePicker DtFecha;
        private TextBox txtNombre;
        private TextBox txtCapacidad;
        private Button btnInsertar;
    }
}