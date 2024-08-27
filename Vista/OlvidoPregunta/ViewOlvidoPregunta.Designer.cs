namespace PTC.Vista.OlvidoPregunta
{
    partial class ViewOlvidoPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOlvidoPregunta));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnviar1 = new System.Windows.Forms.Button();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbPregunta = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.btnEnviar1);
            this.panel2.Controls.Add(this.txtConfirm);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Location = new System.Drawing.Point(942, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 571);
            this.panel2.TabIndex = 43;
            // 
            // btnEnviar1
            // 
            this.btnEnviar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(234)))));
            this.btnEnviar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar1.FlatAppearance.BorderSize = 0;
            this.btnEnviar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.btnEnviar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.btnEnviar1.Location = new System.Drawing.Point(134, 316);
            this.btnEnviar1.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar1.Name = "btnEnviar1";
            this.btnEnviar1.Size = new System.Drawing.Size(131, 46);
            this.btnEnviar1.TabIndex = 37;
            this.btnEnviar1.Text = "ENVIAR";
            this.btnEnviar1.UseVisualStyleBackColor = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(90, 272);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.ShortcutsEnabled = false;
            this.txtConfirm.Size = new System.Drawing.Size(209, 22);
            this.txtConfirm.TabIndex = 38;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(71, 232);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(254, 25);
            this.bunifuCustomLabel2.TabIndex = 37;
            this.bunifuCustomLabel2.Text = "CODIGO DE VERIFICACION";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(368, 129);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(947, 569);
            this.bunifuGradientPanel1.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbPregunta);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.txtRespuesta);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Location = new System.Drawing.Point(-31, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 569);
            this.panel1.TabIndex = 20;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(210, 389);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.ShortcutsEnabled = false;
            this.txtContrasena.Size = new System.Drawing.Size(209, 22);
            this.txtContrasena.TabIndex = 35;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(205, 351);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(213, 25);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "NUEVA CONTRASENA";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(203)))), ((int)(((byte)(234)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.btnEnviar.Location = new System.Drawing.Point(254, 475);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(131, 46);
            this.btnEnviar.TabIndex = 32;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(205, 105);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(115, 25);
            this.bunifuCustomLabel6.TabIndex = 18;
            this.bunifuCustomLabel6.Text = "PREGUNTA";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(210, 218);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ShortcutsEnabled = false;
            this.txtRespuesta.Size = new System.Drawing.Size(209, 22);
            this.txtRespuesta.TabIndex = 37;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(205, 180);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(118, 25);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "RESPUESTA";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(205, 262);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(71, 25);
            this.bunifuCustomLabel4.TabIndex = 38;
            this.bunifuCustomLabel4.Text = "EMAIL";
            // 
            // cbPregunta
            // 
            this.cbPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPregunta.FormattingEnabled = true;
            this.cbPregunta.Location = new System.Drawing.Point(210, 133);
            this.cbPregunta.Name = "cbPregunta";
            this.cbPregunta.Size = new System.Drawing.Size(254, 24);
            this.cbPregunta.TabIndex = 40;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(210, 300);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(209, 22);
            this.txtEmail.TabIndex = 39;
            // 
            // ViewOlvidoPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "ViewOlvidoPregunta";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnEnviar1;
        public System.Windows.Forms.TextBox txtConfirm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtContrasena;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        public System.Windows.Forms.Button btnEnviar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public System.Windows.Forms.TextBox txtRespuesta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public System.Windows.Forms.ComboBox cbPregunta;
        public System.Windows.Forms.TextBox txtEmail;
    }
}