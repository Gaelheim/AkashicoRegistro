namespace CapaPresentacion
{
    partial class WF_Programa
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
            dgvPrograma = new DataGridView();
            txtNombre = new TextBox();
            txtDuracion = new TextBox();
            cbxCurso = new ComboBox();
            cbxDocente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnDocente = new Button();
            btnCurso = new Button();
            btnPrograma = new Button();
            cbxDias = new ComboBox();
            label6 = new Label();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnWfcurso = new Button();
            btnWfDocente = new Button();
            btnParticipantes = new Button();
            btnEliminar = new Button();
            cbxHorario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrograma).BeginInit();
            SuspendLayout();
            // 
            // dgvPrograma
            // 
            dgvPrograma.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPrograma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrograma.Location = new Point(12, 107);
            dgvPrograma.Name = "dgvPrograma";
            dgvPrograma.RowHeadersWidth = 51;
            dgvPrograma.Size = new Size(906, 552);
            dgvPrograma.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1050, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 27);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(1050, 400);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(219, 27);
            txtDuracion.TabIndex = 2;
            txtDuracion.KeyPress += txtDuracion_KeyPress;
            // 
            // cbxCurso
            // 
            cbxCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCurso.FormattingEnabled = true;
            cbxCurso.Location = new Point(1050, 221);
            cbxCurso.Name = "cbxCurso";
            cbxCurso.Size = new Size(219, 28);
            cbxCurso.TabIndex = 4;
            // 
            // cbxDocente
            // 
            cbxDocente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDocente.FormattingEnabled = true;
            cbxDocente.Location = new Point(1050, 311);
            cbxDocente.Name = "cbxDocente";
            cbxDocente.Size = new Size(219, 28);
            cbxDocente.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1050, 107);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 6;
            label1.Text = "Titulo del Programa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1050, 198);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 7;
            label2.Text = "Curso Perteneciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1050, 288);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 8;
            label3.Text = "Docente Encargado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1050, 377);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 9;
            label4.Text = "Semanas de duración";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1050, 466);
            label5.Name = "label5";
            label5.Size = new Size(155, 20);
            label5.TabIndex = 10;
            label5.Text = "¿Qué días se imparte?";
            // 
            // btnDocente
            // 
            btnDocente.BackColor = SystemColors.GradientActiveCaption;
            btnDocente.Location = new Point(12, 676);
            btnDocente.Name = "btnDocente";
            btnDocente.Size = new Size(242, 29);
            btnDocente.TabIndex = 11;
            btnDocente.Text = "Cargar Docentes";
            btnDocente.UseVisualStyleBackColor = false;
            btnDocente.Click += btnDocente_Click;
            // 
            // btnCurso
            // 
            btnCurso.BackColor = SystemColors.GradientActiveCaption;
            btnCurso.Location = new Point(291, 676);
            btnCurso.Name = "btnCurso";
            btnCurso.Size = new Size(242, 29);
            btnCurso.TabIndex = 12;
            btnCurso.Text = "Cargar Cursos";
            btnCurso.UseVisualStyleBackColor = false;
            btnCurso.Click += btnCurso_Click;
            // 
            // btnPrograma
            // 
            btnPrograma.BackColor = SystemColors.GradientActiveCaption;
            btnPrograma.Location = new Point(558, 676);
            btnPrograma.Name = "btnPrograma";
            btnPrograma.Size = new Size(242, 29);
            btnPrograma.TabIndex = 13;
            btnPrograma.Text = "Cargar Programas";
            btnPrograma.UseVisualStyleBackColor = false;
            btnPrograma.Click += btnPrograma_Click;
            // 
            // cbxDias
            // 
            cbxDias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDias.FormattingEnabled = true;
            cbxDias.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            cbxDias.Location = new Point(1050, 489);
            cbxDias.Name = "cbxDias";
            cbxDias.Size = new Size(219, 28);
            cbxDias.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1050, 556);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 15;
            label6.Text = "Hora de Inicio";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Aquamarine;
            btnGuardar.Location = new Point(993, 654);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Info;
            btnEditar.Location = new Point(1111, 654);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnWfcurso
            // 
            btnWfcurso.BackColor = SystemColors.ActiveCaption;
            btnWfcurso.Location = new Point(24, 38);
            btnWfcurso.Name = "btnWfcurso";
            btnWfcurso.Size = new Size(94, 29);
            btnWfcurso.TabIndex = 18;
            btnWfcurso.Text = "Cursos";
            btnWfcurso.UseVisualStyleBackColor = false;
            btnWfcurso.Click += btnWfcurso_Click;
            // 
            // btnWfDocente
            // 
            btnWfDocente.BackColor = SystemColors.ActiveCaption;
            btnWfDocente.Location = new Point(146, 38);
            btnWfDocente.Name = "btnWfDocente";
            btnWfDocente.Size = new Size(94, 29);
            btnWfDocente.TabIndex = 19;
            btnWfDocente.Text = "Docentes";
            btnWfDocente.UseVisualStyleBackColor = false;
            btnWfDocente.Click += btnWfDocente_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.BackColor = SystemColors.ActiveCaption;
            btnParticipantes.Location = new Point(270, 38);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(132, 29);
            btnParticipantes.TabIndex = 20;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.UseVisualStyleBackColor = false;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Location = new Point(1234, 654);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbxHorario
            // 
            cbxHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Items.AddRange(new object[] { "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" });
            cbxHorario.Location = new Point(1050, 586);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(219, 28);
            cbxHorario.TabIndex = 22;
            // 
            // WF_Programa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1355, 743);
            Controls.Add(cbxHorario);
            Controls.Add(btnEliminar);
            Controls.Add(btnParticipantes);
            Controls.Add(btnWfDocente);
            Controls.Add(btnWfcurso);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(cbxDias);
            Controls.Add(btnPrograma);
            Controls.Add(btnCurso);
            Controls.Add(btnDocente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxDocente);
            Controls.Add(cbxCurso);
            Controls.Add(txtDuracion);
            Controls.Add(txtNombre);
            Controls.Add(dgvPrograma);
            Name = "WF_Programa";
            Text = "WF_Programa";
            Load += WF_Programa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrograma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrograma;
        private TextBox txtNombre;
        private TextBox txtDuracion;
        private ComboBox cbxCurso;
        private ComboBox cbxDocente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnDocente;
        private Button btnCurso;
        private Button btnPrograma;
        private ComboBox cbxDias;
        private Label label6;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnWfcurso;
        private Button btnWfDocente;
        private Button btnParticipantes;
        private Button btnEliminar;
        private ComboBox cbxHorario;
    }
}