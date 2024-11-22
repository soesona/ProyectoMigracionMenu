namespace ProyectoMigracionMenu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            BtnInspeccionPrimaria = new Button();
            MenuVertical = new Panel();
            panel1 = new Panel();
            lblDelegacion = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BtnReportes = new Button();
            BtnDashboard = new Button();
            BtnCerrarSesion = new Button();
            BtnInspeccionSecundaria = new Button();
            pictureBox2 = new PictureBox();
            BarraMain = new Panel();
            lblRol = new Label();
            lblUsuario = new Label();
            label4 = new Label();
            label3 = new Label();
            lblTitulo = new Label();
            BtnClose = new PictureBox();
            BtnMinimizar = new PictureBox();
            BtnRestaurar = new PictureBox();
            BtnMaximizar = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BarraMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // BtnInspeccionPrimaria
            // 
            BtnInspeccionPrimaria.BackColor = Color.FromArgb(169, 209, 212);
            BtnInspeccionPrimaria.FlatAppearance.BorderSize = 0;
            BtnInspeccionPrimaria.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 161, 166);
            BtnInspeccionPrimaria.FlatStyle = FlatStyle.Flat;
            BtnInspeccionPrimaria.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnInspeccionPrimaria.ForeColor = Color.Black;
            BtnInspeccionPrimaria.Image = (Image)resources.GetObject("BtnInspeccionPrimaria.Image");
            BtnInspeccionPrimaria.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInspeccionPrimaria.Location = new Point(0, 312);
            BtnInspeccionPrimaria.Margin = new Padding(4, 5, 4, 5);
            BtnInspeccionPrimaria.Name = "BtnInspeccionPrimaria";
            BtnInspeccionPrimaria.Padding = new Padding(5);
            BtnInspeccionPrimaria.Size = new Size(293, 64);
            BtnInspeccionPrimaria.TabIndex = 3;
            BtnInspeccionPrimaria.Text = "Inspección primaria";
            BtnInspeccionPrimaria.TextAlign = ContentAlignment.MiddleLeft;
            BtnInspeccionPrimaria.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnInspeccionPrimaria.UseVisualStyleBackColor = false;
            BtnInspeccionPrimaria.Click += BtnInspeccionPrimaria_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(169, 209, 212);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(BtnReportes);
            MenuVertical.Controls.Add(BtnDashboard);
            MenuVertical.Controls.Add(BtnCerrarSesion);
            MenuVertical.Controls.Add(BtnInspeccionSecundaria);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Controls.Add(BtnInspeccionPrimaria);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 5, 4, 5);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(293, 900);
            MenuVertical.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDelegacion);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 850);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 50);
            panel1.TabIndex = 20;
            // 
            // lblDelegacion
            // 
            lblDelegacion.AutoSize = true;
            lblDelegacion.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDelegacion.Location = new Point(140, 16);
            lblDelegacion.Name = "lblDelegacion";
            lblDelegacion.Size = new Size(25, 21);
            lblDelegacion.TabIndex = 21;
            lblDelegacion.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 20;
            label1.Text = "Estación:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // BtnReportes
            // 
            BtnReportes.BackColor = Color.FromArgb(169, 209, 212);
            BtnReportes.FlatAppearance.BorderSize = 0;
            BtnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 161, 166);
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReportes.ForeColor = Color.Black;
            BtnReportes.Image = (Image)resources.GetObject("BtnReportes.Image");
            BtnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReportes.Location = new Point(0, 440);
            BtnReportes.Margin = new Padding(4, 5, 4, 5);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Padding = new Padding(5);
            BtnReportes.Size = new Size(293, 64);
            BtnReportes.TabIndex = 7;
            BtnReportes.Text = "Reportes";
            BtnReportes.TextAlign = ContentAlignment.MiddleLeft;
            BtnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReportes.UseVisualStyleBackColor = false;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.BackColor = Color.FromArgb(169, 209, 212);
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 161, 166);
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDashboard.ForeColor = Color.Black;
            BtnDashboard.Image = (Image)resources.GetObject("BtnDashboard.Image");
            BtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.Location = new Point(0, 248);
            BtnDashboard.Margin = new Padding(4, 5, 4, 5);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Padding = new Padding(5);
            BtnDashboard.Size = new Size(293, 64);
            BtnDashboard.TabIndex = 18;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDashboard.UseVisualStyleBackColor = false;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.BackColor = Color.FromArgb(169, 209, 212);
            BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            BtnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 161, 166);
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCerrarSesion.ForeColor = Color.Black;
            BtnCerrarSesion.Image = (Image)resources.GetObject("BtnCerrarSesion.Image");
            BtnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrarSesion.Location = new Point(0, 674);
            BtnCerrarSesion.Margin = new Padding(4, 5, 4, 5);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Padding = new Padding(5);
            BtnCerrarSesion.Size = new Size(293, 64);
            BtnCerrarSesion.TabIndex = 17;
            BtnCerrarSesion.Text = "Cerrar sesión ";
            BtnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            BtnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // BtnInspeccionSecundaria
            // 
            BtnInspeccionSecundaria.BackColor = Color.FromArgb(169, 209, 212);
            BtnInspeccionSecundaria.FlatAppearance.BorderSize = 0;
            BtnInspeccionSecundaria.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 161, 166);
            BtnInspeccionSecundaria.FlatStyle = FlatStyle.Flat;
            BtnInspeccionSecundaria.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnInspeccionSecundaria.ForeColor = Color.Black;
            BtnInspeccionSecundaria.Image = (Image)resources.GetObject("BtnInspeccionSecundaria.Image");
            BtnInspeccionSecundaria.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInspeccionSecundaria.Location = new Point(0, 376);
            BtnInspeccionSecundaria.Margin = new Padding(4, 5, 4, 5);
            BtnInspeccionSecundaria.Name = "BtnInspeccionSecundaria";
            BtnInspeccionSecundaria.Padding = new Padding(5);
            BtnInspeccionSecundaria.Size = new Size(293, 64);
            BtnInspeccionSecundaria.TabIndex = 5;
            BtnInspeccionSecundaria.Text = "Inspección secundaria";
            BtnInspeccionSecundaria.TextAlign = ContentAlignment.MiddleLeft;
            BtnInspeccionSecundaria.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnInspeccionSecundaria.UseVisualStyleBackColor = false;
            BtnInspeccionSecundaria.Click += BtnInspeccionSecundaria_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 26);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 192);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // BarraMain
            // 
            BarraMain.BackColor = Color.FromArgb(169, 209, 212);
            BarraMain.Controls.Add(lblRol);
            BarraMain.Controls.Add(lblUsuario);
            BarraMain.Controls.Add(label4);
            BarraMain.Controls.Add(label3);
            BarraMain.Controls.Add(lblTitulo);
            BarraMain.Controls.Add(BtnClose);
            BarraMain.Controls.Add(BtnMinimizar);
            BarraMain.Controls.Add(BtnRestaurar);
            BarraMain.Controls.Add(BtnMaximizar);
            BarraMain.Dock = DockStyle.Top;
            BarraMain.Location = new Point(293, 0);
            BarraMain.Name = "BarraMain";
            BarraMain.Size = new Size(1422, 110);
            BarraMain.TabIndex = 3;
            BarraMain.MouseDown += BarraMain_MouseDown;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Century Gothic", 12F);
            lblRol.Location = new Point(368, 72);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(25, 23);
            lblRol.TabIndex = 24;
            lblRol.Text = "...";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 12F);
            lblUsuario.Location = new Point(100, 72);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(25, 23);
            lblUsuario.TabIndex = 23;
            lblUsuario.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(316, 72);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 22;
            label4.Text = "Rol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(7, 72);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 21;
            label3.Text = "Usuario:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 46);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Dashboard";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(1358, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(42, 44);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 5;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(1213, 12);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(42, 44);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 0;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.Cursor = Cursors.Hand;
            BtnRestaurar.Image = (Image)resources.GetObject("BtnRestaurar.Image");
            BtnRestaurar.Location = new Point(1284, 12);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(42, 44);
            BtnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnRestaurar.TabIndex = 4;
            BtnRestaurar.TabStop = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // BtnMaximizar
            // 
            BtnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximizar.Cursor = Cursors.Hand;
            BtnMaximizar.Image = (Image)resources.GetObject("BtnMaximizar.Image");
            BtnMaximizar.Location = new Point(1284, 12);
            BtnMaximizar.Name = "BtnMaximizar";
            BtnMaximizar.Size = new Size(42, 44);
            BtnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMaximizar.TabIndex = 6;
            BtnMaximizar.TabStop = false;
            BtnMaximizar.Click += BtnMaximizar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Controls.Add(BarraMain);
            panelContenedor.Controls.Add(MenuVertical);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(4, 5, 4, 5);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1715, 900);
            panelContenedor.TabIndex = 20;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 900);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            MenuVertical.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            BarraMain.ResumeLayout(false);
            BarraMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).EndInit();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnInspeccionPrimaria;
        private Panel MenuVertical;
        private Button BtnReportes;
        private Button BtnDashboard;
        private Button BtnCerrarSesion;
        private Button BtnInspeccionSecundaria;
        private PictureBox pictureBox2;
        private Panel BarraMain;
        private Label lblTitulo;
        private PictureBox BtnClose;
        private PictureBox BtnMinimizar;
        private PictureBox BtnMaximizar;
        private PictureBox BtnRestaurar;
        private Panel panelContenedor;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblDelegacion;
        private Label lblRol;
        private Label lblUsuario;
        private Label label4;
        private Label label3;
    }
}