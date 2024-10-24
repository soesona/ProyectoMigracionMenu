namespace ProyectoMigracionMenu
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            Documentoviaje = new GroupBox();
            button8 = new Button();
            button6 = new Button();
            txtAgregar = new TextBox();
            Label3 = new Label();
            Documentoviaje.SuspendLayout();
            SuspendLayout();
            // 
            // Documentoviaje
            // 
            Documentoviaje.BackColor = Color.White;
            Documentoviaje.Controls.Add(button8);
            Documentoviaje.Controls.Add(button6);
            Documentoviaje.Controls.Add(txtAgregar);
            Documentoviaje.Controls.Add(Label3);
            Documentoviaje.Dock = DockStyle.Fill;
            Documentoviaje.Location = new Point(0, 0);
            Documentoviaje.Name = "Documentoviaje";
            Documentoviaje.Size = new Size(331, 224);
            Documentoviaje.TabIndex = 10;
            Documentoviaje.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightCoral;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(209, 173);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(116, 40);
            button8.TabIndex = 27;
            button8.Text = "Cancelar";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGreen;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(12, 173);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(116, 40);
            button6.TabIndex = 26;
            button6.Text = "Agregar";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // txtAgregar
            // 
            txtAgregar.CharacterCasing = CharacterCasing.Upper;
            txtAgregar.Location = new Point(87, 55);
            txtAgregar.MaxLength = 30;
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(232, 23);
            txtAgregar.TabIndex = 25;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(12, 58);
            Label3.Name = "Label3";
            Label3.Size = new Size(69, 15);
            Label3.TabIndex = 0;
            Label3.Text = "Descripción";
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 224);
            Controls.Add(Documentoviaje);
            Name = "frmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            Documentoviaje.ResumeLayout(false);
            Documentoviaje.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Documentoviaje;
        private Label Label3;
        private TextBox txtAgregar;
        private Button button6;
        private Button button8;
    }
}