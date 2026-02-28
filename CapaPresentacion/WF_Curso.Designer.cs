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
            btnEliminar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCurso).BeginInit();
            SuspendLayout();
            // 
            // dgvCurso
            // 
            dgvCurso.BackgroundColor = SystemColors.ActiveCaption;
            dgvCurso.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurso.GridColor = SystemColors.ActiveCaption;
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
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(997, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 27);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Nombre de Curso";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Cursor = Cursors.IBeam;
            txtCapacidad.Location = new Point(997, 94);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(297, 27);
            txtCapacidad.TabIndex = 3;
            txtCapacidad.Text = "Capacidad Maxima";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.MediumSpringGreen;
            btnInsertar.Cursor = Cursors.Hand;
            btnInsertar.Location = new Point(997, 232);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(305, 54);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Guardar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Brown;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(997, 312);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(305, 48);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Gold;
            btnEditar.Location = new Point(30, 492);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(133, 40);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // WF_Curso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1335, 613);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
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
        private Button btnEliminar;
        private Button btnEditar;
    }
}