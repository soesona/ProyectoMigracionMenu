namespace Inspeccionsecundaria
{
    partial class FormInspSecundaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInspSecundaria));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtIdentidad = new TextBox();
            dtpFecha = new DateTimePicker();
            dgvTransacciones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Doc = new DataGridViewTextBoxColumn();
            paisEmisor = new DataGridViewTextBoxColumn();
            identidad = new DataGridViewTextBoxColumn();
            FechaV = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Observacion = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            txtTipoDoc = new TextBox();
            txtPaisEmision = new TextBox();
            txtRegistro = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            pic = new PictureBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            txtObservacion = new TextBox();
            label6 = new Label();
            txtAlertas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 36);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(536, 36);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Registro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(915, 36);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha solicitud:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(535, 173);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Apellido:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(61, 101);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 10;
            label11.Text = "País de emision:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 173);
            label12.Name = "label12";
            label12.Size = new Size(136, 20);
            label12.TabIndex = 11;
            label12.Text = "No. de documento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(535, 101);
            label13.Name = "label13";
            label13.Size = new Size(67, 20);
            label13.TabIndex = 12;
            label13.Text = "Nombre:";
            // 
            // txtIdentidad
            // 
            txtIdentidad.Enabled = false;
            txtIdentidad.Location = new Point(183, 167);
            txtIdentidad.Margin = new Padding(3, 4, 3, 4);
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(267, 27);
            txtIdentidad.TabIndex = 18;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(1042, 32);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(133, 27);
            dtpFecha.TabIndex = 23;
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.AllowUserToAddRows = false;
            dgvTransacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransacciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Columns.AddRange(new DataGridViewColumn[] { Id, Doc, paisEmisor, identidad, FechaV, Nombre, Sexo, Observacion, Apellido, Imagen });
            dgvTransacciones.Location = new Point(14, 308);
            dgvTransacciones.Margin = new Padding(3, 4, 3, 4);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.ReadOnly = true;
            dgvTransacciones.RowHeadersWidth = 51;
            dgvTransacciones.Size = new Size(1578, 529);
            dgvTransacciones.TabIndex = 28;
            dgvTransacciones.SelectionChanged += dgvTransacciones_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "No. Transacción";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Doc
            // 
            Doc.HeaderText = "Tipo Documento";
            Doc.MinimumWidth = 6;
            Doc.Name = "Doc";
            Doc.ReadOnly = true;
            // 
            // paisEmisor
            // 
            paisEmisor.HeaderText = "Pais Emisor";
            paisEmisor.MinimumWidth = 6;
            paisEmisor.Name = "paisEmisor";
            paisEmisor.ReadOnly = true;
            // 
            // identidad
            // 
            identidad.HeaderText = "No. Documento";
            identidad.MinimumWidth = 6;
            identidad.Name = "identidad";
            identidad.ReadOnly = true;
            // 
            // FechaV
            // 
            FechaV.HeaderText = "Fecha Vencimiento";
            FechaV.MinimumWidth = 6;
            FechaV.Name = "FechaV";
            FechaV.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // Observacion
            // 
            Observacion.HeaderText = "Observación";
            Observacion.MinimumWidth = 6;
            Observacion.Name = "Observacion";
            Observacion.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Visible = false;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.MinimumWidth = 6;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Visible = false;
            // 
            // txtTipoDoc
            // 
            txtTipoDoc.Enabled = false;
            txtTipoDoc.Location = new Point(183, 32);
            txtTipoDoc.Margin = new Padding(3, 4, 3, 4);
            txtTipoDoc.Name = "txtTipoDoc";
            txtTipoDoc.Size = new Size(267, 27);
            txtTipoDoc.TabIndex = 29;
            // 
            // txtPaisEmision
            // 
            txtPaisEmision.Enabled = false;
            txtPaisEmision.Location = new Point(183, 97);
            txtPaisEmision.Margin = new Padding(3, 4, 3, 4);
            txtPaisEmision.Name = "txtPaisEmision";
            txtPaisEmision.Size = new Size(267, 27);
            txtPaisEmision.TabIndex = 30;
            // 
            // txtRegistro
            // 
            txtRegistro.Enabled = false;
            txtRegistro.Location = new Point(615, 32);
            txtRegistro.Margin = new Padding(3, 4, 3, 4);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(267, 27);
            txtRegistro.TabIndex = 31;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(615, 97);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 27);
            txtNombre.TabIndex = 32;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(615, 167);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(267, 27);
            txtApellido.TabIndex = 33;
            // 
            // pic
            // 
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
            pic.Location = new Point(1350, 32);
            pic.Margin = new Padding(3, 4, 3, 4);
            pic.Name = "pic";
            pic.Size = new Size(213, 250);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 34;
            pic.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(1147, 222);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 42);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Rechazar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGreen;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(967, 222);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(162, 42);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Aceptar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 235);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 37;
            label1.Text = "Observación:";
            // 
            // txtObservacion
            // 
            txtObservacion.Enabled = false;
            txtObservacion.Location = new Point(183, 222);
            txtObservacion.Margin = new Padding(3, 4, 3, 4);
            txtObservacion.MaxLength = 200;
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(699, 64);
            txtObservacion.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(967, 104);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 39;
            label6.Text = "Alertas:";
            // 
            // txtAlertas
            // 
            txtAlertas.Enabled = false;
            txtAlertas.Location = new Point(1042, 97);
            txtAlertas.Margin = new Padding(3, 4, 3, 4);
            txtAlertas.MaxLength = 200;
            txtAlertas.Multiline = true;
            txtAlertas.Name = "txtAlertas";
            txtAlertas.Size = new Size(267, 64);
            txtAlertas.TabIndex = 40;
            // 
            // FormInspSecundaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1697, 853);
            Controls.Add(txtAlertas);
            Controls.Add(label6);
            Controls.Add(txtObservacion);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(pic);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRegistro);
            Controls.Add(txtPaisEmision);
            Controls.Add(txtTipoDoc);
            Controls.Add(dgvTransacciones);
            Controls.Add(dtpFecha);
            Controls.Add(txtIdentidad);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInspSecundaria";
            Text = "Inspección secundaria";
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtIdentidad;
        private DateTimePicker dtpFecha;
        private DataGridView dgvTransacciones;
        private TextBox txtTipoDoc;
        private TextBox txtPaisEmision;
        private TextBox txtRegistro;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private PictureBox pic;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtObservacion;
        private Label label6;
        private TextBox txtAlertas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Doc;
        private DataGridViewTextBoxColumn paisEmisor;
        private DataGridViewTextBoxColumn identidad;
        private DataGridViewTextBoxColumn FechaV;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Observacion;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Imagen;
    }
}
