namespace PTC.Vista.Login
{
    partial class ViewLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogin));
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ContraHide = new System.Windows.Forms.Button();
            this.ContraVisible = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIngresar.Location = new System.Drawing.Point(202, 338);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(108, 41);
            this.BtnIngresar.TabIndex = 15;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 126);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // ContraHide
            // 
            this.ContraHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContraHide.BackgroundImage")));
            this.ContraHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContraHide.Location = new System.Drawing.Point(708, 368);
            this.ContraHide.Name = "ContraHide";
            this.ContraHide.Size = new System.Drawing.Size(30, 29);
            this.ContraHide.TabIndex = 21;
            this.ContraHide.UseVisualStyleBackColor = true;
            // 
            // ContraVisible
            // 
            this.ContraVisible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContraVisible.BackgroundImage")));
            this.ContraVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContraVisible.Location = new System.Drawing.Point(708, 368);
            this.ContraVisible.Name = "ContraVisible";
            this.ContraVisible.Size = new System.Drawing.Size(30, 29);
            this.ContraVisible.TabIndex = 20;
            this.ContraVisible.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Location = new System.Drawing.Point(478, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 29);
            this.BtnExit.TabIndex = 19;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.TxtUsuario.Location = new System.Drawing.Point(452, 303);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(286, 33);
            this.TxtUsuario.TabIndex = 13;
            this.TxtUsuario.Text = "Usuario";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.linkLabel1.Location = new System.Drawing.Point(449, 415);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvido su contraseña?";
            // 
            // TxtContra
            // 
            this.TxtContra.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.ForeColor = System.Drawing.Color.Gray;
            this.TxtContra.Location = new System.Drawing.Point(452, 368);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.Size = new System.Drawing.Size(286, 33);
            this.TxtContra.TabIndex = 14;
            this.TxtContra.Text = "Contraseña";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.BtnExit);
            this.bunifuGradientPanel1.Controls.Add(this.BtnIngresar);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(352, 122);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(508, 394);
            this.bunifuGradientPanel1.TabIndex = 22;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.SystemColors.Window;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.linkLabel2.Location = new System.Drawing.Point(326, 293);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(60, 13);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Registrarse";
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.ControlBox = false;
            this.Controls.Add(this.ContraHide);
            this.Controls.Add(this.ContraVisible);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.MaximumSize = new System.Drawing.Size(1280, 718);
            this.MinimumSize = new System.Drawing.Size(1280, 718);
            this.Name = "ViewLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button BtnExit;
        public System.Windows.Forms.Button ContraVisible;
        public System.Windows.Forms.Button ContraHide;
        public System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox TxtContra;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}