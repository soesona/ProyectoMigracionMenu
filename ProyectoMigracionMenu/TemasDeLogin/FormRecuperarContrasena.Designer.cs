namespace ProyectoMigracionMenu
{
    partial class FormRecuperarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecuperarContrasena));
            label1 = new Label();
            txtUsuario = new TextBox();
            btnEnviar = new Button();
            BtnClose = new PictureBox();
            BtnMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 155);
            label1.Name = "label1";
            label1.Size = new Size(756, 38);
            label1.TabIndex = 0;
            label1.Text = " Ingrese el usuario de la cuenta a reponer la contraseña: ";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(240, 243);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(269, 27);
            txtUsuario.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(314, 328);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(127, 37);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(741, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(37, 29);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 16;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(690, 12);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(33, 29);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 15;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // FormRecuperarContrasena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClose);
            Controls.Add(BtnMinimizar);
            Controls.Add(btnEnviar);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRecuperarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRecuperarContrasena";
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Button btnEnviar;
        private PictureBox BtnClose;
        private PictureBox BtnMinimizar;
    }
}