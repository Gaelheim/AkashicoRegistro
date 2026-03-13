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
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).BeginInit();
            SuspendLayout();
            // 
            // dgvDocente
            // 
            dgvDocente.BackgroundColor = SystemColors.ActiveCaption;
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
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 27);
            txtNombre.TabIndex = 2;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(983, 302);
            txtTitulo.MaxLength = 100;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(260, 27);
            txtTitulo.TabIndex = 4;
            txtTitulo.KeyPress += txtTitulo_KeyPress;
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
            txtTelefono.KeyPress += txtTelefono_KeyPress;
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
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(260, 27);
            txtCorreo.TabIndex = 6;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            txtCorreo.Leave += txtCorreo_Leave;
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
            btnEditar.BackColor = Color.LemonChiffon;
            btnEditar.Location = new Point(983, 621);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(237, 45);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.PaleGreen;
            btnGuardar.Location = new Point(983, 565);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(237, 45);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.BackColor = SystemColors.GradientActiveCaption;
            btnParticipantes.Location = new Point(12, 42);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(147, 27);
            btnParticipantes.TabIndex = 11;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.UseVisualStyleBackColor = false;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnCursos
            // 
            btnCursos.BackColor = SystemColors.GradientActiveCaption;
            btnCursos.Location = new Point(164, 42);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(147, 27);
            btnCursos.TabIndex = 12;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = false;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnPrograma
            // 
            btnPrograma.BackColor = SystemColors.GradientActiveCaption;
            btnPrograma.Location = new Point(317, 42);
            btnPrograma.Name = "btnPrograma";
            btnPrograma.Size = new Size(147, 27);
            btnPrograma.TabIndex = 13;
            btnPrograma.Text = "Programas";
            btnPrograma.UseVisualStyleBackColor = false;
            btnPrograma.Click += btnPrograma_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.BackColor = SystemColors.GradientActiveCaption;
            btnInscripciones.Location = new Point(470, 42);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(147, 27);
            btnInscripciones.TabIndex = 14;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = false;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.GradientActiveCaption;
            btnHome.Image = Properties.Resources.salir_alt;
            btnHome.Location = new Point(1191, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 58);
            btnHome.TabIndex = 15;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // WF_Docente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1277, 733);
            Controls.Add(btnHome);
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
            FormClosing += WF_Docente_FormClosing;
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
        private Button btnHome;
    }
}