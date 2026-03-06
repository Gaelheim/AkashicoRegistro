namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCedula = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnInsertar = new Button();
            btnEditar = new Button();
            btnBajaA = new Button();
            btnBajaM = new Button();
            btnActivar = new Button();
            btnCursos = new Button();
            btnPrograma = new Button();
            btnDocentes = new Button();
            btnInscripciones = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(723, 427);
            dataGridView1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(964, 204);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(964, 265);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(258, 27);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "Apellido";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(964, 325);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(258, 27);
            txtCedula.TabIndex = 3;
            txtCedula.Text = "Cedula";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(964, 377);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(258, 27);
            txtCorreo.TabIndex = 4;
            txtCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(964, 436);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(258, 27);
            txtTelefono.TabIndex = 5;
            txtTelefono.Text = "Telefono";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.PaleGreen;
            btnInsertar.Location = new Point(964, 506);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(258, 65);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Guardar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaption;
            btnEditar.Location = new Point(12, 581);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBajaA
            // 
            btnBajaA.BackColor = SystemColors.ActiveCaption;
            btnBajaA.Location = new Point(152, 612);
            btnBajaA.Name = "btnBajaA";
            btnBajaA.Size = new Size(139, 29);
            btnBajaA.TabIndex = 9;
            btnBajaA.Text = "Baja Academica";
            btnBajaA.UseVisualStyleBackColor = false;
            btnBajaA.Click += btnBajaA_Click;
            // 
            // btnBajaM
            // 
            btnBajaM.BackColor = SystemColors.ActiveCaption;
            btnBajaM.Location = new Point(152, 577);
            btnBajaM.Name = "btnBajaM";
            btnBajaM.Size = new Size(139, 29);
            btnBajaM.TabIndex = 10;
            btnBajaM.Text = "Baja Medica";
            btnBajaM.UseVisualStyleBackColor = false;
            btnBajaM.Click += btnBajaM_Click;
            // 
            // btnActivar
            // 
            btnActivar.BackColor = SystemColors.ActiveCaption;
            btnActivar.Location = new Point(340, 581);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(139, 29);
            btnActivar.TabIndex = 11;
            btnActivar.Text = "Activar";
            btnActivar.UseVisualStyleBackColor = false;
            btnActivar.Click += btnActivar_Click;
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(12, 33);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(163, 29);
            btnCursos.TabIndex = 12;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnPrograma
            // 
            btnPrograma.Location = new Point(12, 91);
            btnPrograma.Name = "btnPrograma";
            btnPrograma.Size = new Size(163, 29);
            btnPrograma.TabIndex = 13;
            btnPrograma.Text = "Programas";
            btnPrograma.UseVisualStyleBackColor = true;
            btnPrograma.Click += btnPrograma_Click;
            // 
            // btnDocentes
            // 
            btnDocentes.Location = new Point(197, 33);
            btnDocentes.Name = "btnDocentes";
            btnDocentes.Size = new Size(163, 29);
            btnDocentes.TabIndex = 14;
            btnDocentes.Text = "Docentes";
            btnDocentes.UseVisualStyleBackColor = true;
            btnDocentes.Click += btnDocentes_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.Location = new Point(197, 91);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(163, 29);
            btnInscripciones.TabIndex = 15;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1267, 690);
            Controls.Add(btnInscripciones);
            Controls.Add(btnDocentes);
            Controls.Add(btnPrograma);
            Controls.Add(btnCursos);
            Controls.Add(btnActivar);
            Controls.Add(btnBajaM);
            Controls.Add(btnBajaA);
            Controls.Add(btnEditar);
            Controls.Add(btnInsertar);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtCedula);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCedula;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnInsertar;
        private Button btnEditar;
        private Button btnBajaA;
        private Button btnBajaM;
        private Button btnActivar;
        private Button btnCursos;
        private Button btnPrograma;
        private Button btnDocentes;
        private Button btnInscripciones;
    }
}
