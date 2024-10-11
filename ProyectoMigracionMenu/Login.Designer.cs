namespace ProyectoMigracionMenu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            linkpass = new LinkLabel();
            btnlogin = new Button();
            label1 = new Label();
            txtpass = new TextBox();
            txtuser = new TextBox();
            label2 = new Label();
            BtnClose = new PictureBox();
            BtnMinimizar = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(141, 188, 190);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 508);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // linkpass
            // 
            linkpass.ActiveLinkColor = Color.FromArgb(85, 187, 190);
            linkpass.AutoSize = true;
            linkpass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkpass.ForeColor = SystemColors.ActiveCaptionText;
            linkpass.LinkColor = Color.DarkGray;
            linkpass.Location = new Point(594, 451);
            linkpass.Margin = new Padding(4, 0, 4, 0);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(190, 21);
            linkpass.TabIndex = 5;
            linkpass.TabStop = true;
            linkpass.Text = "Contraseña olvidada";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.AliceBlue;
            btnlogin.FlatAppearance.BorderColor = Color.DarkCyan;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.Black;
            btnlogin.Location = new Point(413, 384);
            btnlogin.Margin = new Padding(4, 5, 4, 5);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(544, 48);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "INGRESAR";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(553, -86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 40);
            label1.TabIndex = 9;
            label1.Text = "LOGIN";
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.AliceBlue;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.DimGray;
            txtpass.Location = new Point(435, 252);
            txtpass.Margin = new Padding(4, 5, 4, 5);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(544, 25);
            txtpass.TabIndex = 7;
            txtpass.Text = "Contraseña";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.AliceBlue;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.DimGray;
            txtuser.Location = new Point(436, 160);
            txtuser.Margin = new Padding(4, 5, 4, 5);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(544, 25);
            txtuser.TabIndex = 6;
            txtuser.Text = "Usuario";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(594, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 40);
            label2.TabIndex = 10;
            label2.Text = "LOGIN";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(981, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(37, 29);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 12;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(930, 12);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(33, 29);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 11;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(390, 153);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 36);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(413, 272);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(527, 16);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(392, 241);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 36);
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(413, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(527, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1040, 508);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(BtnClose);
            Controls.Add(BtnMinimizar);
            Controls.Add(label2);
            Controls.Add(linkpass);
            Controls.Add(btnlogin);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += Login_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private LinkLabel linkpass;
        private Button btnlogin;
        private Label label1;
        private TextBox txtpass;
        private TextBox txtuser;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox BtnClose;
        private PictureBox BtnMinimizar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
    }
}