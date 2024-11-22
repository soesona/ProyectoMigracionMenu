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
            Documentoviaje.Margin = new Padding(3, 4, 3, 4);
            Documentoviaje.Name = "Documentoviaje";
            Documentoviaje.Padding = new Padding(3, 4, 3, 4);
            Documentoviaje.Size = new Size(378, 299);
            Documentoviaje.TabIndex = 10;
            Documentoviaje.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightCoral;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(239, 231);
            button8.Name = "button8";
            button8.Size = new Size(133, 53);
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
            button6.Location = new Point(14, 231);
            button6.Name = "button6";
            button6.Size = new Size(133, 53);
            button6.TabIndex = 26;
            button6.Text = "Agregar";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // txtAgregar
            // 
            txtAgregar.CharacterCasing = CharacterCasing.Upper;
            txtAgregar.Location = new Point(99, 73);
            txtAgregar.Margin = new Padding(3, 4, 3, 4);
            txtAgregar.MaxLength = 30;
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(265, 27);
            txtAgregar.TabIndex = 25;
            txtAgregar.TextChanged += txtAgregar_TextChanged;
            txtAgregar.KeyPress += txtAgregar_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(14, 77);
            Label3.Name = "Label3";
            Label3.Size = new Size(87, 20);
            Label3.TabIndex = 0;
            Label3.Text = "Descripción";
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 299);
            Controls.Add(Documentoviaje);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            TextChanged += txtAgregar_TextChanged;
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