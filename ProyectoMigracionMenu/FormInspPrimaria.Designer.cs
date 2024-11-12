namespace interfaz_grafica_de_inspeccion_primaria
{
    partial class FormInspPrimaria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInspPrimaria));
            Documentoviaje = new GroupBox();
            btnCancelarInfo = new Button();
            dtpfechaVenci = new DateTimePicker();
            btnbuscar = new Button();
            txtIdentidad = new TextBox();
            cbPaisEmision = new ComboBox();
            cbDoc = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Label3 = new Label();
            datosdeviaje = new GroupBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cbSexo = new ComboBox();
            label11 = new Label();
            cbNacionalidad = new ComboBox();
            dtpFechaNa = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            pic = new PictureBox();
            btnfotografia = new Button();
            groupBox2 = new GroupBox();
            chk5 = new CheckBox();
            chk4 = new CheckBox();
            chk3 = new CheckBox();
            chk2 = new CheckBox();
            chk1 = new CheckBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            groupBox3 = new GroupBox();
            btnPaises = new Button();
            btnTrabajo = new Button();
            txtEstadia = new TextBox();
            cbPaisNa = new ComboBox();
            cbPaisRes = new ComboBox();
            cbTrabajo = new ComboBox();
            label21 = new Label();
            label27 = new Label();
            label20 = new Label();
            label19 = new Label();
            groupBox4 = new GroupBox();
            btnMotivos = new Button();
            txtResidencia = new TextBox();
            label1 = new Label();
            cbPaisDestino = new ComboBox();
            cbMotivos = new ComboBox();
            label26 = new Label();
            label25 = new Label();
            groupBox5 = new GroupBox();
            txtObservaciones = new TextBox();
            label28 = new Label();
            groupBox6 = new GroupBox();
            dgvTransacciones = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            tipoDocu = new DataGridViewTextBoxColumn();
            no = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            groupBox7 = new GroupBox();
            dgvObservaciones = new DataGridView();
            Observaciones = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            contadortxtx = new Label();
            label15 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            Documentoviaje.SuspendLayout();
            datosdeviaje.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObservaciones).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Documentoviaje
            // 
            Documentoviaje.Controls.Add(btnCancelarInfo);
            Documentoviaje.Controls.Add(dtpfechaVenci);
            Documentoviaje.Controls.Add(btnbuscar);
            Documentoviaje.Controls.Add(txtIdentidad);
            Documentoviaje.Controls.Add(cbPaisEmision);
            Documentoviaje.Controls.Add(cbDoc);
            Documentoviaje.Controls.Add(label4);
            Documentoviaje.Controls.Add(label5);
            Documentoviaje.Controls.Add(label6);
            Documentoviaje.Controls.Add(Label3);
            Documentoviaje.Location = new Point(21, 35);
            Documentoviaje.Margin = new Padding(3, 4, 3, 4);
            Documentoviaje.Name = "Documentoviaje";
            Documentoviaje.Padding = new Padding(3, 4, 3, 4);
            Documentoviaje.Size = new Size(409, 304);
            Documentoviaje.TabIndex = 9;
            Documentoviaje.TabStop = false;
            Documentoviaje.Text = "Documento de Viaje";
            // 
            // btnCancelarInfo
            // 
            btnCancelarInfo.Location = new Point(301, 243);
            btnCancelarInfo.Margin = new Padding(3, 4, 3, 4);
            btnCancelarInfo.Name = "btnCancelarInfo";
            btnCancelarInfo.Size = new Size(86, 31);
            btnCancelarInfo.TabIndex = 17;
            btnCancelarInfo.Text = "Limpiar";
            btnCancelarInfo.UseVisualStyleBackColor = true;
            btnCancelarInfo.Click += btnCancelarInfo_Click;
            // 
            // dtpfechaVenci
            // 
            dtpfechaVenci.Format = DateTimePickerFormat.Short;
            dtpfechaVenci.Location = new Point(168, 196);
            dtpfechaVenci.Margin = new Padding(3, 4, 3, 4);
            dtpfechaVenci.Name = "dtpfechaVenci";
            dtpfechaVenci.Size = new Size(218, 27);
            dtpfechaVenci.TabIndex = 16;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(155, 243);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(86, 31);
            btnbuscar.TabIndex = 15;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtIdentidad
            // 
            txtIdentidad.CharacterCasing = CharacterCasing.Upper;
            txtIdentidad.Location = new Point(168, 143);
            txtIdentidad.Margin = new Padding(3, 4, 3, 4);
            txtIdentidad.MaxLength = 30;
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(218, 27);
            txtIdentidad.TabIndex = 14;
            txtIdentidad.Tag = "obligatorio";
            // 
            // cbPaisEmision
            // 
            cbPaisEmision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaisEmision.FormattingEnabled = true;
            cbPaisEmision.Location = new Point(168, 96);
            cbPaisEmision.Margin = new Padding(3, 4, 3, 4);
            cbPaisEmision.Name = "cbPaisEmision";
            cbPaisEmision.Size = new Size(218, 28);
            cbPaisEmision.TabIndex = 13;
            cbPaisEmision.Tag = "obligatorio";
            // 
            // cbDoc
            // 
            cbDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoc.FormattingEnabled = true;
            cbDoc.Location = new Point(168, 41);
            cbDoc.Margin = new Padding(3, 4, 3, 4);
            cbDoc.Name = "cbDoc";
            cbDoc.Size = new Size(218, 28);
            cbDoc.TabIndex = 10;
            cbDoc.Tag = "obligatorio";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 96);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "Pais de Emision:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 149);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 11;
            label5.Text = "Numero de documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 204);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 12;
            label6.Text = "Fecha de vencimiento:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(7, 45);
            Label3.Name = "Label3";
            Label3.Size = new Size(143, 20);
            Label3.TabIndex = 0;
            Label3.Text = "Tipo de documento:";
            // 
            // datosdeviaje
            // 
            datosdeviaje.Controls.Add(txtApellido);
            datosdeviaje.Controls.Add(txtNombre);
            datosdeviaje.Controls.Add(cbSexo);
            datosdeviaje.Controls.Add(label11);
            datosdeviaje.Controls.Add(cbNacionalidad);
            datosdeviaje.Controls.Add(dtpFechaNa);
            datosdeviaje.Controls.Add(label7);
            datosdeviaje.Controls.Add(label8);
            datosdeviaje.Controls.Add(label9);
            datosdeviaje.Controls.Add(label10);
            datosdeviaje.Location = new Point(437, 37);
            datosdeviaje.Margin = new Padding(3, 4, 3, 4);
            datosdeviaje.Name = "datosdeviaje";
            datosdeviaje.Padding = new Padding(3, 4, 3, 4);
            datosdeviaje.Size = new Size(489, 301);
            datosdeviaje.TabIndex = 10;
            datosdeviaje.TabStop = false;
            datosdeviaje.Text = "Datos Personales";
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(90, 96);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(391, 27);
            txtApellido.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(90, 39);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(391, 27);
            txtNombre.TabIndex = 24;
            // 
            // cbSexo
            // 
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.FormattingEnabled = true;
            cbSexo.Location = new Point(371, 151);
            cbSexo.Margin = new Padding(3, 4, 3, 4);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(110, 28);
            cbSexo.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(325, 156);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 18;
            label11.Text = "Sexo";
            // 
            // cbNacionalidad
            // 
            cbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNacionalidad.FormattingEnabled = true;
            cbNacionalidad.Location = new Point(168, 203);
            cbNacionalidad.Margin = new Padding(3, 4, 3, 4);
            cbNacionalidad.Name = "cbNacionalidad";
            cbNacionalidad.Size = new Size(314, 28);
            cbNacionalidad.TabIndex = 17;
            // 
            // dtpFechaNa
            // 
            dtpFechaNa.Format = DateTimePickerFormat.Short;
            dtpFechaNa.Location = new Point(168, 149);
            dtpFechaNa.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNa.Name = "dtpFechaNa";
            dtpFechaNa.Size = new Size(138, 27);
            dtpFechaNa.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 100);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 10;
            label7.Text = "Apellido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 207);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 11;
            label8.Text = "Nacionalidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 151);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 12;
            label9.Text = "Fecha de nacimiento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 45);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 0;
            label10.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pic);
            groupBox1.Controls.Add(btnfotografia);
            groupBox1.Location = new Point(933, 37);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(224, 304);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fotografia";
            // 
            // pic
            // 
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
            pic.Location = new Point(18, 29);
            pic.Margin = new Padding(3, 4, 3, 4);
            pic.Name = "pic";
            pic.Size = new Size(186, 211);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.TabIndex = 1;
            pic.TabStop = false;
            // 
            // btnfotografia
            // 
            btnfotografia.Location = new Point(70, 263);
            btnfotografia.Margin = new Padding(3, 4, 3, 4);
            btnfotografia.Name = "btnfotografia";
            btnfotografia.Size = new Size(86, 31);
            btnfotografia.TabIndex = 0;
            btnfotografia.Text = "Seleccionar";
            btnfotografia.UseVisualStyleBackColor = true;
            btnfotografia.Click += btnfotografia_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chk5);
            groupBox2.Controls.Add(chk4);
            groupBox2.Controls.Add(chk3);
            groupBox2.Controls.Add(chk2);
            groupBox2.Controls.Add(chk1);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(1162, 37);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(422, 303);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Validaciones";
            // 
            // chk5
            // 
            chk5.AutoSize = true;
            chk5.Location = new Point(222, 72);
            chk5.Margin = new Padding(3, 4, 3, 4);
            chk5.Name = "chk5";
            chk5.Size = new Size(149, 24);
            chk5.TabIndex = 7;
            chk5.Text = "Tiene Prechequeo";
            chk5.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            chk4.AutoSize = true;
            chk4.Location = new Point(14, 240);
            chk4.Margin = new Padding(3, 4, 3, 4);
            chk4.Name = "chk4";
            chk4.Size = new Size(83, 24);
            chk4.TabIndex = 6;
            chk4.Text = "Interpol";
            chk4.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            chk3.AutoSize = true;
            chk3.Location = new Point(14, 193);
            chk3.Margin = new Padding(3, 4, 3, 4);
            chk3.Name = "chk3";
            chk3.Size = new Size(145, 24);
            chk3.TabIndex = 5;
            chk3.Text = "Alerta Migratoria";
            chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            chk2.AutoSize = true;
            chk2.Location = new Point(14, 105);
            chk2.Margin = new Padding(3, 4, 3, 4);
            chk2.Name = "chk2";
            chk2.Size = new Size(166, 24);
            chk2.TabIndex = 4;
            chk2.Text = "Documento Vencido";
            chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Location = new Point(14, 72);
            chk1.Margin = new Padding(3, 4, 3, 4);
            chk1.Name = "chk1";
            chk1.Size = new Size(166, 24);
            chk1.TabIndex = 3;
            chk1.Text = "Documento Robado";
            chk1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 156);
            label14.Name = "label14";
            label14.Size = new Size(98, 20);
            label14.TabIndex = 2;
            label14.Text = "Posible alerta";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(248, 36);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 1;
            label13.Text = "Prechequeo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 36);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 0;
            label12.Text = "Documento";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPaises);
            groupBox3.Controls.Add(btnTrabajo);
            groupBox3.Controls.Add(txtEstadia);
            groupBox3.Controls.Add(cbPaisNa);
            groupBox3.Controls.Add(cbPaisRes);
            groupBox3.Controls.Add(cbTrabajo);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Location = new Point(14, 349);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(579, 196);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion adicional";
            // 
            // btnPaises
            // 
            btnPaises.Location = new Point(409, 75);
            btnPaises.Margin = new Padding(3, 4, 3, 4);
            btnPaises.Name = "btnPaises";
            btnPaises.Size = new Size(82, 31);
            btnPaises.TabIndex = 26;
            btnPaises.Text = "Agregar";
            btnPaises.UseVisualStyleBackColor = true;
            btnPaises.Click += btnPaises_Click;
            // 
            // btnTrabajo
            // 
            btnTrabajo.Location = new Point(408, 25);
            btnTrabajo.Margin = new Padding(3, 4, 3, 4);
            btnTrabajo.Name = "btnTrabajo";
            btnTrabajo.Size = new Size(82, 31);
            btnTrabajo.TabIndex = 25;
            btnTrabajo.Text = "Agregar";
            btnTrabajo.UseVisualStyleBackColor = true;
            btnTrabajo.Click += btnTrabajo_Click;
            // 
            // txtEstadia
            // 
            txtEstadia.Enabled = false;
            txtEstadia.Location = new Point(162, 157);
            txtEstadia.Margin = new Padding(3, 4, 3, 4);
            txtEstadia.MaxLength = 3;
            txtEstadia.Name = "txtEstadia";
            txtEstadia.Size = new Size(51, 27);
            txtEstadia.TabIndex = 17;
            txtEstadia.Text = "5";
            txtEstadia.TextAlign = HorizontalAlignment.Center;
            // 
            // cbPaisNa
            // 
            cbPaisNa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaisNa.FormattingEnabled = true;
            cbPaisNa.Location = new Point(162, 116);
            cbPaisNa.Margin = new Padding(3, 4, 3, 4);
            cbPaisNa.Name = "cbPaisNa";
            cbPaisNa.Size = new Size(230, 28);
            cbPaisNa.TabIndex = 22;
            // 
            // cbPaisRes
            // 
            cbPaisRes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaisRes.FormattingEnabled = true;
            cbPaisRes.Location = new Point(165, 72);
            cbPaisRes.Margin = new Padding(3, 4, 3, 4);
            cbPaisRes.Name = "cbPaisRes";
            cbPaisRes.Size = new Size(228, 28);
            cbPaisRes.TabIndex = 23;
            // 
            // cbTrabajo
            // 
            cbTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrabajo.FormattingEnabled = true;
            cbTrabajo.Location = new Point(165, 25);
            cbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cbTrabajo.Name = "cbTrabajo";
            cbTrabajo.Size = new Size(228, 28);
            cbTrabajo.TabIndex = 24;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(16, 119);
            label21.Name = "label21";
            label21.Size = new Size(136, 20);
            label21.TabIndex = 2;
            label21.Text = "Pais de nacimiento:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(30, 157);
            label27.Name = "label27";
            label27.Size = new Size(126, 20);
            label27.TabIndex = 8;
            label27.Text = "Estadia otorgada:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(16, 75);
            label20.Name = "label20";
            label20.Size = new Size(129, 20);
            label20.TabIndex = 1;
            label20.Text = "Pais de residencia:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(16, 36);
            label19.Name = "label19";
            label19.Size = new Size(62, 20);
            label19.TabIndex = 0;
            label19.Text = "Trabajo:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnMotivos);
            groupBox4.Controls.Add(txtResidencia);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(cbPaisDestino);
            groupBox4.Controls.Add(cbMotivos);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(label25);
            groupBox4.Location = new Point(14, 553);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(579, 211);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Informacion del viaje";
            // 
            // btnMotivos
            // 
            btnMotivos.Location = new Point(361, 81);
            btnMotivos.Margin = new Padding(3, 4, 3, 4);
            btnMotivos.Name = "btnMotivos";
            btnMotivos.Size = new Size(82, 31);
            btnMotivos.TabIndex = 27;
            btnMotivos.Text = "Agregar";
            btnMotivos.UseVisualStyleBackColor = true;
            btnMotivos.Click += btnMotivos_Click;
            // 
            // txtResidencia
            // 
            txtResidencia.Location = new Point(128, 137);
            txtResidencia.Margin = new Padding(3, 4, 3, 4);
            txtResidencia.MaxLength = 200;
            txtResidencia.Multiline = true;
            txtResidencia.Name = "txtResidencia";
            txtResidencia.Size = new Size(438, 64);
            txtResidencia.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 137);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 23;
            label1.Text = "Residencia:";
            // 
            // cbPaisDestino
            // 
            cbPaisDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaisDestino.FormattingEnabled = true;
            cbPaisDestino.Location = new Point(120, 36);
            cbPaisDestino.Margin = new Padding(3, 4, 3, 4);
            cbPaisDestino.Name = "cbPaisDestino";
            cbPaisDestino.Size = new Size(206, 28);
            cbPaisDestino.TabIndex = 22;
            // 
            // cbMotivos
            // 
            cbMotivos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMotivos.FormattingEnabled = true;
            cbMotivos.Location = new Point(118, 81);
            cbMotivos.Margin = new Padding(3, 4, 3, 4);
            cbMotivos.Name = "cbMotivos";
            cbMotivos.Size = new Size(209, 28);
            cbMotivos.TabIndex = 20;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(11, 40);
            label26.Name = "label26";
            label26.Size = new Size(111, 20);
            label26.TabIndex = 7;
            label26.Text = "Pais de destino:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(8, 85);
            label25.Name = "label25";
            label25.Size = new Size(115, 20);
            label25.TabIndex = 6;
            label25.Text = "Motivo de viaje:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtObservaciones);
            groupBox5.Controls.Add(label28);
            groupBox5.Location = new Point(11, 772);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(581, 120);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Decision";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(130, 25);
            txtObservaciones.Margin = new Padding(3, 4, 3, 4);
            txtObservaciones.MaxLength = 200;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(438, 85);
            txtObservaciones.TabIndex = 17;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(7, 25);
            label28.Name = "label28";
            label28.Size = new Size(108, 20);
            label28.TabIndex = 9;
            label28.Text = "Observaciones:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvTransacciones);
            groupBox6.Location = new Point(607, 349);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(977, 213);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Historial de viajes";
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Columns.AddRange(new DataGridViewColumn[] { Fecha, tipoDocu, no, Origen, Destino, Nombres, Apellidos, Edad, Imagen });
            dgvTransacciones.Location = new Point(14, 25);
            dgvTransacciones.Margin = new Padding(3, 4, 3, 4);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.ReadOnly = true;
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(957, 171);
            dgvTransacciones.TabIndex = 26;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 130;
            // 
            // tipoDocu
            // 
            tipoDocu.HeaderText = "Tipo Documento";
            tipoDocu.MinimumWidth = 6;
            tipoDocu.Name = "tipoDocu";
            tipoDocu.ReadOnly = true;
            tipoDocu.Width = 200;
            // 
            // no
            // 
            no.HeaderText = "No. Documento";
            no.MinimumWidth = 6;
            no.Name = "no";
            no.ReadOnly = true;
            no.Width = 200;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.MinimumWidth = 6;
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Width = 140;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.MinimumWidth = 6;
            Destino.Name = "Destino";
            Destino.ReadOnly = true;
            Destino.Width = 140;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.ReadOnly = true;
            Nombres.Visible = false;
            Nombres.Width = 125;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            Apellidos.Visible = false;
            Apellidos.Width = 125;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            Edad.Visible = false;
            Edad.Width = 125;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.MinimumWidth = 6;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Visible = false;
            Imagen.Width = 125;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dgvObservaciones);
            groupBox7.Location = new Point(611, 669);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(774, 227);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Historial de observaciones";
            // 
            // dgvObservaciones
            // 
            dgvObservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObservaciones.Columns.AddRange(new DataGridViewColumn[] { Observaciones, usuario });
            dgvObservaciones.Location = new Point(9, 29);
            dgvObservaciones.Margin = new Padding(3, 4, 3, 4);
            dgvObservaciones.Name = "dgvObservaciones";
            dgvObservaciones.ReadOnly = true;
            dgvObservaciones.RowHeadersWidth = 51;
            dgvObservaciones.Size = new Size(752, 171);
            dgvObservaciones.TabIndex = 27;
            // 
            // Observaciones
            // 
            Observaciones.HeaderText = "Observaciones";
            Observaciones.MinimumWidth = 6;
            Observaciones.Name = "Observaciones";
            Observaciones.ReadOnly = true;
            Observaciones.Width = 500;
            // 
            // usuario
            // 
            usuario.HeaderText = "Usuario Creador";
            usuario.MinimumWidth = 6;
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            usuario.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(contadortxtx);
            panel1.Controls.Add(label15);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(611, 571);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 83);
            panel1.TabIndex = 16;
            // 
            // contadortxtx
            // 
            contadortxtx.AutoSize = true;
            contadortxtx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contadortxtx.Location = new Point(170, 28);
            contadortxtx.Name = "contadortxtx";
            contadortxtx.Size = new Size(0, 28);
            contadortxtx.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 19);
            label15.Name = "label15";
            label15.Size = new Size(127, 20);
            label15.TabIndex = 0;
            label15.Text = "Total de entradas:";
            // 
            // button2
            // 
            button2.Location = new Point(1296, 1064);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(151, 31);
            button2.TabIndex = 19;
            button2.Text = "Admitir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1462, 1064);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(151, 31);
            button3.TabIndex = 20;
            button3.Text = "Denegar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1619, 1064);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(151, 31);
            button4.TabIndex = 21;
            button4.Text = "Admitir/Investigacion";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1777, 1064);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(151, 31);
            button5.TabIndex = 22;
            button5.Text = "Ver documentos";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGreen;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(1410, 691);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 53);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(1410, 749);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(174, 53);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormInspPrimaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1765, 908);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(datosdeviaje);
            Controls.Add(Documentoviaje);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInspPrimaria";
            Text = "Inspección primaria";
            Load += Form1_Load;
            Documentoviaje.ResumeLayout(false);
            Documentoviaje.PerformLayout();
            datosdeviaje.ResumeLayout(false);
            datosdeviaje.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvObservaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox Documentoviaje;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label Label3;
        private ComboBox cbDoc;
        private TextBox txtIdentidad;
        private ComboBox cbPaisEmision;
        private Button btnbuscar;
        private GroupBox datosdeviaje;
        private DateTimePicker dtpFechaNa;
        private Label label7;
        private Label label9;
        private Label label10;
        private ComboBox cbNacionalidad;
        private Label label11;
        private ComboBox cbSexo;
        private GroupBox groupBox1;
        private Button btnfotografia;
        private GroupBox groupBox2;
        private Label label14;
        private Label label13;
        private Label label12;
        private CheckBox chk5;
        private CheckBox chk4;
        private CheckBox chk3;
        private CheckBox chk2;
        private CheckBox chk1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Panel panel1;
        private Label label15;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label25;
        private Label label27;
        private Label label26;
        private Label label28;
        private ComboBox cbPaisRes;
        private ComboBox cbTrabajo;
        private TextBox txtEstadia;
        private ComboBox cbPaisDestino;
        private ComboBox cbMotivos;
        private TextBox txtObservaciones;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label8;
        private ComboBox cbPaisNa;
        private TextBox txtResidencia;
        private Label label1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnTrabajo;
        private Button btnPaises;
        private Button btnMotivos;
        private DateTimePicker dtpfechaVenci;
        private PictureBox pic;
        private DataGridView dgvTransacciones;
        private ErrorProvider errorProvider1;
        private DataGridView dgvObservaciones;
        private DataGridViewTextBoxColumn Observaciones;
        private DataGridViewTextBoxColumn usuario;
        private Button btnCancelarInfo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn tipoDocu;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Imagen;
        private Label contadortxtx;
    }
}
