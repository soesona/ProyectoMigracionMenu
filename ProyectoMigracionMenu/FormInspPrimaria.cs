using DevExpress.Xpo.DB.Helpers;
using ProyectoMigracionMenu;
using ProyectoMigracionMenu.Clases;
using System.Data;
using System.Data.SqlClient;

namespace interfaz_grafica_de_inspeccion_primaria
{
    public partial class FormInspPrimaria : Form
    {

        SqlServerConnection gl = new SqlServerConnection();
        string query = string.Empty;
        SqlDataAdapter da;
        DataTable ta;
        bool listo = false;
        private SqlServerConnection conexion;
        public FormInspPrimaria()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            pais();
            sexo();
            documento();
            empleo();
            motivos();
        }
        private class document
        {
            public int codigo { get; set; }
            public string des { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {

            }
        }
        private void pais()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    DataTable ta = new SqlServerConnection().ObtenerPaises();
                    if (ta.Rows.Count > 0)
                    {
                        DataTable taEmision = ta.Copy();
                        DataTable taNacionalidad = ta.Copy();
                        DataTable taDestino = ta.Copy();
                        DataTable taRes = ta.Copy();
                        DataTable taNac = ta.Copy();

                        cbPaisEmision.DataSource = taEmision;
                        cbPaisEmision.DisplayMember = "Descripcion";
                        cbPaisEmision.ValueMember = "IdPais";
                        cbPaisEmision.SelectedIndex = -1;

                        cbNacionalidad.DataSource = taNacionalidad;
                        cbNacionalidad.DisplayMember = "Descripcion";
                        cbNacionalidad.ValueMember = "IdPais";
                        cbNacionalidad.SelectedIndex = -1;

                        cbPaisDestino.DataSource = taDestino;
                        cbPaisDestino.DisplayMember = "Descripcion";
                        cbPaisDestino.ValueMember = "IdPais";
                        cbPaisDestino.SelectedIndex = -1;

                        cbPaisRes.DataSource = taRes;
                        cbPaisRes.DisplayMember = "Descripcion";
                        cbPaisRes.ValueMember = "IdPais";
                        cbPaisRes.SelectedIndex = -1;

                        cbPaisNa.DataSource = taNac;
                        cbPaisNa.DisplayMember = "Descripcion";
                        cbPaisNa.ValueMember = "IdPais";
                        cbPaisNa.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error CargaPais: " + ex.ToString());
            }
        }

        private void sexo()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    DataTable ta = new SqlServerConnection().ObtenerSexo();
                    if (ta.Rows.Count > 0)
                    {
                        cbSexo.DataSource = ta;
                        cbSexo.DisplayMember = "Descripcion";
                        cbSexo.ValueMember = "IdSexo";
                        cbSexo.SelectedIndex = -1;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
        private void motivos()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    DataTable ta = new SqlServerConnection().ObtenerMotivos();
                    if (ta.Rows.Count > 0)
                    {
                        cbMotivos.DataSource = ta;
                        cbMotivos.DisplayMember = "Descripcion";
                        cbMotivos.ValueMember = "IdMotivos";
                        cbMotivos.SelectedIndex = -1;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
        private void empleo()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    DataTable ta = new SqlServerConnection().ObtenerEmpleo();
                    if (ta.Rows.Count > 0)
                    {
                        cbTrabajo.DataSource = ta;
                        cbTrabajo.DisplayMember = "Descripcion";
                        cbTrabajo.ValueMember = "IdTrabajo";
                        cbTrabajo.SelectedIndex = -1;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
        private void documento()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    var list = new List<document>
                    {
                        new document { codigo = 1, des = "IDENTIDAD" },
                        new document { codigo = 2, des = "PASAPORTE" }
                    };
                    cbDoc.DataSource = list;
                    cbDoc.DisplayMember = "des";
                    cbDoc.ValueMember = "codigo";
                    cbDoc.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar("Trabajos");
            agregar.ShowDialog();
            empleo();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar("Pais");
            agregar.ShowDialog();
            pais();
        }

        private void btnMotivos_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar("Motivos");
            agregar.ShowDialog();
            motivos();
        }
        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private Image ObtenerImagenDesdeBaseDeDatos(string identidad)
        {
            using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT Fotografia FROM Personas WHERE Identidad = @Identidad";
                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Identidad", identidad);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Fotografia"] != DBNull.Value)
                            {
                                byte[] imgData = (byte[])reader["Fotografia"];
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    return Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
            return null;
        }

