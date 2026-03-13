namespace CapaPresentacion
{
    partial class WF_Reportes
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
            btnOcupacion = new Button();
            btnDesercion = new Button();
            tabReporte = new TabControl();
            tabOcupacion = new TabPage();
            panelOcupacion = new Panel();
            dgvOcupacion = new DataGridView();
            tabDesercion = new TabPage();
            dgvDesercion = new DataGridView();
            panelDesercion = new Panel();
            btnHome = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabReporte.SuspendLayout();
            tabOcupacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOcupacion).BeginInit();
            tabDesercion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDesercion).BeginInit();
            SuspendLayout();
            // 
            // btnOcupacion
            // 
            btnOcupacion.Location = new Point(31, 39);
            btnOcupacion.Name = "btnOcupacion";
            btnOcupacion.Size = new Size(208, 29);
            btnOcupacion.TabIndex = 0;
            btnOcupacion.Text = "Ocupación";
            btnOcupacion.UseVisualStyleBackColor = true;
            btnOcupacion.Click += btnOcupacion_Click;
            // 
            // btnDesercion
            // 
            btnDesercion.Location = new Point(262, 39);
            btnDesercion.Name = "btnDesercion";
            btnDesercion.Size = new Size(208, 29);
            btnDesercion.TabIndex = 1;
            btnDesercion.Text = "Deserción";
            btnDesercion.UseVisualStyleBackColor = true;
            btnDesercion.Click += btnDesercion_Click;
            // 
            // tabReporte
            // 
            tabReporte.Controls.Add(tabOcupacion);
            tabReporte.Controls.Add(tabDesercion);
            tabReporte.Location = new Point(12, 87);
            tabReporte.Name = "tabReporte";
            tabReporte.SelectedIndex = 0;
            tabReporte.Size = new Size(1751, 930);
            tabReporte.TabIndex = 2;
            // 
            // tabOcupacion
            // 
            tabOcupacion.Controls.Add(panelOcupacion);
            tabOcupacion.Controls.Add(dgvOcupacion);
            tabOcupacion.Location = new Point(4, 29);
            tabOcupacion.Name = "tabOcupacion";
            tabOcupacion.Padding = new Padding(3);
            tabOcupacion.Size = new Size(1743, 897);
            tabOcupacion.TabIndex = 0;
            tabOcupacion.Text = "Ocupación";
            tabOcupacion.UseVisualStyleBackColor = true;
            // 
            // panelOcupacion
            // 
            panelOcupacion.Location = new Point(669, 3);
            panelOcupacion.Name = "panelOcupacion";
            panelOcupacion.Size = new Size(1068, 888);
            panelOcupacion.TabIndex = 1;
            // 
            // dgvOcupacion
            // 
            dgvOcupacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOcupacion.Location = new Point(0, 0);
            dgvOcupacion.Name = "dgvOcupacion";
            dgvOcupacion.RowHeadersWidth = 51;
            dgvOcupacion.Size = new Size(663, 894);
            dgvOcupacion.TabIndex = 0;
            // 
            // tabDesercion
            // 
            tabDesercion.Controls.Add(dgvDesercion);
            tabDesercion.Controls.Add(panelDesercion);
            tabDesercion.Location = new Point(4, 29);
            tabDesercion.Name = "tabDesercion";
            tabDesercion.Padding = new Padding(3);
            tabDesercion.Size = new Size(1743, 897);
            tabDesercion.TabIndex = 1;
            tabDesercion.Text = "Deserción";
            tabDesercion.UseVisualStyleBackColor = true;
            // 
            // dgvDesercion
            // 
            dgvDesercion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesercion.Location = new Point(0, 0);
            dgvDesercion.Name = "dgvDesercion";
            dgvDesercion.RowHeadersWidth = 51;
            dgvDesercion.Size = new Size(612, 891);
            dgvDesercion.TabIndex = 1;
            // 
            // panelDesercion
            // 
            panelDesercion.Location = new Point(618, 0);
            panelDesercion.Name = "panelDesercion";
            panelDesercion.Size = new Size(1125, 897);
            panelDesercion.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.GradientActiveCaption;
            btnHome.Image = Properties.Resources.salir_alt;
            btnHome.Location = new Point(1240, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 58);
            btnHome.TabIndex = 16;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // WF_Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1808, 1029);
            Controls.Add(btnHome);
            Controls.Add(tabReporte);
            Controls.Add(btnDesercion);
            Controls.Add(btnOcupacion);
            Name = "WF_Reportes";
            Text = "WF_Reportes";
            FormClosing += WF_Reportes_FormClosing;
            Load += WF_Reportes_Load;
            tabReporte.ResumeLayout(false);
            tabOcupacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOcupacion).EndInit();
            tabDesercion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDesercion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOcupacion;
        private Button btnDesercion;
        private TabControl tabReporte;
        private TabPage tabOcupacion;
        private TabPage tabDesercion;
        private DataGridView dgvOcupacion;
        private Panel panelOcupacion;
        private Panel panelDesercion;
        private DataGridView dgvDesercion;
        private Button btnHome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}