namespace CapaPresentacion
{
    partial class WF_Docente
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
            dgvDocente = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            txtTitulo = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnParticipantes = new Button();
            btnCursos = new Button();
            btnPrograma = new Button();
            btnInscripciones = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).BeginInit();
            SuspendLayout();
            // 
            // dgvDocente
            // 
            dgvDocente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocente.Location = new Point(12, 121);
            dgvDocente.Name = "dgvDocente";
            dgvDocente.RowHeadersWidth = 51;
            dgvDocente.Size = new Size(917, 572);
            dgvDocente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(983, 160);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(983, 202);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(983, 302);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(260, 27);
            txtTitulo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(983, 260);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "Titulo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(983, 501);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(260, 27);
            txtTelefono.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(983, 459);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(983, 401);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(260, 27);
            txtCorreo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(983, 359);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "Correo";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(987, 604);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 32);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1117, 604);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 32);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.Location = new Point(12, 31);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(147, 38);
            btnParticipantes.TabIndex = 11;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.UseVisualStyleBackColor = true;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(164, 31);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(147, 38);
            btnCursos.TabIndex = 12;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnPrograma
            // 
            btnPrograma.Location = new Point(317, 31);
            btnPrograma.Name = "btnPrograma";
            btnPrograma.Size = new Size(147, 38);
            btnPrograma.TabIndex = 13;
            btnPrograma.Text = "Programas";
            btnPrograma.UseVisualStyleBackColor = true;
            btnPrograma.Click += btnPrograma_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.Location = new Point(470, 31);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(147, 38);
            btnInscripciones.TabIndex = 14;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = true;
            // 
            // WF_Docente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 733);
            Controls.Add(btnInscripciones);
            Controls.Add(btnPrograma);
            Controls.Add(btnCursos);
            Controls.Add(btnParticipantes);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dgvDocente);
            Name = "WF_Docente";
            Text = "WF_Docente";
            Load += WF_Docente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDocente;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnParticipantes;
        private Button btnCursos;
        private Button btnPrograma;
        private Button btnInscripciones;
    }
}