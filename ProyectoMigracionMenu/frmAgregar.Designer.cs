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
            Label3 = new Label();
            txtAgregar = new TextBox();
            button6 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(27, 96);
            Label3.Name = "Label3";
            Label3.Size = new Size(90, 20);
            Label3.TabIndex = 0;
            Label3.Text = "Descripción:";
            // 
            // txtAgregar
            // 
            txtAgregar.CharacterCasing = CharacterCasing.Upper;
            txtAgregar.Location = new Point(132, 89);
            txtAgregar.Margin = new Padding(3, 4, 3, 4);
            txtAgregar.MaxLength = 30;
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(265, 27);
            txtAgregar.TabIndex = 25;
            txtAgregar.TextChanged += txtAgregar_TextChanged;
            txtAgregar.KeyPress += txtAgregar_KeyPress;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGreen;
            button6.FlatAppearance.BorderSize = 0;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(27, 183);
            button6.Name = "button6";
            button6.Size = new Size(133, 53);
            button6.TabIndex = 26;
            button6.Text = "Agregar";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightCoral;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(264, 183);
            button8.Name = "button8";
            button8.Size = new Size(133, 53);
            button8.TabIndex = 27;
            button8.Text = "Cancelar";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(424, 271);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(Label3);
            Controls.Add(txtAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAgregar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            TextChanged += txtAgregar_TextChanged;
            MouseDown += frmAgregar_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label3;
        private TextBox txtAgregar;
        private Button button6;
        private Button button8;
    }
}