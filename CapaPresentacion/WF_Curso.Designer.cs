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
            // WF_Curso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 613);
            Controls.Add(dgvCurso);
            Name = "WF_Curso";
            Text = "WF_Curso";
            Load += WF_Curso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCurso;
    }
}