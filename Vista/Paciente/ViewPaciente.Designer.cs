namespace PTC.Vista.Paciente
{
    partial class ViewPaciente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmsEliminarPaciente = new System.Windows.Forms.Button();
            this.cmsActualizarPaciente = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.cmsVerPaciente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleName = "btnBuscar";
            this.btnBuscar.Location = new System.Drawing.Point(409, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(159, 59);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(244, 22);
            this.txtBuscar.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmsVerPaciente);
            this.panel1.Controls.Add(this.cmsEliminarPaciente);
            this.panel1.Controls.Add(this.cmsActualizarPaciente);
            this.panel1.Controls.Add(this.btnNuevoPaciente);
            this.panel1.Location = new System.Drawing.Point(159, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 51);
            this.panel1.TabIndex = 12;
            // 
            // cmsEliminarPaciente
            // 
            this.cmsEliminarPaciente.AccessibleName = "cmsEliminar";
            this.cmsEliminarPaciente.Location = new System.Drawing.Point(902, 15);
            this.cmsEliminarPaciente.Name = "cmsEliminarPaciente";
            this.cmsEliminarPaciente.Size = new System.Drawing.Size(75, 23);
            this.cmsEliminarPaciente.TabIndex = 2;
            this.cmsEliminarPaciente.Text = "Eliminar";
            this.cmsEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // cmsActualizarPaciente
            // 
            this.cmsActualizarPaciente.AccessibleName = "cmsActualizarPaciente";
            this.cmsActualizarPaciente.Location = new System.Drawing.Point(821, 15);
            this.cmsActualizarPaciente.Name = "cmsActualizarPaciente";
            this.cmsActualizarPaciente.Size = new System.Drawing.Size(75, 23);
            this.cmsActualizarPaciente.TabIndex = 1;
            this.cmsActualizarPaciente.Text = "Actualizar";
            this.cmsActualizarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.AccessibleName = "btnNuevo";
            this.btnNuevoPaciente.Location = new System.Drawing.Point(983, 15);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoPaciente.TabIndex = 0;
            this.btnNuevoPaciente.Text = "Nuevo";
            this.btnNuevoPaciente.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(159, 131);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(1070, 589);
            this.dgvPacientes.TabIndex = 11;
            // 
            // cmsVerPaciente
            // 
            this.cmsVerPaciente.AccessibleName = "cmsVerPaciente";
            this.cmsVerPaciente.Location = new System.Drawing.Point(740, 15);
            this.cmsVerPaciente.Name = "cmsVerPaciente";
            this.cmsVerPaciente.Size = new System.Drawing.Size(75, 23);
            this.cmsVerPaciente.TabIndex = 3;
            this.cmsVerPaciente.Text = "Ver";
            this.cmsVerPaciente.UseVisualStyleBackColor = true;
            // 
            // ViewPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPacientes);
            this.Name = "ViewPaciente";
            this.Text = "ViewPaciente";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button cmsEliminarPaciente;
        public System.Windows.Forms.Button cmsActualizarPaciente;
        public System.Windows.Forms.Button btnNuevoPaciente;
        public System.Windows.Forms.DataGridView dgvPacientes;
        public System.Windows.Forms.Button cmsVerPaciente;
    }
}