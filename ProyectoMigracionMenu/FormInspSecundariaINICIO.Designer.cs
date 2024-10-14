namespace ProyectoMigracionMenu
{
    partial class FormInspSecundariaINICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInspSecundariaINICIO));
            BtnEntradas = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnEntradas
            // 
            BtnEntradas.BackColor = Color.FromArgb(52, 161, 166);
            BtnEntradas.FlatAppearance.BorderSize = 0;
            BtnEntradas.FlatStyle = FlatStyle.Flat;
            BtnEntradas.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEntradas.Image = (Image)resources.GetObject("BtnEntradas.Image");
            BtnEntradas.Location = new Point(729, 327);
            BtnEntradas.Name = "BtnEntradas";
            BtnEntradas.Size = new Size(190, 121);
            BtnEntradas.TabIndex = 10;
            BtnEntradas.Text = "Entradas";
            BtnEntradas.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnEntradas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 74);
            label1.Name = "label1";
            label1.Size = new Size(853, 40);
            label1.TabIndex = 9;
            label1.Text = "Opciones disponibles para inspección secundaria:";
            // 
            // FormInspSecundariaINICIO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1697, 853);
            Controls.Add(BtnEntradas);
            Controls.Add(label1);
            Name = "FormInspSecundariaINICIO";
            Text = "Inspección secundaria";
            Load += FormInspSecundariaINICIO_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEntradas;
        private Label label1;
    }
}