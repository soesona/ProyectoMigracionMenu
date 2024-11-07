namespace ProyectoMigracionMenu.TemasDeLogin
{
    partial class FormVerificarToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerificarToken));
            label1 = new Label();
            txtToken = new TextBox();
            label2 = new Label();
            txtNuevaContrasena = new TextBox();
            txtConfirmarContrasena = new TextBox();
            label3 = new Label();
            btnActualizarContrasena = new Button();
            BtnClose = new PictureBox();
            BtnMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 63);
            label1.Name = "label1";
            label1.Size = new Size(359, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el token que recibió en su correo";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(168, 106);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(491, 27);
            txtToken.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 173);
            label2.Name = "label2";
            label2.Size = new Size(233, 23);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su nueva contraseña";
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.Location = new Point(284, 214);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.PasswordChar = '*';
            txtNuevaContrasena.Size = new Size(240, 27);
            txtNuevaContrasena.TabIndex = 3;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(284, 308);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(240, 27);
            txtConfirmarContrasena.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(311, 272);
            label3.Name = "label3";
            label3.Size = new Size(183, 23);
            label3.TabIndex = 5;
            label3.Text = "Confirmar contraseña";
            // 
            // btnActualizarContrasena
            // 
            btnActualizarContrasena.Location = new Point(359, 369);
            btnActualizarContrasena.Name = "btnActualizarContrasena";
            btnActualizarContrasena.Size = new Size(94, 29);
            btnActualizarContrasena.TabIndex = 6;
            btnActualizarContrasena.Text = "Actualizar";
            btnActualizarContrasena.UseVisualStyleBackColor = true;
            btnActualizarContrasena.Click += btnActualizarContrasena_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(751, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(37, 29);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 14;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(700, 12);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(33, 29);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 13;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // FormVerificarToken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClose);
            Controls.Add(BtnMinimizar);
            Controls.Add(btnActualizarContrasena);
            Controls.Add(label3);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(label2);
            Controls.Add(txtToken);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerificarToken";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerificarToken";
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtToken;
        private Label label2;
        private TextBox txtNuevaContrasena;
        private TextBox txtConfirmarContrasena;
        private Label label3;
        private Button btnActualizarContrasena;
        private PictureBox BtnClose;
        private PictureBox BtnMinimizar;
    }
}