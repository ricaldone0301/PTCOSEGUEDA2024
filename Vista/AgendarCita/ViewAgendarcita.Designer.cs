namespace PTC.Vista.AgendarCita
{
    partial class ViewAgendarcita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAgendarcita));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.cbConsultorio = new System.Windows.Forms.ComboBox();
            this.cbProcedimiento = new System.Windows.Forms.ComboBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(591, 126);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(0, 31);
            this.bunifuCustomLabel3.TabIndex = 25;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BorderRadius = 10;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(569, 138);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(676, 588);
            this.bunifuCards1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtHora);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cbPaciente);
            this.panel1.Controls.Add(this.cbConsultorio);
            this.panel1.Controls.Add(this.cbProcedimiento);
            this.panel1.Controls.Add(this.cbDoctor);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Location = new System.Drawing.Point(43, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 492);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(299, 229);
            this.txtHora.MaxLength = 5;
            this.txtHora.Name = "txtHora";
            this.txtHora.ShortcutsEnabled = false;
            this.txtHora.Size = new System.Drawing.Size(102, 22);
            this.txtHora.TabIndex = 38;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(234)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.btnGuardar.Location = new System.Drawing.Point(332, 313);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 50);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbPaciente
            // 
            this.cbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(43, 66);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(503, 24);
            this.cbPaciente.TabIndex = 36;
            // 
            // cbConsultorio
            // 
            this.cbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultorio.FormattingEnabled = true;
            this.cbConsultorio.Location = new System.Drawing.Point(42, 375);
            this.cbConsultorio.Name = "cbConsultorio";
            this.cbConsultorio.Size = new System.Drawing.Size(209, 24);
            this.cbConsultorio.TabIndex = 35;
            this.cbConsultorio.SelectedIndexChanged += new System.EventHandler(this.cbConsultorio_SelectedIndexChanged);
            // 
            // cbProcedimiento
            // 
            this.cbProcedimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProcedimiento.FormattingEnabled = true;
            this.cbProcedimiento.Location = new System.Drawing.Point(42, 161);
            this.cbProcedimiento.Name = "cbProcedimiento";
            this.cbProcedimiento.Size = new System.Drawing.Size(209, 24);
            this.cbProcedimiento.TabIndex = 34;
            this.cbProcedimiento.SelectedIndexChanged += new System.EventHandler(this.cbProcedimiento_SelectedIndexChanged);
            // 
            // cbDoctor
            // 
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(42, 267);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(209, 24);
            this.cbDoctor.TabIndex = 33;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(299, 177);
            this.Fecha.MinDate = new System.DateTime(2024, 8, 12, 0, 0, 0, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(260, 22);
            this.Fecha.TabIndex = 32;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(234)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.btnActualizar.Location = new System.Drawing.Point(332, 388);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(171, 50);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(38, 226);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(92, 25);
            this.bunifuCustomLabel10.TabIndex = 28;
            this.bunifuCustomLabel10.Text = "DOCTOR";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(37, 122);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(170, 25);
            this.bunifuCustomLabel7.TabIndex = 22;
            this.bunifuCustomLabel7.Text = "PROCEDIMIENTO";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(294, 131);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(152, 25);
            this.bunifuCustomLabel8.TabIndex = 20;
            this.bunifuCustomLabel8.Text = "FECHA Y HORA";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(38, 338);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(149, 25);
            this.bunifuCustomLabel6.TabIndex = 18;
            this.bunifuCustomLabel6.Text = "CONSULTORIO";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(37, 38);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(102, 25);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "PACIENTE";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuThinButton26);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 2);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(673, 30);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.Tomato;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuThinButton26.ButtonText = "NUEVA CITA";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.Location = new System.Drawing.Point(0, -2);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(220, 32);
            this.bunifuThinButton26.TabIndex = 10;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewAgendarcita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCards1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "ViewAgendarcita";
            this.Text = "ViewAgendarcita";
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.DateTimePicker Fecha;
        public System.Windows.Forms.ComboBox cbPaciente;
        public System.Windows.Forms.ComboBox cbConsultorio;
        public System.Windows.Forms.ComboBox cbProcedimiento;
        public System.Windows.Forms.ComboBox cbDoctor;
        public System.Windows.Forms.TextBox txtHora;
    }
}