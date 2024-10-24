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
            txtEdad = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cbSexo = new ComboBox();
            label11 = new Label();
            cbNacionalidad = new ComboBox();
            dtpFechaNa = new DateTimePicker();
            button1 = new Button();
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
            Documentoviaje.Location = new Point(18, 26);
            Documentoviaje.Name = "Documentoviaje";
            Documentoviaje.Size = new Size(358, 228);
            Documentoviaje.TabIndex = 9;
            Documentoviaje.TabStop = false;
            Documentoviaje.Text = "Documento de Viaje";
            // 
            // btnCancelarInfo
            // 
            btnCancelarInfo.Location = new Point(263, 182);
            btnCancelarInfo.Name = "btnCancelarInfo";
            btnCancelarInfo.Size = new Size(75, 23);
            btnCancelarInfo.TabIndex = 17;
            btnCancelarInfo.Text = "Limpiar";
            btnCancelarInfo.UseVisualStyleBackColor = true;
            btnCancelarInfo.Click += btnCancelarInfo_Click;
            // 
            // dtpfechaVenci
            // 
            dtpfechaVenci.Format = DateTimePickerFormat.Short;
            dtpfechaVenci.Location = new Point(147, 147);
            dtpfechaVenci.Name = "dtpfechaVenci";
            dtpfechaVenci.Size = new Size(191, 23);
            dtpfechaVenci.TabIndex = 16;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(136, 182);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 15;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtIdentidad
            // 
            txtIdentidad.CharacterCasing = CharacterCasing.Upper;
            txtIdentidad.Location = new Point(147, 107);
            txtIdentidad.MaxLength = 30;
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(191, 23);
            txtIdentidad.TabIndex = 14;
            txtIdentidad.Tag = "obligatorio";
            // 
            // cbPaisEmision
            // 
            cbPaisEmision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaisEmision.FormattingEnabled = true;
            cbPaisEmision.Location = new Point(147, 72);
            cbPaisEmision.Name = "cbPaisEmision";
            cbPaisEmision.Size = new Size(191, 23);
            cbPaisEmision.TabIndex = 13;
            cbPaisEmision.Tag = "obligatorio";
            // 
            // cbDoc
            // 
            cbDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoc.FormattingEnabled = true;
            cbDoc.Location = new Point(147, 31);
            cbDoc.Name = "cbDoc";
            cbDoc.Size = new Size(191, 23);
            cbDoc.TabIndex = 10;
            cbDoc.Tag = "obligatorio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 72);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 10;
            label4.Text = "Pais de Emision:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 112);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 11;
            label5.Text = "Numero de documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 153);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 12;
            label6.Text = "Fecha de vencimiento:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(6, 34);
            Label3.Name = "Label3";
            Label3.Size = new Size(114, 15);
            Label3.TabIndex = 0;
            Label3.Text = "Tipo de documento:";
            // 
            // datosdeviaje
            // 
            datosdeviaje.Controls.Add(txtEdad);
            datosdeviaje.Controls.Add(label2);
            datosdeviaje.Controls.Add(txtApellido);
            datosdeviaje.Controls.Add(txtNombre);
            datosdeviaje.Controls.Add(cbSexo);
            datosdeviaje.Controls.Add(label11);
            datosdeviaje.Controls.Add(cbNacionalidad);
            datosdeviaje.Controls.Add(dtpFechaNa);
            datosdeviaje.Controls.Add(button1);
            datosdeviaje.Controls.Add(label7);
            datosdeviaje.Controls.Add(label8);
            datosdeviaje.Controls.Add(label9);
            datosdeviaje.Controls.Add(label10);
            datosdeviaje.Location = new Point(382, 28);
            datosdeviaje.Name = "datosdeviaje";
            datosdeviaje.Size = new Size(428, 226);
            datosdeviaje.TabIndex = 10;
            datosdeviaje.TabStop = false;
            datosdeviaje.Text = "Datos Personales";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(284, 187);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(81, 23);
            txtEdad.TabIndex = 27;
            txtEdad.TextAlign = HorizontalAlignment.Center;
            txtEdad.TextChanged += txtEdad_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 192);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 26;
            label2.Text = "Edad:";
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(79, 72);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(343, 23);
            txtApellido.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(79, 29);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(343, 23);
            txtNombre.TabIndex = 24;
            // 
            // cbSexo
            // 
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.FormattingEnabled = true;
            cbSexo.Location = new Point(325, 113);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(97, 23);
            cbSexo.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(284, 117);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 18;
            label11.Text = "Sexo";
            // 
            // cbNacionalidad
            // 
            cbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNacionalidad.FormattingEnabled = true;
            cbNacionalidad.Location = new Point(147, 152);
            cbNacionalidad.Name = "cbNacionalidad";
            cbNacionalidad.Size = new Size(275, 23);
            cbNacionalidad.TabIndex = 17;
            // 
            // dtpFechaNa
            // 
            dtpFechaNa.Format = DateTimePickerFormat.Short;
            dtpFechaNa.Location = new Point(147, 112);
            dtpFechaNa.Name = "dtpFechaNa";
            dtpFechaNa.Size = new Size(121, 23);
            dtpFechaNa.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(8, 186);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 75);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 10;
            label7.Text = "Apellido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 155);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 11;
            label8.Text = "Nacionalidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 113);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 12;
            label9.Text = "Fecha de nacimiento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 34);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 0;
            label10.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pic);
            groupBox1.Controls.Add(btnfotografia);
            groupBox1.Location = new Point(816, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 228);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fotografia";
            // 
            // pic
            // 
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
            pic.Location = new Point(16, 22);
            pic.Name = "pic";
            pic.Size = new Size(163, 158);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.TabIndex = 1;
            pic.TabStop = false;
            // 
            // btnfotografia
            // 
            btnfotografia.Location = new Point(61, 197);
            btnfotografia.Name = "btnfotografia";
            btnfotografia.Size = new Size(75, 23);
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
            groupBox2.Location = new Point(1017, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 227);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Validaciones";
            // 
            // chk5
            // 
            chk5.AutoSize = true;
            chk5.Location = new Point(194, 54);
            chk5.Name = "chk5";
            chk5.Size = new Size(120, 19);
            chk5.TabIndex = 7;
            chk5.Text = "Tiene Prechequeo";
            chk5.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            chk4.AutoSize = true;
            chk4.Location = new Point(12, 180);
            chk4.Name = "chk4";
            chk4.Size = new Size(67, 19);
            chk4.TabIndex = 6;
            chk4.Text = "Interpol";
            chk4.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            chk3.AutoSize = true;
            chk3.Location = new Point(12, 145);
            chk3.Name = "chk3";
            chk3.Size = new Size(115, 19);
            chk3.TabIndex = 5;
            chk3.Text = "Alerta Migratoria";
            chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            chk2.AutoSize = true;
            chk2.Location = new Point(12, 79);
            chk2.Name = "chk2";
            chk2.Size = new Size(134, 19);
            chk2.TabIndex = 4;
            chk2.Text = "Documento Vencido";
            chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Location = new Point(12, 54);
            chk1.Name = "chk1";
            chk1.Size = new Size(133, 19);
            chk1.TabIndex = 3;
            chk1.Text = "Documento Robado";
            chk1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 117);
            label14.Name = "label14";
            label14.Size = new Size(77, 15);
            label14.TabIndex = 2;
            label14.Text = "Posible alerta";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(217, 27);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 1;
            label13.Text = "Prechequeo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 27);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
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
            groupBox3.Location = new Point(12, 262);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(507, 147);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion adicional";
            // 
            // btnPaises
            // 
            btnPaises.Location = new Point(358, 56);
            btnPaises.Name = "btnPaises";
            btnPaises.Size = new Size(72, 23);
            btnPaises.TabIndex = 26;
            btnPaises.Text = "Agregar";
            btnPaises.UseVisualStyleBackColor = true;
            btnPaises.Click += btnPaises_Click;
            // 
            // btnTrabajo
            // 
            btnTrabajo.Location = new Point(357, 19);
            btnTrabajo.Name = "btnTrabajo";
            btnTrabajo.Size = new Size(72, 23);
            btnTrabajo.TabIndex = 25;
            btnTrabajo.Text = "Agregar";
            btnTrabajo.UseVisualStyleBackColor = true;
            btnTrabajo.Click += btnTrabajo_Click;
            // 
            // txtEstadia
            // 
            txtEstadia.Enabled = false;
            txtEstadia.Location = new Point(142, 118);
            txtEstadia.MaxLength = 3;
            txtEstadia.Name = "txtEstadia";
            txtEstadia.Size = new Size(45, 23);
            txtEstadia.TabIndex = 17;
            txtEstadia.Text = "5";
            txtEstadia.TextAlign = HorizontalAlignment.Center;
            // 
            // cbPaisNa
            // 
            cbPaisNa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaisNa.FormattingEnabled = true;
            cbPaisNa.Location = new Point(142, 87);
            cbPaisNa.Name = "cbPaisNa";
            cbPaisNa.Size = new Size(202, 23);
            cbPaisNa.TabIndex = 22;
            // 
            // cbPaisRes
            // 
            cbPaisRes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaisRes.FormattingEnabled = true;
            cbPaisRes.Location = new Point(144, 54);
            cbPaisRes.Name = "cbPaisRes";
            cbPaisRes.Size = new Size(200, 23);
            cbPaisRes.TabIndex = 23;
            // 
            // cbTrabajo
            // 
            cbTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrabajo.FormattingEnabled = true;
            cbTrabajo.Location = new Point(144, 19);
            cbTrabajo.Name = "cbTrabajo";
            cbTrabajo.Size = new Size(200, 23);
            cbTrabajo.TabIndex = 24;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(14, 89);
            label21.Name = "label21";
            label21.Size = new Size(110, 15);
            label21.TabIndex = 2;
            label21.Text = "Pais de nacimiento:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(26, 118);
            label27.Name = "label27";
            label27.Size = new Size(98, 15);
            label27.TabIndex = 8;
            label27.Text = "Estadia otorgada:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(14, 56);
            label20.Name = "label20";
            label20.Size = new Size(103, 15);
            label20.TabIndex = 1;
            label20.Text = "Pais de residencia:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(14, 27);
            label19.Name = "label19";
            label19.Size = new Size(48, 15);
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
            groupBox4.Location = new Point(12, 415);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(507, 158);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Informacion del viaje";
            // 
            // btnMotivos
            // 
            btnMotivos.Location = new Point(316, 61);
            btnMotivos.Name = "btnMotivos";
            btnMotivos.Size = new Size(72, 23);
            btnMotivos.TabIndex = 27;
            btnMotivos.Text = "Agregar";
            btnMotivos.UseVisualStyleBackColor = true;
            btnMotivos.Click += btnMotivos_Click;
            // 
            // txtResidencia
            // 
            txtResidencia.Location = new Point(112, 103);
            txtResidencia.MaxLength = 200;
            txtResidencia.Multiline = true;
            txtResidencia.Name = "txtResidencia";
            txtResidencia.Size = new Size(384, 49);
            txtResidencia.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 103);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 23;
            label1.Text = "Residencia:";
            // 
            // cbPaisDestino
            // 
            cbPaisDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaisDestino.FormattingEnabled = true;
            cbPaisDestino.Location = new Point(105, 27);
            cbPaisDestino.Name = "cbPaisDestino";
            cbPaisDestino.Size = new Size(181, 23);
            cbPaisDestino.TabIndex = 22;
            // 
            // cbMotivos
            // 
            cbMotivos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMotivos.FormattingEnabled = true;
            cbMotivos.Location = new Point(103, 61);
            cbMotivos.Name = "cbMotivos";
            cbMotivos.Size = new Size(183, 23);
            cbMotivos.TabIndex = 20;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(10, 30);
            label26.Name = "label26";
            label26.Size = new Size(89, 15);
            label26.TabIndex = 7;
            label26.Text = "Pais de destino:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(7, 64);
            label25.Name = "label25";
            label25.Size = new Size(91, 15);
            label25.TabIndex = 6;
            label25.Text = "Motivo de viaje:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtObservaciones);
            groupBox5.Controls.Add(label28);
            groupBox5.Location = new Point(10, 579);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(508, 90);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Decision";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(114, 19);
            txtObservaciones.MaxLength = 200;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(384, 65);
            txtObservaciones.TabIndex = 17;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(6, 19);
            label28.Name = "label28";
            label28.Size = new Size(87, 15);
            label28.TabIndex = 9;
            label28.Text = "Observaciones:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvTransacciones);
            groupBox6.Location = new Point(531, 262);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(855, 160);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Historial de viajes";
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Columns.AddRange(new DataGridViewColumn[] { Fecha, tipoDocu, no, Origen, Destino, Nombres, Apellidos, Edad, Imagen });
            dgvTransacciones.Location = new Point(12, 19);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.ReadOnly = true;
            dgvTransacciones.Size = new Size(837, 128);
            dgvTransacciones.TabIndex = 26;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 130;
            // 
            // tipoDocu
            // 
            tipoDocu.HeaderText = "Tipo Documento";
            tipoDocu.Name = "tipoDocu";
            tipoDocu.ReadOnly = true;
            tipoDocu.Width = 200;
            // 
            // no
            // 
            no.HeaderText = "No. Documento";
            no.Name = "no";
            no.ReadOnly = true;
            no.Width = 200;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Width = 140;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            Destino.ReadOnly = true;
            Destino.Width = 140;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            Nombres.ReadOnly = true;
            Nombres.Visible = false;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            Apellidos.Visible = false;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            Edad.Visible = false;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Visible = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dgvObservaciones);
            groupBox7.Location = new Point(535, 502);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(677, 170);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Historial de observaciones";
            // 
            // dgvObservaciones
            // 
            dgvObservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObservaciones.Columns.AddRange(new DataGridViewColumn[] { Observaciones, usuario });
            dgvObservaciones.Location = new Point(8, 22);
            dgvObservaciones.Name = "dgvObservaciones";
            dgvObservaciones.ReadOnly = true;
            dgvObservaciones.Size = new Size(658, 128);
            dgvObservaciones.TabIndex = 27;
            // 
            // Observaciones
            // 
            Observaciones.HeaderText = "Observaciones";
            Observaciones.Name = "Observaciones";
            Observaciones.ReadOnly = true;
            Observaciones.Width = 500;
            // 
            // usuario
            // 
            usuario.HeaderText = "Usuario Creador";
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
            panel1.Location = new Point(535, 428);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 62);
            panel1.TabIndex = 16;
            // 
            // contadortxtx
            // 
            contadortxtx.AutoSize = true;
            contadortxtx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contadortxtx.Location = new Point(149, 21);
            contadortxtx.Name = "contadortxtx";
            contadortxtx.Size = new Size(0, 21);
            contadortxtx.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 14);
            label15.Name = "label15";
            label15.Size = new Size(99, 15);
            label15.TabIndex = 0;
            label15.Text = "Total de entradas:";
            // 
            // button2
            // 
            button2.Location = new Point(1134, 798);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 19;
            button2.Text = "Admitir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1279, 798);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 20;
            button3.Text = "Denegar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1417, 798);
            button4.Name = "button4";
            button4.Size = new Size(132, 23);
            button4.TabIndex = 21;
            button4.Text = "Admitir/Investigacion";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1555, 798);
            button5.Name = "button5";
            button5.Size = new Size(132, 23);
            button5.TabIndex = 22;
            button5.Text = "Ver documentos";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGreen;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(1234, 518);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(152, 40);
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
            btnCancelar.Location = new Point(1234, 562);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 40);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 681);
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
        private Button button1;
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
        private TextBox txtEdad;
        private Label label2;
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
