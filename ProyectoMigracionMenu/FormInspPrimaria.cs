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
                        new document { codigo = 1, des = "PASAPORTE" }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
            {
                if (!gl.validaCombox(cbDoc, errorProvider1) || !gl.validaCombox(cbPaisEmision, errorProvider1) || !gl.validaCombox(cbTrabajo, errorProvider1) || !gl.validaCombox(cbPaisRes, errorProvider1) || !gl.validaCombox(cbPaisNa, errorProvider1) || !gl.validaCombox(cbPaisDestino, errorProvider1) || !gl.validaCombox(cbMotivos, errorProvider1) || !gl.validaCombox(cbSexo, errorProvider1) || !gl.validaCombox(cbNacionalidad, errorProvider1))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtIdentidad.Text))
                {
                    MessageBox.Show("Campos obligatorios Vacios. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                byte[] fotografia = ImageToByteArray(pic.Image);

                SqlCommand msc = new SqlCommand("InsertarPersona ", sqlcon);
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
                msc.Parameters.AddWithValue("@Edad", txtEdad.Text);
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
                        throw new Exception("¡El tamaño del archivo no puede superar los 60 kilobyte!");
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

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            gl.validarInt(txtEdad, errorProvider1);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    int contador = 0;
                    if (listo == false)
                    {
                        query = "SELECT FORMAT(A.f_regCreado, 'dd-MM-yyyy') Fecha, CASE WHEN TipoDocumento = 1 THEN 'Identidad' WHEN TipoDocumento = 2 THEN 'Pasaporte' ELSE 'Otro'" +
                                " END tipoDocu, A.Identidad no, E.Descripcion Origen, I.Descripcion Destino, A.Observacion Observaciones, A.UsuarioCreado usuario, A.Nombres, A.Apellidos, A.Edad, A.Fotografia Imagen  FROM Personas A " +
                                " INNER JOIN Pais E ON A.IdPaisResidencia = E.IdPais " +
                                " INNER JOIN Pais I ON A.IdPaisDestino = I.IdPais where (A.Identidad like '%" + txtIdentidad.Text.Trim() + "%')";
                        DataTable personas = gl.retornaTabla(query, sqlcon);
                        if (personas.Rows.Count > 0)
                        {
                            foreach (DataRow row in personas.Rows)
                            {
                                dgvTransacciones.Rows.Add(row["Fecha"].ToString(), row["tipoDocu"].ToString(), row["no"].ToString(), row["Origen"].ToString(), row["Destino"].ToString());
                                dgvObservaciones.Rows.Add(row["Observaciones"].ToString(), row["usuario"].ToString());
                                contador++;
                            }
                            txtNombre.Text = personas.Rows[0]["Nombres"].ToString();
                            txtApellido.Text = personas.Rows[0]["Apellidos"].ToString();
                            txtEdad.Text = personas.Rows[0]["Edad"].ToString();
                            contadortxtx.Text = Convert.ToString(contador);
                            if (personas.Rows[0]["Imagen"] != DBNull.Value)
                            {
                                byte[] imagenBytes = (byte[])personas.Rows[0]["Imagen"];
                                using (MemoryStream ms = new MemoryStream(imagenBytes))
                                {
                                    pic.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
                            }

                            listo = true;
                        }
                    }
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
            errorProvider1.Clear();
        }
    }
}
