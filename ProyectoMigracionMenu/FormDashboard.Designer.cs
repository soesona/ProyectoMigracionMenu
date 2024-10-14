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
            label7 = new Label();
            label3 = new Label();
            panelMes = new Panel();
            label6 = new Label();
            label2 = new Label();
            panelHoy = new Panel();
            label4 = new Label();
            label1 = new Label();
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
            label15.Location = new Point(307, 382);
            label15.Name = "label15";
            label15.Size = new Size(549, 31);
            label15.TabIndex = 11;
            label15.Text = "Total de transacciones que has registrado este año";
            // 
            // panelAno
            // 
            panelAno.BackColor = Color.FromArgb(52, 161, 166);
            panelAno.Controls.Add(label7);
            panelAno.Controls.Add(label3);
            panelAno.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelAno.Location = new Point(1057, 147);
            panelAno.Name = "panelAno";
            panelAno.Size = new Size(366, 154);
            panelAno.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 57);
            label7.Name = "label7";
            label7.Size = new Size(32, 38);
            label7.TabIndex = 6;
            label7.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 19);
            label3.Name = "label3";
            label3.Size = new Size(313, 31);
            label3.TabIndex = 6;
            label3.Text = "Personas atendidas este año";
            // 
            // panelMes
            // 
            panelMes.BackColor = Color.FromArgb(52, 161, 166);
            panelMes.Controls.Add(label6);
            panelMes.Controls.Add(label2);
            panelMes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelMes.Location = new Point(658, 147);
            panelMes.Name = "panelMes";
            panelMes.Size = new Size(348, 154);
            panelMes.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 57);
            label6.Name = "label6";
            label6.Size = new Size(32, 38);
            label6.TabIndex = 5;
            label6.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 19);
            label2.Name = "label2";
            label2.Size = new Size(316, 31);
            label2.TabIndex = 5;
            label2.Text = "Personas atendidas este mes";
            // 
            // panelHoy
            // 
            panelHoy.BackColor = Color.FromArgb(52, 161, 166);
            panelHoy.Controls.Add(label4);
            panelHoy.Controls.Add(label1);
            panelHoy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelHoy.Location = new Point(307, 147);
            panelHoy.Name = "panelHoy";
            panelHoy.Size = new Size(291, 154);
            panelHoy.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 57);
            label4.Name = "label4";
            label4.Size = new Size(32, 38);
            label4.TabIndex = 4;
            label4.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(264, 31);
            label1.TabIndex = 4;
            label1.Text = "Personas atendidas hoy";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(307, 442);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Movimientos";
            chart1.Series.Add(series1);
            chart1.Size = new Size(800, 375);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1697, 853);
            Controls.Add(chart1);
            Controls.Add(label15);
            Controls.Add(panelAno);
            Controls.Add(panelMes);
            Controls.Add(panelHoy);
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
        private Label label7;
        private Label label3;
        private Panel panelMes;
        private Label label6;
        private Label label2;
        private Panel panelHoy;
        private Label label4;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}