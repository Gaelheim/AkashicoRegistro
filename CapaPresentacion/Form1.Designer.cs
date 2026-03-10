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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(905, 427);
            dataGridView1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(967, 171);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 27);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(967, 232);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(258, 27);
            txtApellido.TabIndex = 2;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(967, 292);
            txtCedula.MaxLength = 20;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(258, 27);
            txtCedula.TabIndex = 3;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(967, 344);
            txtCorreo.MaxLength = 90;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(258, 27);
            txtCorreo.TabIndex = 4;
            txtCorreo.Text = "Ejemplo@correo.com";
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(967, 403);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(258, 27);
            txtTelefono.TabIndex = 5;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.PaleGreen;
            btnInsertar.Location = new Point(967, 473);
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
            btnEditar.Location = new Point(967, 566);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(258, 64);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBajaA
            // 
            btnBajaA.BackColor = SystemColors.ActiveCaption;
            btnBajaA.Location = new Point(11, 603);
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
            btnBajaM.Location = new Point(156, 603);
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
            btnActivar.Location = new Point(301, 603);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(139, 29);
            btnActivar.TabIndex = 11;
            btnActivar.Text = "Activar";
            btnActivar.UseVisualStyleBackColor = false;
            btnActivar.Click += btnActivar_Click;
            // 
            // btnCursos
            // 
            btnCursos.BackColor = SystemColors.GradientActiveCaption;
            btnCursos.Location = new Point(371, 12);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(163, 35);
            btnCursos.TabIndex = 12;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = false;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnPrograma
            // 
            btnPrograma.BackColor = SystemColors.GradientActiveCaption;
            btnPrograma.Location = new Point(7, 12);
            btnPrograma.Name = "btnPrograma";
            btnPrograma.Size = new Size(163, 35);
            btnPrograma.TabIndex = 13;
            btnPrograma.Text = "Programas";
            btnPrograma.UseVisualStyleBackColor = false;
            btnPrograma.Click += btnPrograma_Click;
            // 
            // btnDocentes
            // 
            btnDocentes.BackColor = SystemColors.GradientActiveCaption;
            btnDocentes.Location = new Point(556, 12);
            btnDocentes.Name = "btnDocentes";
            btnDocentes.Size = new Size(163, 35);
            btnDocentes.TabIndex = 14;
            btnDocentes.Text = "Docentes";
            btnDocentes.UseVisualStyleBackColor = false;
            btnDocentes.Click += btnDocentes_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.BackColor = SystemColors.GradientActiveCaption;
            btnInscripciones.Location = new Point(192, 12);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(163, 35);
            btnInscripciones.TabIndex = 15;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = false;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(967, 148);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 16;
            label1.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(967, 209);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 17;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(967, 269);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 18;
            label3.Text = "Cedula de Identidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(967, 322);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 19;
            label4.Text = "Correo Electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(967, 380);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 20;
            label5.Text = "Número de Telefono";
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.GradientActiveCaption;
            btnHome.Image = Properties.Resources.salir_alt;
            btnHome.Location = new Point(1176, 22);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 58);
            btnHome.TabIndex = 21;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1267, 690);
            Controls.Add(btnHome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnHome;
    }
}
