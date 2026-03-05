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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            cbxCurso = new ComboBox();
            cbxDocente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrograma).BeginInit();
            SuspendLayout();
            // 
            // dgvPrograma
            // 
            dgvPrograma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrograma.Location = new Point(12, 107);
            dgvPrograma.Name = "dgvPrograma";
            dgvPrograma.RowHeadersWidth = 51;
            dgvPrograma.Size = new Size(906, 552);
            dgvPrograma.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1050, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1050, 400);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1050, 489);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 27);
            textBox3.TabIndex = 3;
            // 
            // cbxCurso
            // 
            cbxCurso.FormattingEnabled = true;
            cbxCurso.Location = new Point(1050, 221);
            cbxCurso.Name = "cbxCurso";
            cbxCurso.Size = new Size(219, 28);
            cbxCurso.TabIndex = 4;
            // 
            // cbxDocente
            // 
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
            // WF_Programa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 743);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxDocente);
            Controls.Add(cbxCurso);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox cbxCurso;
        private ComboBox cbxDocente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}