namespace ProyectoMigracionMenu
{
    partial class BusquedaMigrantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaMigrantes));
            listView1 = new ListView();
            Fotografia = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            CboPaisEmisor = new ComboBox();
            CboTipoDocumento = new ComboBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            FechaVencimiento = new DateTimePicker();
            label1 = new Label();
            txtNumDocumento = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            BtnClose = new PictureBox();
            BtnMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Fotografia, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader1 });
            listView1.Location = new Point(27, 349);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1322, 311);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Fotografia
            // 
            Fotografia.Tag = "";
            Fotografia.Text = "Fotografia";
            Fotografia.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de documento";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Pais emisor";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "No. de documento";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nombre";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Apellido";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Sexo";
            columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Movimientos";
            columnHeader8.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Último movimiento";
            columnHeader1.Width = 150;
            // 
            // CboPaisEmisor
            // 
            CboPaisEmisor.FormattingEnabled = true;
            CboPaisEmisor.Location = new Point(119, 166);
            CboPaisEmisor.Margin = new Padding(3, 4, 3, 4);
            CboPaisEmisor.Name = "CboPaisEmisor";
            CboPaisEmisor.Size = new Size(138, 28);
            CboPaisEmisor.TabIndex = 30;
            // 
            // CboTipoDocumento
            // 
            CboTipoDocumento.FormattingEnabled = true;
            CboTipoDocumento.Location = new Point(180, 108);
            CboTipoDocumento.Margin = new Padding(3, 4, 3, 4);
            CboTipoDocumento.Name = "CboTipoDocumento";
            CboTipoDocumento.Size = new Size(138, 28);
            CboTipoDocumento.TabIndex = 31;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(27, 169);
            label25.Name = "label25";
            label25.Size = new Size(86, 20);
            label25.TabIndex = 29;
            label25.Text = "Pais emisor:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(27, 271);
            label24.Name = "label24";
            label24.Size = new Size(160, 20);
            label24.TabIndex = 28;
            label24.Text = "Fecha de vencimiento: ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(27, 116);
            label23.Name = "label23";
            label23.Size = new Size(147, 20);
            label23.TabIndex = 27;
            label23.Text = "Tipo de documento: ";
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.Format = DateTimePickerFormat.Short;
            FechaVencimiento.Location = new Point(193, 266);
            FechaVencimiento.Margin = new Padding(3, 4, 3, 4);
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.Size = new Size(138, 27);
            FechaVencimiento.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 225);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 34;
            label1.Text = "No. de documento:";
            // 
            // txtNumDocumento
            // 
            txtNumDocumento.Location = new Point(169, 218);
            txtNumDocumento.Name = "txtNumDocumento";
            txtNumDocumento.Size = new Size(125, 27);
            txtNumDocumento.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 61);
            label2.Name = "label2";
            label2.Size = new Size(249, 25);
            label2.TabIndex = 36;
            label2.Text = "Información del documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(517, 61);
            label3.Name = "label3";
            label3.Size = new Size(215, 25);
            label3.TabIndex = 37;
            label3.Text = "Información del viajero ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(624, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 111);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 38;
            label4.Text = "Nombres:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(624, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 27);
            textBox2.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(517, 166);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 40;
            label5.Text = "Apellidos:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(672, 210);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(138, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(517, 215);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 43;
            label6.Text = "Fecha de nacimiento:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(578, 268);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(517, 271);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 44;
            label7.Text = "Sexo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(889, 107);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 46;
            label8.Text = "Nacionalidad:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1010, 103);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 47;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(1335, 22);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(37, 29);
            BtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            BtnClose.TabIndex = 49;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(1284, 22);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(33, 29);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 48;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // BusquedaMigrantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1410, 673);
            Controls.Add(BtnClose);
            Controls.Add(BtnMinimizar);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNumDocumento);
            Controls.Add(label1);
            Controls.Add(FechaVencimiento);
            Controls.Add(CboPaisEmisor);
            Controls.Add(CboTipoDocumento);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BusquedaMigrantes";
            Text = "BusquedaMigrantes";
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Fotografia;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        private ComboBox CboPaisEmisor;
        private ComboBox CboTipoDocumento;
        private Label label25;
        private Label label24;
        private Label label23;
        private DateTimePicker FechaVencimiento;
        private Label label1;
        private TextBox txtNumDocumento;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private ComboBox comboBox2;
        private PictureBox BtnClose;
        private PictureBox BtnMinimizar;
    }
}