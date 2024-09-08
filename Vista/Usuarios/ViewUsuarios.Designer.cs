namespace PTC.Vista.Doctores
{
    partial class ViewUsuarios
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmsVerPaciente = new System.Windows.Forms.Button();
            this.cmsEliminar = new System.Windows.Forms.Button();
            this.cmsActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvPersonas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPersonas.Location = new System.Drawing.Point(468, 222);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersWidth = 51;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(1074, 589);
            this.dgvPersonas.TabIndex = 1;
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.cmsVerPaciente);
            this.panel1.Controls.Add(this.cmsEliminar);
            this.panel1.Controls.Add(this.cmsActualizar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(468, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 51);
            this.panel1.TabIndex = 2;
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
            this.cmsVerPaciente.Click += new System.EventHandler(this.cmsVerPaciente_Click);
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
            this.btnNuevo.Size = new System.Drawing.Size(88, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(468, 143);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(248, 28);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleName = "btnBuscar";
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(234)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 10;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.Location = new System.Drawing.Point(718, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // ViewUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "ViewUsuarios";
            this.Text = "ViewUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button cmsEliminar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Button cmsVerPaciente;
        public System.Windows.Forms.Button cmsActualizar;
    }
}