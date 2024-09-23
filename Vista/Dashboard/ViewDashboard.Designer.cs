namespace PTC.Vista.Dashboard
{
    partial class ViewDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDashboard));
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelPadre = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMaximizar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMinimizar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ok = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDescargas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnServidor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInicio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnProcedimientos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPacientes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOcupaciones = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCerrarSesion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnCitas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.PanelContenedor.SuspendLayout();
            this.PanelPadre.SuspendLayout();
            this.ok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(92, 62);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(688, 31);
            this.bunifuCustomLabel10.TabIndex = 30;
            this.bunifuCustomLabel10.Text = "Bienvenido al Sistema de Citas de Clínica Dental Osegueda";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(465, 238);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(0, 31);
            this.bunifuCustomLabel3.TabIndex = 24;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.PanelContenedor.Controls.Add(this.pictureBox4);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1923, 1019);
            this.PanelContenedor.TabIndex = 32;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // PanelPadre
            // 
            this.PanelPadre.Controls.Add(this.btnCerrar);
            this.PanelPadre.Controls.Add(this.btnMaximizar);
            this.PanelPadre.Controls.Add(this.btnMinimizar);
            this.PanelPadre.Controls.Add(this.ok);
            this.PanelPadre.Controls.Add(this.PanelContenedor);
            this.PanelPadre.Location = new System.Drawing.Point(1, 1);
            this.PanelPadre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(1923, 1019);
            this.PanelPadre.TabIndex = 33;
            // 
            // btnCerrar
            // 
            this.btnCerrar.ActiveImage = null;
            this.btnCerrar.AllowAnimations = true;
            this.btnCerrar.AllowBuffering = false;
            this.btnCerrar.AllowToggling = false;
            this.btnCerrar.AllowZooming = false;
            this.btnCerrar.AllowZoomingOnFocus = false;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.FadeWhenInactive = true;
            this.btnCerrar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.ImageLocation = null;
            this.btnCerrar.ImageMargin = 20;
            this.btnCerrar.ImageSize = new System.Drawing.Size(44, 35);
            this.btnCerrar.ImageZoomSize = new System.Drawing.Size(64, 55);
            this.btnCerrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.InitialImage")));
            this.btnCerrar.Location = new System.Drawing.Point(1815, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0;
            this.btnCerrar.ShowActiveImage = true;
            this.btnCerrar.ShowCursorChanges = true;
            this.btnCerrar.ShowImageBorders = true;
            this.btnCerrar.ShowSizeMarkers = false;
            this.btnCerrar.Size = new System.Drawing.Size(64, 55);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.ToolTipText = "";
            this.btnCerrar.WaitOnLoad = false;
            this.btnCerrar.Zoom = 20;
            this.btnCerrar.ZoomSpeed = 10;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.ActiveImage = null;
            this.btnMaximizar.AllowAnimations = true;
            this.btnMaximizar.AllowBuffering = false;
            this.btnMaximizar.AllowToggling = false;
            this.btnMaximizar.AllowZooming = false;
            this.btnMaximizar.AllowZoomingOnFocus = false;
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaximizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.ErrorImage")));
            this.btnMaximizar.FadeWhenInactive = true;
            this.btnMaximizar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.ImageLocation = null;
            this.btnMaximizar.ImageMargin = 20;
            this.btnMaximizar.ImageSize = new System.Drawing.Size(44, 35);
            this.btnMaximizar.ImageZoomSize = new System.Drawing.Size(64, 55);
            this.btnMaximizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.InitialImage")));
            this.btnMaximizar.Location = new System.Drawing.Point(1745, 16);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Rotation = 0;
            this.btnMaximizar.ShowActiveImage = true;
            this.btnMaximizar.ShowCursorChanges = true;
            this.btnMaximizar.ShowImageBorders = true;
            this.btnMaximizar.ShowSizeMarkers = false;
            this.btnMaximizar.Size = new System.Drawing.Size(64, 55);
            this.btnMaximizar.TabIndex = 10;
            this.btnMaximizar.ToolTipText = "";
            this.btnMaximizar.WaitOnLoad = false;
            this.btnMaximizar.Zoom = 20;
            this.btnMaximizar.ZoomSpeed = 10;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.ActiveImage = null;
            this.btnMinimizar.AllowAnimations = true;
            this.btnMinimizar.AllowBuffering = false;
            this.btnMinimizar.AllowToggling = false;
            this.btnMinimizar.AllowZooming = false;
            this.btnMinimizar.AllowZoomingOnFocus = false;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.ErrorImage")));
            this.btnMinimizar.FadeWhenInactive = true;
            this.btnMinimizar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.ImageLocation = null;
            this.btnMinimizar.ImageMargin = 20;
            this.btnMinimizar.ImageSize = new System.Drawing.Size(44, 35);
            this.btnMinimizar.ImageZoomSize = new System.Drawing.Size(64, 55);
            this.btnMinimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.InitialImage")));
            this.btnMinimizar.Location = new System.Drawing.Point(1675, 16);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0;
            this.btnMinimizar.ShowActiveImage = true;
            this.btnMinimizar.ShowCursorChanges = true;
            this.btnMinimizar.ShowImageBorders = true;
            this.btnMinimizar.ShowSizeMarkers = false;
            this.btnMinimizar.Size = new System.Drawing.Size(64, 55);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.ToolTipText = "";
            this.btnMinimizar.WaitOnLoad = false;
            this.btnMinimizar.Zoom = 20;
            this.btnMinimizar.ZoomSpeed = 10;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Transparent;
            this.ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ok.BackgroundImage")));
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok.Controls.Add(this.btnDescargas);
            this.ok.Controls.Add(this.btnServidor);
            this.ok.Controls.Add(this.btnInicio);
            this.ok.Controls.Add(this.btnProcedimientos);
            this.ok.Controls.Add(this.btnUsuarios);
            this.ok.Controls.Add(this.pictureBox2);
            this.ok.Controls.Add(this.btnPacientes);
            this.ok.Controls.Add(this.btnOcupaciones);
            this.ok.Controls.Add(this.btnCerrarSesion);
            this.ok.Controls.Add(this.lblNombre);
            this.ok.Controls.Add(this.lblUsuario);
            this.ok.Controls.Add(this.pictureBox1);
            this.ok.Controls.Add(this.bunifuSeparator1);
            this.ok.Controls.Add(this.btnCitas);
            this.ok.Dock = System.Windows.Forms.DockStyle.Left;
            this.ok.GradientBottomLeft = System.Drawing.Color.White;
            this.ok.GradientBottomRight = System.Drawing.Color.LightGray;
            this.ok.GradientTopLeft = System.Drawing.Color.White;
            this.ok.GradientTopRight = System.Drawing.Color.White;
            this.ok.Location = new System.Drawing.Point(0, 0);
            this.ok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok.Name = "ok";
            this.ok.Quality = 10;
            this.ok.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ok.Size = new System.Drawing.Size(270, 1019);
            this.ok.TabIndex = 2;
            this.ok.Paint += new System.Windows.Forms.PaintEventHandler(this.ok_Paint);
            // 
            // btnDescargas
            // 
            this.btnDescargas.ActiveBorderThickness = 1;
            this.btnDescargas.ActiveCornerRadius = 20;
            this.btnDescargas.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnDescargas.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnDescargas.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnDescargas.BackColor = System.Drawing.Color.Transparent;
            this.btnDescargas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDescargas.BackgroundImage")));
            this.btnDescargas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDescargas.ButtonText = "MANUALES";
            this.btnDescargas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargas.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDescargas.IdleBorderThickness = 1;
            this.btnDescargas.IdleCornerRadius = 20;
            this.btnDescargas.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDescargas.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnDescargas.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnDescargas.Location = new System.Drawing.Point(73, 512);
            this.btnDescargas.Margin = new System.Windows.Forms.Padding(5);
            this.btnDescargas.Name = "btnDescargas";
            this.btnDescargas.Size = new System.Drawing.Size(129, 34);
            this.btnDescargas.TabIndex = 11;
            this.btnDescargas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnServidor
            // 
            this.btnServidor.ActiveBorderThickness = 1;
            this.btnServidor.ActiveCornerRadius = 20;
            this.btnServidor.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnServidor.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnServidor.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnServidor.BackColor = System.Drawing.Color.Transparent;
            this.btnServidor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServidor.BackgroundImage")));
            this.btnServidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnServidor.ButtonText = "SERVIDOR";
            this.btnServidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServidor.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServidor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnServidor.IdleBorderThickness = 1;
            this.btnServidor.IdleCornerRadius = 20;
            this.btnServidor.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnServidor.IdleForecolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnServidor.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnServidor.Location = new System.Drawing.Point(48, 774);
            this.btnServidor.Margin = new System.Windows.Forms.Padding(5);
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.Size = new System.Drawing.Size(181, 46);
            this.btnServidor.TabIndex = 10;
            this.btnServidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInicio
            // 
            this.btnInicio.ActiveBorderThickness = 1;
            this.btnInicio.ActiveCornerRadius = 20;
            this.btnInicio.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnInicio.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnInicio.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.ButtonText = "INICIO";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnInicio.IdleBorderThickness = 1;
            this.btnInicio.IdleCornerRadius = 20;
            this.btnInicio.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnInicio.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnInicio.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnInicio.Location = new System.Drawing.Point(48, 187);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(181, 34);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcedimientos
            // 
            this.btnProcedimientos.ActiveBorderThickness = 1;
            this.btnProcedimientos.ActiveCornerRadius = 20;
            this.btnProcedimientos.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnProcedimientos.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnProcedimientos.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnProcedimientos.BackColor = System.Drawing.Color.Transparent;
            this.btnProcedimientos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcedimientos.BackgroundImage")));
            this.btnProcedimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProcedimientos.ButtonText = "PROCEDIMIENTOS";
            this.btnProcedimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcedimientos.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcedimientos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnProcedimientos.IdleBorderThickness = 1;
            this.btnProcedimientos.IdleCornerRadius = 20;
            this.btnProcedimientos.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnProcedimientos.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnProcedimientos.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnProcedimientos.Location = new System.Drawing.Point(48, 247);
            this.btnProcedimientos.Margin = new System.Windows.Forms.Padding(5);
            this.btnProcedimientos.Name = "btnProcedimientos";
            this.btnProcedimientos.Size = new System.Drawing.Size(181, 34);
            this.btnProcedimientos.TabIndex = 2;
            this.btnProcedimientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.ActiveBorderThickness = 1;
            this.btnUsuarios.ActiveCornerRadius = 20;
            this.btnUsuarios.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.BackgroundImage")));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsuarios.ButtonText = "USUARIOS";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUsuarios.IdleBorderThickness = 1;
            this.btnUsuarios.IdleCornerRadius = 20;
            this.btnUsuarios.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.IdleForecolor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUsuarios.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Location = new System.Drawing.Point(48, 815);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(181, 46);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 907);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.ActiveBorderThickness = 1;
            this.btnPacientes.ActiveCornerRadius = 20;
            this.btnPacientes.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnPacientes.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnPacientes.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnPacientes.BackColor = System.Drawing.Color.Transparent;
            this.btnPacientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPacientes.BackgroundImage")));
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPacientes.ButtonText = "PACIENTES";
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPacientes.IdleBorderThickness = 1;
            this.btnPacientes.IdleCornerRadius = 20;
            this.btnPacientes.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPacientes.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnPacientes.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnPacientes.Location = new System.Drawing.Point(48, 318);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(5);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(181, 34);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOcupaciones
            // 
            this.btnOcupaciones.ActiveBorderThickness = 1;
            this.btnOcupaciones.ActiveCornerRadius = 20;
            this.btnOcupaciones.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnOcupaciones.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnOcupaciones.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnOcupaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnOcupaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOcupaciones.BackgroundImage")));
            this.btnOcupaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOcupaciones.ButtonText = "OCUPACIONES";
            this.btnOcupaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcupaciones.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcupaciones.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOcupaciones.IdleBorderThickness = 1;
            this.btnOcupaciones.IdleCornerRadius = 20;
            this.btnOcupaciones.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnOcupaciones.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnOcupaciones.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnOcupaciones.Location = new System.Drawing.Point(48, 387);
            this.btnOcupaciones.Margin = new System.Windows.Forms.Padding(5);
            this.btnOcupaciones.Name = "btnOcupaciones";
            this.btnOcupaciones.Size = new System.Drawing.Size(181, 34);
            this.btnOcupaciones.TabIndex = 4;
            this.btnOcupaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.ActiveBorderThickness = 1;
            this.btnCerrarSesion.ActiveCornerRadius = 20;
            this.btnCerrarSesion.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrarSesion.ButtonText = "CERRAR SESIÓN";
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.IdleBorderThickness = 1;
            this.btnCerrarSesion.IdleCornerRadius = 20;
            this.btnCerrarSesion.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Location = new System.Drawing.Point(48, 854);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(181, 46);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNombre.Location = new System.Drawing.Point(94, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Empleado";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUsuario.Location = new System.Drawing.Point(92, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 25);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(49)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-19, 85);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(289, 43);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnCitas
            // 
            this.btnCitas.ActiveBorderThickness = 1;
            this.btnCitas.ActiveCornerRadius = 20;
            this.btnCitas.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnCitas.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnCitas.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnCitas.BackColor = System.Drawing.Color.Transparent;
            this.btnCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCitas.BackgroundImage")));
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCitas.ButtonText = "CITAS";
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCitas.IdleBorderThickness = 1;
            this.btnCitas.IdleCornerRadius = 20;
            this.btnCitas.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCitas.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnCitas.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnCitas.Location = new System.Drawing.Point(73, 458);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(5);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(129, 34);
            this.btnCitas.TabIndex = 5;
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(583, 309);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(815, 312);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(139, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(604, 318);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Tomato;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 5;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 485);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(849, 17);
            this.bunifuSeparator2.TabIndex = 33;
            // 
            // ViewDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1020);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "ViewDashboard";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewDashboard_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelPadre.ResumeLayout(false);
            this.ok.ResumeLayout(false);
            this.ok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuGradientPanel ok;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnCerrarSesion;
        public Bunifu.Framework.UI.BunifuThinButton2 btnPacientes;
        public Bunifu.Framework.UI.BunifuThinButton2 btnOcupaciones;
        public System.Windows.Forms.Panel PanelContenedor;
        public System.Windows.Forms.Panel PanelPadre;
        public Bunifu.Framework.UI.BunifuThinButton2 btnUsuarios;
        public Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        public Bunifu.Framework.UI.BunifuCustomLabel lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        public Bunifu.Framework.UI.BunifuThinButton2 btnInicio;
        public Bunifu.Framework.UI.BunifuThinButton2 btnCitas;
        public Bunifu.Framework.UI.BunifuThinButton2 btnProcedimientos;
        public Bunifu.UI.WinForms.BunifuImageButton btnMinimizar;
        public Bunifu.UI.WinForms.BunifuImageButton btnCerrar;
        public Bunifu.UI.WinForms.BunifuImageButton btnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox4;
        public Bunifu.Framework.UI.BunifuThinButton2 btnServidor;
        public Bunifu.Framework.UI.BunifuThinButton2 btnDescargas;
    }
}