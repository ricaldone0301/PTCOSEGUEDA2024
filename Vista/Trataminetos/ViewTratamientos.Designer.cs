namespace PTC.Vista.Trataminetos
{
    partial class ViewTratamientos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmsEliminar = new System.Windows.Forms.Button();
            this.cmsActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuSearchEngine();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.cmsVerPaciente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmsVerPaciente);
            this.panel1.Controls.Add(this.cmsEliminar);
            this.panel1.Controls.Add(this.cmsActualizar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(266, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 51);
            this.panel1.TabIndex = 6;
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.AccessibleName = "cmsEliminar";
            this.cmsEliminar.Location = new System.Drawing.Point(902, 15);
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmsEliminar.TabIndex = 2;
            this.cmsEliminar.Text = "Eliminar";
            this.cmsEliminar.UseVisualStyleBackColor = true;
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.AccessibleName = "cmsActualizar";
            this.cmsActualizar.Location = new System.Drawing.Point(821, 15);
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.Size = new System.Drawing.Size(75, 23);
            this.cmsActualizar.TabIndex = 1;
            this.cmsActualizar.Text = "Actualizar";
            this.cmsActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AccessibleName = "btnNuevo";
            this.btnNuevo.Location = new System.Drawing.Point(983, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvCitas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(266, 126);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(1070, 589);
            this.dgvCitas.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.Tomato;
            this.txtBuscar.Location = new System.Drawing.Point(266, 24);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(292, 38);
            this.txtBuscar.TabIndex = 7;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // cmsVerPaciente
            // 
            this.cmsVerPaciente.AccessibleName = "cmsVerPaciente";
            this.cmsVerPaciente.Location = new System.Drawing.Point(740, 15);
            this.cmsVerPaciente.Name = "cmsVerPaciente";
            this.cmsVerPaciente.Size = new System.Drawing.Size(75, 23);
            this.cmsVerPaciente.TabIndex = 8;
            this.cmsVerPaciente.Text = "Ver";
            this.cmsVerPaciente.UseVisualStyleBackColor = true;
            // 
            // ViewTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 826);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCitas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1701, 873);
            this.MinimumSize = new System.Drawing.Size(1701, 873);
            this.Name = "ViewTratamientos";
            this.Text = "ViewTratamientos";
            this.Load += new System.EventHandler(this.ViewTratamientos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button cmsEliminar;
        public System.Windows.Forms.Button cmsActualizar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.DataGridView dgvCitas;
        private Bunifu.Framework.UI.BunifuSearchEngine txtBuscar;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        public System.Windows.Forms.Button cmsVerPaciente;
    }
}