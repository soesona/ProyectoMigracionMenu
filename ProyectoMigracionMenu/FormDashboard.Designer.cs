namespace ProyectoMigracionMenu
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label15 = new Label();
            panelAno = new Panel();
            label3 = new Label();
            PersonasAno = new Label();
            panelMes = new Panel();
            label2 = new Label();
            PersonasMes = new Label();
            panelHoy = new Panel();
            label1 = new Label();
            PersonasHoy = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelAno.SuspendLayout();
            panelMes.SuspendLayout();
            panelHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(269, 286);
            label15.Name = "label15";
            label15.Size = new Size(456, 25);
            label15.TabIndex = 11;
            label15.Text = "Total de transacciones que has registrado este año";
            // 
            // panelAno
            // 
            panelAno.BackColor = Color.FromArgb(52, 161, 166);
            panelAno.Controls.Add(label3);
            panelAno.Controls.Add(PersonasAno);
            panelAno.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelAno.Location = new Point(925, 110);
            panelAno.Margin = new Padding(3, 2, 3, 2);
            panelAno.Name = "panelAno";
            panelAno.Size = new Size(320, 116);
            panelAno.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 14);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 7;
            label3.Text = "Personas atendidas este año";
            // 
            // PersonasAno
            // 
            PersonasAno.AutoSize = true;
            PersonasAno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonasAno.Location = new Point(20, 48);
            PersonasAno.Name = "PersonasAno";
            PersonasAno.Size = new Size(23, 25);
            PersonasAno.TabIndex = 6;
            PersonasAno.Text = "0";
            // 
            // panelMes
            // 
            panelMes.BackColor = Color.FromArgb(52, 161, 166);
            panelMes.Controls.Add(label2);
            panelMes.Controls.Add(PersonasMes);
            panelMes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelMes.Location = new Point(576, 110);
            panelMes.Margin = new Padding(3, 2, 3, 2);
            panelMes.Name = "panelMes";
            panelMes.Size = new Size(304, 116);
            panelMes.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(262, 25);
            label2.TabIndex = 6;
            label2.Text = "Personas atendidas este mes";
            // 
            // PersonasMes
            // 
            PersonasMes.AutoSize = true;
            PersonasMes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonasMes.Location = new Point(12, 48);
            PersonasMes.Name = "PersonasMes";
            PersonasMes.Size = new Size(23, 25);
            PersonasMes.TabIndex = 5;
            PersonasMes.Text = "0";
            // 
            // panelHoy
            // 
            panelHoy.BackColor = Color.FromArgb(52, 161, 166);
            panelHoy.Controls.Add(label1);
            panelHoy.Controls.Add(PersonasHoy);
            panelHoy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelHoy.Location = new Point(269, 110);
            panelHoy.Margin = new Padding(3, 2, 3, 2);
            panelHoy.Name = "panelHoy";
            panelHoy.Size = new Size(255, 116);
            panelHoy.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 5;
            label1.Text = "Personas atendidas hoy";
            // 
            // PersonasHoy
            // 
            PersonasHoy.AutoSize = true;
            PersonasHoy.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonasHoy.Location = new Point(12, 48);
            PersonasHoy.Name = "PersonasHoy";
            PersonasHoy.Size = new Size(23, 25);
            PersonasHoy.TabIndex = 4;
            PersonasHoy.Text = "0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(269, 332);
            chart1.Margin = new Padding(3, 2, 3, 2);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Movimientos";
            chart1.Series.Add(series1);
            chart1.Size = new Size(700, 281);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
         
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1485, 640);
            Controls.Add(chart1);
            Controls.Add(label15);
            Controls.Add(panelAno);
            Controls.Add(panelMes);
            Controls.Add(panelHoy);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDashboard";
            Text = "Dashboard";
            Load += FormDashboard_Load;
            panelAno.ResumeLayout(false);
            panelAno.PerformLayout();
            panelMes.ResumeLayout(false);
            panelMes.PerformLayout();
            panelHoy.ResumeLayout(false);
            panelHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Panel panelAno;
        private Label PersonasAno;
        private Panel panelMes;
        private Label PersonasMes;
        private Panel panelHoy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private Label PersonasHoy;
        private Label label3;
        private Label label2;
    }
}