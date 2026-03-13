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
            btnParticipantes = new Button();
            btnProgramas = new Button();
            btnDocentes = new Button();
            btnInscripciones = new Button();
            btnHome = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCurso).BeginInit();
            SuspendLayout();
            // 
            // dgvCurso
            // 
            dgvCurso.BackgroundColor = SystemColors.ActiveCaption;
            dgvCurso.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurso.GridColor = SystemColors.ActiveCaption;
            dgvCurso.Location = new Point(12, 162);
            dgvCurso.Name = "dgvCurso";
            dgvCurso.RowHeadersWidth = 51;
            dgvCurso.Size = new Size(846, 474);
            dgvCurso.TabIndex = 0;
            // 
            // DtFecha
            // 
            DtFecha.Location = new Point(997, 317);
            DtFecha.Name = "DtFecha";
            DtFecha.Size = new Size(297, 27);
            DtFecha.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(997, 175);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 27);
            txtNombre.TabIndex = 2;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Cursor = Cursors.IBeam;
            txtCapacidad.Location = new Point(997, 244);
            txtCapacidad.MaxLength = 2;
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(297, 27);
            txtCapacidad.TabIndex = 3;
            txtCapacidad.KeyPress += txtCapacidad_KeyPress;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.MediumSpringGreen;
            btnInsertar.Cursor = Cursors.Hand;
            btnInsertar.Location = new Point(997, 382);
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
            btnEliminar.Location = new Point(997, 539);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(305, 55);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Gold;
            btnEditar.Location = new Point(997, 458);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(305, 59);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.BackColor = SystemColors.GradientActiveCaption;
            btnParticipantes.Location = new Point(12, 30);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(157, 27);
            btnParticipantes.TabIndex = 7;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.UseVisualStyleBackColor = false;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnProgramas
            // 
            btnProgramas.BackColor = SystemColors.GradientActiveCaption;
            btnProgramas.Location = new Point(359, 30);
            btnProgramas.Name = "btnProgramas";
            btnProgramas.Size = new Size(157, 27);
            btnProgramas.TabIndex = 8;
            btnProgramas.Text = "Programas";
            btnProgramas.UseVisualStyleBackColor = false;
            btnProgramas.Click += btnProgramas_Click;
            // 
            // btnDocentes
            // 
            btnDocentes.BackColor = SystemColors.GradientActiveCaption;
            btnDocentes.Location = new Point(186, 30);
            btnDocentes.Name = "btnDocentes";
            btnDocentes.Size = new Size(157, 27);
            btnDocentes.TabIndex = 9;
            btnDocentes.Text = "Docentes";
            btnDocentes.UseVisualStyleBackColor = false;
            btnDocentes.Click += btnDocentes_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.BackColor = SystemColors.GradientActiveCaption;
            btnInscripciones.Location = new Point(533, 30);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(157, 27);
            btnInscripciones.TabIndex = 10;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = false;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.GradientActiveCaption;
            btnHome.Image = Properties.Resources.salir_alt;
            btnHome.Location = new Point(1241, 14);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 58);
            btnHome.TabIndex = 16;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(997, 152);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(126, 20);
            label1.TabIndex = 17;
            label1.Text = "Nombre de Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(997, 221);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 18;
            label2.Text = "Capacidad Maxima";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(997, 294);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 19;
            label3.Text = "Fecha Inicio";
            // 
            // WF_Curso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1335, 708);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHome);
            Controls.Add(btnInscripciones);
            Controls.Add(btnDocentes);
            Controls.Add(btnProgramas);
            Controls.Add(btnParticipantes);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombre);
            Controls.Add(DtFecha);
            Controls.Add(dgvCurso);
            Name = "WF_Curso";
            Text = "WF_Curso";
            FormClosing += WF_Curso_FormClosing;
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
        private Button btnParticipantes;
        private Button btnProgramas;
        private Button btnDocentes;
        private Button btnInscripciones;
        private Button btnHome;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}