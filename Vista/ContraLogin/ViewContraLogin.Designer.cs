namespace PTC.Vista.ContraLogin
{
    partial class ViewContraLogin
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
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
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
            this.BtnIngresar.Location = new System.Drawing.Point(318, 364);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(144, 50);
            this.BtnIngresar.TabIndex = 16;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            // 
            // TxtContra
            // 
            this.TxtContra.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.ForeColor = System.Drawing.Color.Gray;
            this.TxtContra.Location = new System.Drawing.Point(200, 290);
            this.TxtContra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContra.MaxLength = 256;
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.ShortcutsEnabled = false;
            this.TxtContra.Size = new System.Drawing.Size(380, 39);
            this.TxtContra.TabIndex = 17;
            this.TxtContra.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.TxtUsuario.Location = new System.Drawing.Point(200, 204);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.MaxLength = 30;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.ShortcutsEnabled = false;
            this.TxtUsuario.Size = new System.Drawing.Size(380, 39);
            this.TxtUsuario.TabIndex = 18;
            this.TxtUsuario.Text = "Usuario";
            // 
            // ViewContraLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "ViewContraLogin";
            this.Text = "ViewContraLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnIngresar;
        public System.Windows.Forms.TextBox TxtContra;
        public System.Windows.Forms.TextBox TxtUsuario;
    }
}