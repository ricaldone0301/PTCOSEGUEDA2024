namespace PTC.Vista.Conexion
{
    partial class ViewConexion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConfigurarValores = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbConf = new System.Windows.Forms.TabPage();
            this.panelAuth = new System.Windows.Forms.Panel();
            this.txtSqlPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSqlAuth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdDeshabilitarWindows = new System.Windows.Forms.RadioButton();
            this.rdHabilitarWindows = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabConfigurarValores.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbConf.SuspendLayout();
            this.panelAuth.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConfigurarValores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // tabConfigurarValores
            // 
            this.tabConfigurarValores.Controls.Add(this.panel4);
            this.tabConfigurarValores.Controls.Add(this.panel3);
            this.tabConfigurarValores.Controls.Add(this.panel2);
            this.tabConfigurarValores.Location = new System.Drawing.Point(4, 25);
            this.tabConfigurarValores.Margin = new System.Windows.Forms.Padding(4);
            this.tabConfigurarValores.Name = "tabConfigurarValores";
            this.tabConfigurarValores.Padding = new System.Windows.Forms.Padding(4);
            this.tabConfigurarValores.Size = new System.Drawing.Size(792, 421);
            this.tabConfigurarValores.TabIndex = 1;
            this.tabConfigurarValores.Text = "Valores de conexión";
            this.tabConfigurarValores.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnGuardar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 354);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 63);
            this.panel4.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(467, 4);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(201, 54);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar configuración";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 169);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 248);
            this.panel3.TabIndex = 9;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbConf);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(784, 248);
            this.tabControl2.TabIndex = 0;
            // 
            // tbConf
            // 
            this.tbConf.BackColor = System.Drawing.SystemColors.Control;
            this.tbConf.Controls.Add(this.panelAuth);
            this.tbConf.Controls.Add(this.rdDeshabilitarWindows);
            this.tbConf.Controls.Add(this.rdHabilitarWindows);
            this.tbConf.Controls.Add(this.label3);
            this.tbConf.Location = new System.Drawing.Point(4, 25);
            this.tbConf.Margin = new System.Windows.Forms.Padding(4);
            this.tbConf.Name = "tbConf";
            this.tbConf.Padding = new System.Windows.Forms.Padding(4);
            this.tbConf.Size = new System.Drawing.Size(776, 219);
            this.tbConf.TabIndex = 0;
            this.tbConf.Text = "Configuración local";
            // 
            // panelAuth
            // 
            this.panelAuth.Controls.Add(this.txtSqlPass);
            this.panelAuth.Controls.Add(this.label7);
            this.panelAuth.Controls.Add(this.txtSqlAuth);
            this.panelAuth.Controls.Add(this.label6);
            this.panelAuth.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAuth.Location = new System.Drawing.Point(456, 4);
            this.panelAuth.Margin = new System.Windows.Forms.Padding(4);
            this.panelAuth.Name = "panelAuth";
            this.panelAuth.Size = new System.Drawing.Size(316, 211);
            this.panelAuth.TabIndex = 11;
            // 
            // txtSqlPass
            // 
            this.txtSqlPass.Location = new System.Drawing.Point(21, 97);
            this.txtSqlPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtSqlPass.Name = "txtSqlPass";
            this.txtSqlPass.Size = new System.Drawing.Size(271, 22);
            this.txtSqlPass.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password Authentication";
            // 
            // txtSqlAuth
            // 
            this.txtSqlAuth.Location = new System.Drawing.Point(21, 42);
            this.txtSqlAuth.Margin = new System.Windows.Forms.Padding(4);
            this.txtSqlAuth.Name = "txtSqlAuth";
            this.txtSqlAuth.Size = new System.Drawing.Size(271, 22);
            this.txtSqlAuth.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "SQL Authentication";
            // 
            // rdDeshabilitarWindows
            // 
            this.rdDeshabilitarWindows.AutoSize = true;
            this.rdDeshabilitarWindows.Location = new System.Drawing.Point(17, 85);
            this.rdDeshabilitarWindows.Margin = new System.Windows.Forms.Padding(4);
            this.rdDeshabilitarWindows.Name = "rdDeshabilitarWindows";
            this.rdDeshabilitarWindows.Size = new System.Drawing.Size(304, 20);
            this.rdDeshabilitarWindows.TabIndex = 10;
            this.rdDeshabilitarWindows.Text = "Desahibilitar seguridad integrada de Windows";
            this.rdDeshabilitarWindows.UseVisualStyleBackColor = true;
            // 
            // rdHabilitarWindows
            // 
            this.rdHabilitarWindows.AutoSize = true;
            this.rdHabilitarWindows.Checked = true;
            this.rdHabilitarWindows.Location = new System.Drawing.Point(17, 57);
            this.rdHabilitarWindows.Margin = new System.Windows.Forms.Padding(4);
            this.rdHabilitarWindows.Name = "rdHabilitarWindows";
            this.rdHabilitarWindows.Size = new System.Drawing.Size(279, 20);
            this.rdHabilitarWindows.TabIndex = 10;
            this.rdHabilitarWindows.TabStop = true;
            this.rdHabilitarWindows.Text = "Habilitar seguridad integrada de Windows";
            this.rdHabilitarWindows.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seguridad integrada de Windows:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtDatabase);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtServer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 165);
            this.panel2.TabIndex = 8;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(23, 112);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(656, 26);
            this.txtDatabase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Base de datos:";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(23, 47);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.MaxLength = 40;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(656, 26);
            this.txtServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Servidor URL:";
            // 
            // ViewConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ViewConexion";
            this.Text = "ViewConexion";
            this.tabControl1.ResumeLayout(false);
            this.tabConfigurarValores.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tbConf.ResumeLayout(false);
            this.tbConf.PerformLayout();
            this.panelAuth.ResumeLayout(false);
            this.panelAuth.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConfigurarValores;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbConf;
        public System.Windows.Forms.Panel panelAuth;
        public System.Windows.Forms.TextBox txtSqlPass;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtSqlAuth;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton rdDeshabilitarWindows;
        public System.Windows.Forms.RadioButton rdHabilitarWindows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
    }
}