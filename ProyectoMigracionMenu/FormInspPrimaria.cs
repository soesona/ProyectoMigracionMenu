using ProyectoMigracionMenu;
using ProyectoMigracionMenu.Clases;
using System.Data;
using System.Data.SqlClient;
using System.IO;

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
                       
                        DataTable taDestino = ta.Copy();
                        DataTable taRes = ta.Copy();
                        DataTable taNac = ta.Copy();

                        cbPaisEmision.DataSource = taEmision;
                        cbPaisEmision.DisplayMember = "Descripcion";
                        cbPaisEmision.ValueMember = "IdPais";
                        cbPaisEmision.SelectedIndex = -1;

                       

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


                cbDoc.SelectedIndexChanged += cbDoc_SelectedIndexChanged;
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

            // compara pixel a pixel 
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
            btnGuardar.Enabled = false;


            if (!gl.validaCombox(cbDoc, errorProvider1) ||
                !gl.validaCombox(cbPaisEmision, errorProvider1) ||
                !gl.validaCombox(cbTrabajo, errorProvider1) ||
                !gl.validaCombox(cbPaisRes, errorProvider1) ||
                !gl.validaCombox(cbPaisNa, errorProvider1) ||
                !gl.validaCombox(cbPaisDestino, errorProvider1) ||
                !gl.validaCombox(cbMotivos, errorProvider1) ||
                !gl.validaCombox(cbSexo, errorProvider1))
            {
                btnGuardar.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                errorProvider1.SetError(txtApellido, "No puede estar vacío.");
                btnGuardar.Enabled = true;
                return;
            }

            if (dtpFechaNa.Value.Date >= DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpFechaNa, "La fecha de nacimiento no puede ser hoy ni una fecha futura.");
                btnGuardar.Enabled = true;
                return;
            }
            else
            {
                errorProvider1.SetError(dtpFechaNa, "");
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                errorProvider1.SetError(txtNombre, "No puede estar vacío.");
                btnGuardar.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIdentidad.Text))
            {
                MessageBox.Show("El campo 'Numero de documento' no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdentidad.Focus();
                errorProvider1.SetError(txtIdentidad, "No puede estar vacío.");
                btnGuardar.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtResidencia.Text))
            {
                MessageBox.Show("El campo 'Residencia' no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResidencia.Focus();
                errorProvider1.SetError(txtResidencia, "No puede estar vacío.");
                btnGuardar.Enabled = true;
                return;
            }

            if (!imagenCargada || ImagesAreEqual(pic.Image, ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_))
            {
                errorProvider1.SetError(pic, "Debe seleccionar una imagen válida.");
                btnGuardar.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                MessageBox.Show("El campo 'Observaciones' no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtObservaciones.Focus();
                errorProvider1.SetError(txtObservaciones, "No puede estar vacío.");
                btnGuardar.Enabled = true;
                return;
            }

            if (txtNombre.Text.Length < 3 || txtApellido.Text.Length < 3)
            {
                MessageBox.Show("Los campos de nombre y apellido deben contener al menos 3 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnGuardar.Enabled = true;
                return;
            }

            if (txtResidencia.Text.Length < 20 || txtObservaciones.Text.Length < 20)
            {
                MessageBox.Show("Los campos de residencia y observaciones deben contener al menos 20 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnGuardar.Enabled = true;
                return;
            }

            Image imagenOriginal = ObtenerImagenDesdeBaseDeDatos(txtIdentidad.Text);
            if (imagenOriginal != null && ImagesAreEqual(pic.Image, imagenOriginal))
            {
                MessageBox.Show("La imagen cargada ya existe. Debe proporcionar una imagen reciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnGuardar.Enabled = true;
                return;
            }

            byte[] fotografia = ImageToByteArray(pic.Image);

            try
            {
               
                bool resultado = ClaseInspPrimaria.InsertarPersona(
                    cbDoc.SelectedValue.ToString(),
                    txtIdentidad.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    (int)cbSexo.SelectedValue,
                    (int)cbPaisEmision.SelectedValue,
                    Login.UsuarioActual.Nombre,
                    DateTime.Now,
                    dtpfechaVenci.Value,
                    1, 
                    (int)cbPaisNa.SelectedValue,
                    (int)cbPaisRes.SelectedValue,
                    txtObservaciones.Text,
                    txtResidencia.Text,
                    dtpFechaNa.Value,
                    (int)cbMotivos.SelectedValue,
                    (int)cbPaisDestino.SelectedValue,
                    (int)cbTrabajo.SelectedValue,
                    fotografia,
                    int.Parse(txtEstadia.Text),
                    chk1.Checked,
                    chk2.Checked,
                    chk4.Checked,
                    chk3.Checked,
                    chk5.Checked
                );

                if (resultado)
                {
                    MessageBox.Show("Registro agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancelar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private bool imagenCargada = false;
        private void btnfotografia_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "Imágenes JPG,PNG|*.jpg;*.png";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileInfo f2 = new System.IO.FileInfo(f.FileName);
                    if ((f2.Length / 1024) > 120)
                    {
                        throw new Exception("¡El tamaño del archivo no puede superar los 120 kilobytes!");
                    }
                    else
                    {
                        pic.Load(f.FileName);
                        imagenCargada = true; 
                    }
                }
                else
                {
                    pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
                    imagenCargada = false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int contadorRechazos = 0; 
                    int contadortxt = 0; 

                    if (listo == false)
                    {
                        query = "SELECT FORMAT(A.f_regCreado, 'dd-MM-yyyy') Fecha, " +
                                "CASE WHEN TipoDocumento = 1 THEN 'Identidad' " +
                                "WHEN TipoDocumento = 2 THEN 'Pasaporte' ELSE 'Otro' END tipoDocu, " +
                                "A.Identidad no, E.Descripcion Origen, I.Descripcion Destino, " +
                                "A.Observacion Observaciones, A.UsuarioCreado usuario, A.Nombres, A.Apellidos, " +
                                "A.Fotografia Imagen, A.f_Nacimiento, A.IdSexo, A.IdPaisNacimiento, " +
                                "A.IdPaisEmision, A.f_regFinal, A.TipoDocumento, A.Estado " + 
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
                                        
                                        if (row["Estado"] != DBNull.Value)
                                        {
                                            int estado = Convert.ToInt32(row["Estado"]);
                                            if (estado == 0) contadorRechazos++; 
                                            if (estado == 2) contadortxt++;      
                                        }

                                        
                                        dgvTransacciones.Rows.Add(row["Fecha"].ToString(), row["tipoDocu"].ToString(), row["no"].ToString(), row["Origen"].ToString(), row["Destino"].ToString());
                                        dgvObservaciones.Rows.Add(row["Observaciones"].ToString(), row["usuario"].ToString());
                                    }

                                 
                                    txtNombre.Text = personas.Rows[0]["Nombres"].ToString();
                                    txtApellido.Text = personas.Rows[0]["Apellidos"].ToString();
                                    dtpFechaNa.Value = Convert.ToDateTime(personas.Rows[0]["f_Nacimiento"]);
                                    cbSexo.SelectedValue = personas.Rows[0]["IdSexo"];
                                    cbPaisNa.SelectedValue = personas.Rows[0]["IdPaisNacimiento"];
                                    cbDoc.SelectedValue = personas.Rows[0]["TipoDocumento"];
                                    cbPaisEmision.SelectedValue = personas.Rows[0]["IdPaisEmision"];
                                    dtpfechaVenci.Value = Convert.ToDateTime(personas.Rows[0]["f_regFinal"]);

                                   
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

                                   
                                    contadorNegadoTxt.Text = contadorRechazos.ToString(); 

                                    contadortxtx.Text = Convert.ToString(contadortxt);

                                    listo = true;
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron registros para el número de documento proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
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
            contadortxtx.Text = "";
            btnCancelar.PerformClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gl.limpiarcampos(Documentoviaje);
            
            cbTrabajo.SelectedIndex = -1;
            cbPaisRes.SelectedIndex = -1;
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
            contadorNegadoTxt.Text = ""; 
            errorProvider1.Clear();
            dtpFechaNa.Value = DateTime.Now;
            dtpfechaVenci.Value = DateTime.Now; 
        }

        private void cbDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDocument = cbDoc.SelectedItem as document;

            if (selectedDocument != null && selectedDocument.codigo == 2)
            {

                txtIdentidad.TextChanged -= txtIdentidad_TextChanged;
                txtIdentidad.TextChanged -= txtIdentidad_TextChangedPasaporte;


                txtIdentidad.TextChanged += txtIdentidad_TextChangedPasaporte;
            }
            else
            {

                txtIdentidad.TextChanged -= txtIdentidad_TextChanged;
                txtIdentidad.TextChanged -= txtIdentidad_TextChangedPasaporte;


                txtIdentidad.TextChanged += txtIdentidad_TextChanged;
            }
        }


        

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {
            string texto = txtIdentidad.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^\d{0,13}$"))
            {
                MessageBox.Show("Solo se permiten hasta 13 dígitos numéricos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentidad.Text = texto.Substring(0, texto.Length - 1);
                txtIdentidad.SelectionStart = txtIdentidad.Text.Length;
            }
        }


        private void txtIdentidad_TextChangedPasaporte(object sender, EventArgs e)
        {
            string texto = txtIdentidad.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z0-9]{0,13}$"))  
            {
                MessageBox.Show("Solo se permiten letras y números. Máximo 13 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentidad.Text = texto.Substring(0, texto.Length - 1);
                txtIdentidad.SelectionStart = txtIdentidad.Text.Length;
            }
        }



        

        private void txtResidencia_TextChanged(object sender, EventArgs e)
{
    string texto = txtResidencia.Text;


            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"\s{2,}", " ");
           txtResidencia.Text = texto;
            txtResidencia.SelectionStart = texto.Length;

            if (!ValidarCaracteresPermitidos(texto))
    {
        MostrarAdvertencia("Solo se permiten letras, números, espacios, comas, puntos, el signo # y vocales con tilde. Máximo 80 caracteres.");
        CorregirTexto(txtResidencia);
        return;
    }

    if (ContieneTresCaracteresIgualesConsecutivos(texto))
    {
        MostrarAdvertencia("No se permiten tres caracteres iguales consecutivos.");
        CorregirTexto(txtResidencia);
        return;
    }

   
    if (!ValidarLongitudMinima(texto, 20))
    {
        errorProvider1.SetError(txtResidencia, "Debe contener al menos 20 caracteres (sin contar espacios).");
    }
    else
    {
        errorProvider1.Clear();
    }
}

private bool ValidarCaracteresPermitidos(string texto)
{
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z0-9.,#áéíóúÁÉÍÓÚ]*(\s{0,1}[a-zA-Z0-9.,#áéíóúÁÉÍÓÚ]*){0,150}$");
        }

private bool ContieneTresCaracteresIgualesConsecutivos(string texto)
{
    return System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1");
}

private bool ValidarLongitudMinima(string texto, int longitudMinima)
{
    string textoSinEspacios = texto.Replace(" ", ""); 
    return textoSinEspacios.Length >= longitudMinima;
}

private void MostrarAdvertencia(string mensaje)
{
    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}

private void CorregirTexto(TextBox textBox)
{
    if (textBox.Text.Length > 0)
    {
        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
        textBox.SelectionStart = textBox.Text.Length;
    }
}






        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

            string texto = txtObservaciones.Text;

            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"\s{2,}", " ");
            txtObservaciones.Text = texto;
            txtObservaciones.SelectionStart = texto.Length;



            if (string.IsNullOrWhiteSpace(texto))
            {
                errorProvider1.SetError(txtObservaciones, "El campo 'Observaciones' no puede estar vacío.");
                return;
            }

            if (!ValidarCaracteresPermitidos(texto))
            {
                MostrarAdvertencia("Solo se permiten letras, números, espacios, puntos, comas y vocales con tilde. Máximo 150 caracteres.");
                CorregirTexto(txtObservaciones);
                return;
            }

            if (ContieneTresCaracteresIgualesConsecutivos(texto))
            {
                MostrarAdvertencia("No se permiten tres caracteres iguales consecutivos.");
                CorregirTexto(txtObservaciones);
                return;
            }

            if (!ValidarLongitudMinima(texto, 20))
            {
                errorProvider1.SetError(txtObservaciones, "Debe contener al menos 20 caracteres (sin contar espacios).");
            }
            else
            {
                errorProvider1.Clear();
            }
        }



        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;

            
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]{0,20}$"))
            {
                MessageBox.Show("Solo se permiten letras y espacios. Entre 3 y 20 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Text = texto.Substring(0, texto.Length - 1);
                txtNombre.SelectionStart = txtNombre.Text.Length;
                return;
            }

           
            if (System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1"))
            {
                MessageBox.Show("No se permiten tres caracteres iguales consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Text = texto.Substring(0, texto.Length - 1);
                txtNombre.SelectionStart = txtNombre.Text.Length;
                return;
            }

            if (texto.Length > 0 && texto.Length < 3)
            {
                errorProvider1.SetError(txtNombre, "Debe contener al menos 3 caracteres.");
            }
            else if (texto.Length >= 3 && texto.Length <= 20)
            {
                errorProvider1.Clear();
            }
        }




     

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            string texto = txtApellido.Text;

          
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]{0,20}$"))
            {
                MessageBox.Show("Solo se permiten letras y espacios. Entre 3 y 20 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Text = texto.Substring(0, texto.Length - 1);
                txtApellido.SelectionStart = txtApellido.Text.Length;
                return;
            }

           
            if (System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1"))
            {
                MessageBox.Show("No se permiten tres caracteres iguales consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Text = texto.Substring(0, texto.Length - 1);
                txtApellido.SelectionStart = txtApellido.Text.Length;
                return;
            }

            
            if (texto.Length > 0 && texto.Length < 3)
            {
                errorProvider1.SetError(txtApellido, "Debe contener al menos 3 caracteres.");
            }
            else if (texto.Length >= 3 && texto.Length <= 20)
            {
                errorProvider1.Clear();
            }
        }





       
    }
}
