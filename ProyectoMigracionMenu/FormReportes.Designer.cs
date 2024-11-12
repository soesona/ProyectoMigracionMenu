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
            components = new System.ComponentModel.Container();
            BtnLimpiar = new Button();
            BtnGenerar = new Button();
            label1 = new Label();
            panelReporte = new Panel();
            CboDelegaciones = new ComboBox();
            label4 = new Label();
            dtpFechaFin = new DateTimePicker();
            label3 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label2 = new Label();
            PanelTipoReporte = new Panel();
            CboTipoReporte = new ComboBox();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panelReporte.SuspendLayout();
            PanelTipoReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.Location = new Point(817, 539);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(207, 39);
            BtnLimpiar.TabIndex = 0;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnGenerar
            // 
            BtnGenerar.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGenerar.Location = new Point(573, 539);
            BtnGenerar.Name = "BtnGenerar";
            BtnGenerar.Size = new Size(207, 39);
            BtnGenerar.TabIndex = 1;
            BtnGenerar.Text = "Generar reporte";
            BtnGenerar.UseVisualStyleBackColor = true;
            BtnGenerar.Click += BtnGenerar_Click;
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
            // panelReporte
            // 
            panelReporte.BackColor = Color.FromArgb(52, 161, 166);
            panelReporte.Controls.Add(CboDelegaciones);
            panelReporte.Controls.Add(label4);
            panelReporte.Controls.Add(dtpFechaFin);
            panelReporte.Controls.Add(label3);
            panelReporte.Controls.Add(dtpFechaInicio);
            panelReporte.Controls.Add(label2);
            panelReporte.Location = new Point(493, 296);
            panelReporte.Name = "panelReporte";
            panelReporte.Size = new Size(590, 206);
            panelReporte.TabIndex = 3;
            // 
            // CboDelegaciones
            // 
            CboDelegaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            CboDelegaciones.FormattingEnabled = true;
            CboDelegaciones.Location = new Point(301, 140);
            CboDelegaciones.Name = "CboDelegaciones";
            CboDelegaciones.Size = new Size(217, 28);
            CboDelegaciones.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 140);
            label4.Name = "label4";
            label4.Size = new Size(140, 31);
            label4.TabIndex = 4;
            label4.Text = "Delegación:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(301, 89);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 27);
            dtpFechaFin.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 85);
            label3.Name = "label3";
            label3.Size = new Size(136, 31);
            label3.TabIndex = 2;
            label3.Text = "Fecha final:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(301, 25);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 25);
            label2.Name = "label2";
            label2.Size = new Size(152, 31);
            label2.TabIndex = 0;
            label2.Text = "Fecha inicial:";
            // 
            // PanelTipoReporte
            // 
            PanelTipoReporte.BackColor = Color.FromArgb(52, 161, 166);
            PanelTipoReporte.Controls.Add(CboTipoReporte);
            PanelTipoReporte.Controls.Add(label5);
            PanelTipoReporte.Location = new Point(493, 167);
            PanelTipoReporte.Name = "PanelTipoReporte";
            PanelTipoReporte.Size = new Size(590, 89);
            PanelTipoReporte.TabIndex = 4;
            // 
            // CboTipoReporte
            // 
            CboTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            CboTipoReporte.FormattingEnabled = true;
            CboTipoReporte.Location = new Point(301, 29);
            CboTipoReporte.Name = "CboTipoReporte";
            CboTipoReporte.Size = new Size(250, 28);
            CboTipoReporte.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 29);
            label5.Name = "label5";
            label5.Size = new Size(186, 31);
            label5.TabIndex = 4;
            label5.Text = "Tipo de reporte:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1697, 853);
            Controls.Add(PanelTipoReporte);
            Controls.Add(BtnGenerar);
            Controls.Add(panelReporte);
            Controls.Add(label1);
            Controls.Add(BtnLimpiar);
            Name = "FormReportes";
            Text = "Reportes";
            Load += FormReportes_Load;
            panelReporte.ResumeLayout(false);
            panelReporte.PerformLayout();
            PanelTipoReporte.ResumeLayout(false);
            PanelTipoReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLimpiar;
        private Button BtnGenerar;
        private Label label1;
        private Panel panelReporte;
        private Label label2;
        private ComboBox CboDelegaciones;
        private Label label4;
        private DateTimePicker dtpFechaFin;
        private Label label3;
        private DateTimePicker dtpFechaInicio;
        private Panel PanelTipoReporte;
        private ComboBox CboTipoReporte;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}