namespace PTC.Vista.Login
{
    partial class ViewInicio
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
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.btnOlvido = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnRegistro = new System.Windows.Forms.LinkLabel();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.TxtContra);
            this.panel1.Controls.Add(this.BtnRegistro);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnOlvido);
            this.panel1.Controls.Add(this.BtnIngresar);
            this.panel1.Location = new System.Drawing.Point(199, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 272);
            this.panel1.TabIndex = 0;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(246, 209);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "button1";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnOlvido
            // 
            this.btnOlvido.ActiveLinkColor = System.Drawing.SystemColors.Window;
            this.btnOlvido.AutoSize = true;
            this.btnOlvido.BackColor = System.Drawing.Color.White;
            this.btnOlvido.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.btnOlvido.Location = new System.Drawing.Point(46, 239);
            this.btnOlvido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnOlvido.Name = "btnOlvido";
            this.btnOlvido.Size = new System.Drawing.Size(157, 16);
            this.btnOlvido.TabIndex = 5;
            this.btnOlvido.TabStop = true;
            this.btnOlvido.Text = "Recuperacion por correo";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.linkLabel1.Location = new System.Drawing.Point(32, 198);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperacion por pregunta";
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.ActiveLinkColor = System.Drawing.SystemColors.Window;
            this.BtnRegistro.AutoSize = true;
            this.BtnRegistro.BackColor = System.Drawing.Color.White;
            this.BtnRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.BtnRegistro.Location = new System.Drawing.Point(376, 239);
            this.BtnRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(58, 16);
            this.BtnRegistro.TabIndex = 7;
            this.BtnRegistro.TabStop = true;
            this.BtnRegistro.Text = "Registro";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.TxtUsuario.Location = new System.Drawing.Point(49, 56);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.MaxLength = 30;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.ShortcutsEnabled = false;
            this.TxtUsuario.Size = new System.Drawing.Size(380, 39);
            this.TxtUsuario.TabIndex = 8;
            this.TxtUsuario.Text = "Usuario";
            // 
            // TxtContra
            // 
            this.TxtContra.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.ForeColor = System.Drawing.Color.Gray;
            this.TxtContra.Location = new System.Drawing.Point(49, 136);
            this.TxtContra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContra.MaxLength = 256;
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.ShortcutsEnabled = false;
            this.TxtContra.Size = new System.Drawing.Size(380, 39);
            this.TxtContra.TabIndex = 9;
            this.TxtContra.Text = "Contraseña";
            // 
            // ViewInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ViewInicio";
            this.Text = "ViewInicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BtnIngresar;
        public System.Windows.Forms.LinkLabel btnOlvido;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.LinkLabel BtnRegistro;
        public System.Windows.Forms.TextBox TxtUsuario;
        public System.Windows.Forms.TextBox TxtContra;
    }
}