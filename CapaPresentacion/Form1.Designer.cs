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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(723, 427);
            dataGridView1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(978, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(978, 129);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(258, 27);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "Apellido";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(978, 189);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(258, 27);
            txtCedula.TabIndex = 3;
            txtCedula.Text = "Cedula";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(978, 241);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(258, 27);
            txtCorreo.TabIndex = 4;
            txtCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(978, 300);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(258, 27);
            txtTelefono.TabIndex = 5;
            txtTelefono.Text = "Telefono";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(978, 370);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(258, 65);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Guardar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(26, 445);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBajaA
            // 
            btnBajaA.Location = new Point(166, 476);
            btnBajaA.Name = "btnBajaA";
            btnBajaA.Size = new Size(139, 29);
            btnBajaA.TabIndex = 9;
            btnBajaA.Text = "Baja Academica";
            btnBajaA.UseVisualStyleBackColor = true;
            btnBajaA.Click += btnBajaA_Click;
            // 
            // btnBajaM
            // 
            btnBajaM.Location = new Point(166, 441);
            btnBajaM.Name = "btnBajaM";
            btnBajaM.Size = new Size(139, 29);
            btnBajaM.TabIndex = 10;
            btnBajaM.Text = "Baja Medica";
            btnBajaM.UseVisualStyleBackColor = true;
            btnBajaM.Click += btnBajaM_Click;
            // 
            // btnActivar
            // 
            btnActivar.Location = new Point(354, 445);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(139, 29);
            btnActivar.TabIndex = 11;
            btnActivar.Text = "Activar";
            btnActivar.UseVisualStyleBackColor = true;
            btnActivar.Click += btnActivar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 532);
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
    }
}
