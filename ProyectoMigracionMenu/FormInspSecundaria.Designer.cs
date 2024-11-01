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
            txtTipoDoc = new TextBox();
            txtPaisEmision = new TextBox();
            txtRegistro = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            pic = new PictureBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Doc = new DataGridViewTextBoxColumn();
            paisEmisor = new DataGridViewTextBoxColumn();
            identidad = new DataGridViewTextBoxColumn();
            FechaV = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 27);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 27);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Registro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(843, 27);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha Solicitud:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 130);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Apellido:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 76);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 10;
            label11.Text = "Pais de emision:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 130);
            label12.Name = "label12";
            label12.Size = new Size(110, 15);
            label12.TabIndex = 11;
            label12.Text = "No. de documento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(468, 76);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 12;
            label13.Text = "Nombre:";
            // 
            // txtIdentidad
            // 
            txtIdentidad.Enabled = false;
            txtIdentidad.Location = new Point(160, 125);
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(234, 23);
            txtIdentidad.TabIndex = 18;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(951, 24);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(117, 23);
            dtpFecha.TabIndex = 23;
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.AllowUserToAddRows = false;
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Columns.AddRange(new DataGridViewColumn[] { Id, Doc, paisEmisor, identidad, FechaV, Nombre, Sexo, Estado, Apellido, Imagen });
            dgvTransacciones.Location = new Point(12, 177);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.ReadOnly = true;
            dgvTransacciones.Size = new Size(1461, 451);
            dgvTransacciones.TabIndex = 28;
            dgvTransacciones.SelectionChanged += dgvTransacciones_SelectionChanged;
            // 
            // txtTipoDoc
            // 
            txtTipoDoc.Enabled = false;
            txtTipoDoc.Location = new Point(160, 24);
            txtTipoDoc.Name = "txtTipoDoc";
            txtTipoDoc.Size = new Size(234, 23);
            txtTipoDoc.TabIndex = 29;
            // 
            // txtPaisEmision
            // 
            txtPaisEmision.Enabled = false;
            txtPaisEmision.Location = new Point(160, 73);
            txtPaisEmision.Name = "txtPaisEmision";
            txtPaisEmision.Size = new Size(234, 23);
            txtPaisEmision.TabIndex = 30;
            // 
            // txtRegistro
            // 
            txtRegistro.Enabled = false;
            txtRegistro.Location = new Point(538, 24);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(234, 23);
            txtRegistro.TabIndex = 31;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(538, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 23);
            txtNombre.TabIndex = 32;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(538, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(234, 23);
            txtApellido.TabIndex = 33;
            // 
            // pic
            // 
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
            pic.Location = new Point(1299, 12);
            pic.Name = "pic";
            pic.Size = new Size(158, 159);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.TabIndex = 34;
            pic.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(1026, 108);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 40);
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
            btnGuardar.Location = new Point(843, 108);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(152, 40);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Id
            // 
            Id.HeaderText = "No. Transacción";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Doc
            // 
            Doc.HeaderText = "Tipo Documento";
            Doc.Name = "Doc";
            Doc.ReadOnly = true;
            Doc.Width = 200;
            // 
            // paisEmisor
            // 
            paisEmisor.HeaderText = "Pais Emisor";
            paisEmisor.Name = "paisEmisor";
            paisEmisor.ReadOnly = true;
            paisEmisor.Width = 200;
            // 
            // identidad
            // 
            identidad.HeaderText = "No. Documento";
            identidad.Name = "identidad";
            identidad.ReadOnly = true;
            identidad.Width = 250;
            // 
            // FechaV
            // 
            FechaV.HeaderText = "Fecha Vencimiento";
            FechaV.Name = "FechaV";
            FechaV.ReadOnly = true;
            FechaV.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 150;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 200;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Visible = false;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Visible = false;
            // 
            // FormInspSecundaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1485, 640);
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Doc;
        private DataGridViewTextBoxColumn paisEmisor;
        private DataGridViewTextBoxColumn identidad;
        private DataGridViewTextBoxColumn FechaV;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Imagen;
    }
}
