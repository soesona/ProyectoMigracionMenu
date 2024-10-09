namespace ProyectoMigracionMenu
{
    partial class FormReportes
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(817, 539);
            button1.Name = "button1";
            button1.Size = new Size(207, 39);
            button1.TabIndex = 0;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(573, 539);
            button2.Name = "button2";
            button2.Size = new Size(207, 39);
            button2.TabIndex = 1;
            button2.Text = "Generar reporte";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 73);
            label1.Name = "label1";
            label1.Size = new Size(407, 40);
            label1.TabIndex = 2;
            label1.Text = "Seleccione los criterios:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(493, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 206);
            panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(301, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 140);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 4;
            label4.Text = "Delegación:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(301, 89);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 85);
            label3.Name = "label3";
            label3.Size = new Size(128, 31);
            label3.TabIndex = 2;
            label3.Text = "Fecha final:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(301, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 25);
            label2.Name = "label2";
            label2.Size = new Size(144, 31);
            label2.TabIndex = 0;
            label2.Text = "Fecha inicial:";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1697, 853);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormReportes";
            Text = "Reportes";
            Load += FormReportes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}