        private bool ImagesAreEqual(Image img1, Image img2)
        {

            if (img1 == null || img2 == null)
            {
                return false;
            }


            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                return false;
            }


            using (Bitmap bmp1 = new Bitmap(img1))
            using (Bitmap bmp2 = new Bitmap(img2))
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    for (int x = 0; x < bmp1.Width; x++)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
            {
                if (!gl.validaCombox(cbDoc, errorProvider1) ||
                    !gl.validaCombox(cbPaisEmision, errorProvider1) ||
                    !gl.validaCombox(cbTrabajo, errorProvider1) ||
                    !gl.validaCombox(cbPaisRes, errorProvider1) ||
                    !gl.validaCombox(cbPaisNa, errorProvider1) ||
                    !gl.validaCombox(cbPaisDestino, errorProvider1) ||
                    !gl.validaCombox(cbMotivos, errorProvider1) ||
                    !gl.validaCombox(cbSexo, errorProvider1) ||
                    !gl.validaCombox(cbNacionalidad, errorProvider1))
                {
                    return;
                }

                if (string.IsNullOrEmpty(txtApellido.Text) ||
                    string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtIdentidad.Text))
                {
                    MessageBox.Show("Campos obligatorios Vacios. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (pic.Image == null)
                {
                    MessageBox.Show("La imagen es obligatoria. Por favor, seleccione una imagen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                Image imagenOriginal = ObtenerImagenDesdeBaseDeDatos(txtIdentidad.Text);


                if (imagenOriginal != null && ImagesAreEqual(pic.Image, imagenOriginal))
                {
                    MessageBox.Show("La imagen cargada ya existe. Debe proporcionar una imagen reciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                byte[] fotografia = ImageToByteArray(pic.Image);



                SqlCommand msc = new SqlCommand("InsertarPersona", sqlcon);
                msc.CommandType = CommandType.StoredProcedure;
                msc.Parameters.AddWithValue("@TipoDocumento", cbDoc.SelectedValue);
                msc.Parameters.AddWithValue("@Identidad", txtIdentidad.Text);
                msc.Parameters.AddWithValue("@Nombres", txtNombre.Text);
                msc.Parameters.AddWithValue("@Apellidos", txtApellido.Text);
                msc.Parameters.AddWithValue("@IdSexo", cbSexo.SelectedValue);
                msc.Parameters.AddWithValue("@IdPaisEmision", cbPaisEmision.SelectedValue);
                msc.Parameters.AddWithValue("@UsuarioCreado", Login.UsuarioActual.Nombre);
                msc.Parameters.AddWithValue("@f_regCreado", DateTime.Now);
                msc.Parameters.AddWithValue("@f_regFinal", dtpfechaVenci.Value);
                msc.Parameters.AddWithValue("@Estado", 1);
                msc.Parameters.AddWithValue("@IdPaisNacimiento", cbPaisNa.SelectedValue);
                msc.Parameters.AddWithValue("@IdPaisResidencia", cbPaisRes.SelectedValue);
                msc.Parameters.AddWithValue("@Observacion", txtObservaciones.Text);
                msc.Parameters.AddWithValue("@LugarResidencia", txtResidencia.Text);
                msc.Parameters.AddWithValue("@f_Nacimiento", dtpFechaNa.Value);
                msc.Parameters.AddWithValue("@IdMotivoViaje", cbMotivos.SelectedValue);
                msc.Parameters.AddWithValue("@IdPaisDestino", cbPaisDestino.SelectedValue);
                msc.Parameters.AddWithValue("@IdTrabajo", cbTrabajo.SelectedValue);
                msc.Parameters.AddWithValue("@Fotografia", fotografia);
                msc.Parameters.AddWithValue("@diasOtogados", txtEstadia.Text);
                msc.Parameters.AddWithValue("@DocumentoRobado", chk1.Checked);
                msc.Parameters.AddWithValue("@DocumentoVencido", chk2.Checked);
                msc.Parameters.AddWithValue("@Interpol", chk4.Checked);
                msc.Parameters.AddWithValue("@AlertaMigratoria", chk3.Checked);
                msc.Parameters.AddWithValue("@Prechequeo", chk5.Checked);

                msc.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con éxito. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancelar.PerformClick();
            }
        }

        private void btnfotografia_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "Imagenes JPG,PNG|*.jpg;*.png";
                f.ShowDialog();
                if (f.FileName.Equals("") == false)
                {
                    System.IO.FileInfo f2 = new System.IO.FileInfo(f.FileName);
                    if ((f2.Length / 1024) > 120)
                    {
                        throw new Exception("¡El tamaño del archivo no puede superar los 120 kilobyte!");
                    }
                    else
                    {
                        pic.Load(f.FileName);
                    }
                }
                else
                {
                    pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }



        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentidad.Text))
                {
                    MessageBox.Show("Por favor, ingresa un número de documento válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {

                    query = "SELECT FORMAT(A.f_regCreado, 'dd-MM-yyyy') Fecha, " +
                            "CASE WHEN TipoDocumento = 1 THEN 'Identidad' " +
                            "WHEN TipoDocumento = 2 THEN 'Pasaporte' ELSE 'Otro' END tipoDocu, " +
                            "A.Identidad no, E.Descripcion Origen, I.Descripcion Destino, " +
                            "A.Observacion Observaciones, A.UsuarioCreado usuario, A.Nombres, A.Apellidos, " +
                            "A.f_Nacimiento, A.IdSexo, A.IdPaisNacimiento, " +
                            "A.IdPaisEmision, A.f_regFinal, A.TipoDocumento " +
                            "FROM Personas A " +
                            "INNER JOIN Pais E ON A.IdPaisResidencia = E.IdPais " +
                            "INNER JOIN Pais I ON A.IdPaisDestino = I.IdPais " +
                            "WHERE A.Identidad = @Identidad";

                    using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@Identidad", txtIdentidad.Text.Trim());

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable personas = new DataTable();
                            adapter.Fill(personas);

                            if (personas.Rows.Count > 0)
                            {
                                foreach (DataRow row in personas.Rows)
                                {
                                    dgvTransacciones.Rows.Add(row["Fecha"].ToString(), row["tipoDocu"].ToString(), row["no"].ToString(), row["Origen"].ToString(), row["Destino"].ToString());
                                    dgvObservaciones.Rows.Add(row["Observaciones"].ToString(), row["usuario"].ToString());
                                }


                                txtNombre.Text = personas.Rows[0]["Nombres"].ToString();
                                txtApellido.Text = personas.Rows[0]["Apellidos"].ToString();
                                dtpFechaNa.Value = Convert.ToDateTime(personas.Rows[0]["f_Nacimiento"]);
                                cbSexo.SelectedValue = personas.Rows[0]["IdSexo"];
                                cbNacionalidad.SelectedValue = personas.Rows[0]["IdPaisNacimiento"];
                                cbDoc.SelectedValue = personas.Rows[0]["TipoDocumento"];
                                cbPaisEmision.SelectedValue = personas.Rows[0]["IdPaisEmision"];
                                dtpfechaVenci.Value = Convert.ToDateTime(personas.Rows[0]["f_regFinal"]);

                                contadortxtx.Text = personas.Rows.Count.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron registros para el número de documento proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }


                    string queryUltimoRegistro = "SELECT TOP 1 A.Fotografia Imagen FROM Personas A " +
                                                 "WHERE A.Identidad = @Identidad " +
                                                 "ORDER BY A.f_regCreado DESC";

                    using (SqlCommand cmdUltimo = new SqlCommand(queryUltimoRegistro, sqlcon))
                    {
                        cmdUltimo.Parameters.AddWithValue("@Identidad", txtIdentidad.Text.Trim());

                        byte[] imagenBytes = cmdUltimo.ExecuteScalar() as byte[];
                        if (imagenBytes != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imagenBytes))
                            {
                                pic.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
                        }
                    }

                    listo = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        private void btnCancelarInfo_Click(object sender, EventArgs e)
        {
            listo = false;
            dgvObservaciones.DataSource = null;
            dgvObservaciones.Rows.Clear();
            dgvTransacciones.DataSource = null;
            dgvTransacciones.Rows.Clear();
            contadortxtx.Text = "";
            btnCancelar.PerformClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gl.limpiarcampos(Documentoviaje);
            gl.limpiarcampos(groupBox3);
            gl.limpiarcampos(groupBox4);
            gl.limpiarcampos(groupBox4);
            gl.limpiarcampos(datosdeviaje);
            gl.limpiarcampos(groupBox2);
            gl.limpiarcampos(groupBox5);
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
            listo = false;
            dgvObservaciones.DataSource = null;
            dgvObservaciones.Rows.Clear();
            dgvTransacciones.DataSource = null;
            dgvTransacciones.Rows.Clear();
            contadortxtx.Text = "";
            errorProvider1.Clear();
        }

      
    }
}
