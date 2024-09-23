namespace PTC.Vista.Descargas
{
    partial class ViewDescargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDescargas));
            this.pbprogreso = new System.Windows.Forms.ProgressBar();
            this.txturl = new System.Windows.Forms.TextBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.lbprogreso = new System.Windows.Forms.Label();
            this.btnInicio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // pbprogreso
            // 
            this.pbprogreso.Location = new System.Drawing.Point(753, 388);
            this.pbprogreso.Name = "pbprogreso";
            this.pbprogreso.Size = new System.Drawing.Size(605, 87);
            this.pbprogreso.TabIndex = 0;
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(697, 326);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(539, 22);
            this.txturl.TabIndex = 1;
            this.txturl.Text = resources.GetString("txturl.Text");
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(1254, 319);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(104, 36);
            this.btnDescargar.TabIndex = 2;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // lbprogreso
            // 
            this.lbprogreso.AutoSize = true;
            this.lbprogreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprogreso.Location = new System.Drawing.Point(671, 419);
            this.lbprogreso.Name = "lbprogreso";
            this.lbprogreso.Size = new System.Drawing.Size(48, 29);
            this.lbprogreso.TabIndex = 3;
            this.lbprogreso.Text = "0%";
            // 
            // btnInicio
            // 
            this.btnInicio.ActiveBorderThickness = 1;
            this.btnInicio.ActiveCornerRadius = 20;
            this.btnInicio.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnInicio.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnInicio.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor = System.Drawing.Color.White;
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.ButtonText = "DESCARGUE LOS MANUALES TECNICOS Y DE USUARIO";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnInicio.IdleBorderThickness = 1;
            this.btnInicio.IdleCornerRadius = 20;
            this.btnInicio.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnInicio.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnInicio.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnInicio.Location = new System.Drawing.Point(624, 238);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(791, 34);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewDescargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lbprogreso);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.pbprogreso);
            this.Name = "ViewDescargas";
            this.Text = "ViewDescargas";
            this.Load += new System.EventHandler(this.ViewDescargas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ProgressBar pbprogreso;
        public System.Windows.Forms.Label lbprogreso;
        public System.Windows.Forms.TextBox txturl;
        public System.Windows.Forms.Button btnDescargar;
        public Bunifu.Framework.UI.BunifuThinButton2 btnInicio;
    }
}