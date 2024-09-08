namespace PTC.Vista.Cita
{
    partial class ViewCitas
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
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmsVerPaciente = new System.Windows.Forms.Button();
            this.cmsEliminar = new System.Windows.Forms.Button();
            this.cmsActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCitas
            // 
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(468, 232);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(1070, 589);
            this.dgvCitas.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleName = "btnBuscar";
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(234)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 10;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.Location = new System.Drawing.Point(718, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 35);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(468, 140);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(244, 28);
            this.txtBuscar.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.cmsVerPaciente);
            this.panel1.Controls.Add(this.cmsEliminar);
            this.panel1.Controls.Add(this.cmsActualizar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(468, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 51);
            this.panel1.TabIndex = 15;
            // 
            // cmsVerPaciente
            // 
            this.cmsVerPaciente.AccessibleName = "cmsVerPaciente";
            this.cmsVerPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsVerPaciente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmsVerPaciente.Location = new System.Drawing.Point(692, 9);
            this.cmsVerPaciente.Name = "cmsVerPaciente";
            this.cmsVerPaciente.Size = new System.Drawing.Size(75, 35);
            this.cmsVerPaciente.TabIndex = 4;
            this.cmsVerPaciente.Text = "Ver";
            this.cmsVerPaciente.UseVisualStyleBackColor = true;
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.AccessibleName = "cmsEliminar";
            this.cmsEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEliminar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmsEliminar.Location = new System.Drawing.Point(883, 9);
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(94, 35);
            this.cmsEliminar.TabIndex = 2;
            this.cmsEliminar.Text = "Eliminar";
            this.cmsEliminar.UseVisualStyleBackColor = true;
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.AccessibleName = "cmsActualizar";
            this.cmsActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsActualizar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmsActualizar.Location = new System.Drawing.Point(773, 9);
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.Size = new System.Drawing.Size(104, 35);
            this.cmsActualizar.TabIndex = 1;
            this.cmsActualizar.Text = "Actualizar";
            this.cmsActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AccessibleName = "btnNuevo";
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.Location = new System.Drawing.Point(983, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // ViewCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCitas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "ViewCitas";
            this.Text = "ViewCitas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvCitas;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button cmsVerPaciente;
        public System.Windows.Forms.Button cmsEliminar;
        public System.Windows.Forms.Button cmsActualizar;
        public System.Windows.Forms.Button btnNuevo;
    }
}