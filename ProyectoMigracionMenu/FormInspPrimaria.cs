using ProyectoMigracionMenu;
using ProyectoMigracionMenu.Clases;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace interfaz_grafica_de_inspeccion_primaria
{
    public partial class FormInspPrimaria : Form
    {
        SqlServerConnection gl = new SqlServerConnection(); // Clase para manejar la conexión a la base de datos.
        string query = string.Empty; // Consulta SQL a utilizar.
        SqlDataAdapter da;
        DataTable ta;
        bool listo = false;
        private SqlServerConnection conexion; // Conexión específica para esta instancia.

        public FormInspPrimaria()
        {
            InitializeComponent(); // Inicializa el formulario y sus componentes.
            this.DoubleBuffered = true; // Mejora la visualización en el formulario.
            pais(); // Carga los datos relacionados con países en los controles.
            sexo(); // Inicializa el combobox de sexos desde la base de datos.
            documento(); // Configura los tipos de documentos disponibles.
            empleo(); // Carga la lista de empleos en el sistema.
            motivos(); // Carga las razones o motivos del viaje.
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
                    DataTable ta = new SqlServerConnection().ObtenerPaises(); // Método para obtener datos de países.
                    if (ta.Rows.Count > 0)
                    {
                        DataTable taEmision = ta.Copy(); // Copias separadas para cada uso de país.
                        DataTable taDestino = ta.Copy();
                        DataTable taRes = ta.Copy();
                        DataTable taNac = ta.Copy();

                        cbPaisEmision.DataSource = taEmision; // Población del combo de país de emisión.
                        cbPaisEmision.DisplayMember = "Descripcion";
                        cbPaisEmision.ValueMember = "IdPais";
                        cbPaisEmision.SelectedIndex = -1;

                        // Similar configuración para los otros controles de país.
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
                MessageBox.Show("Error CargaPais: " + ex.ToString()); // Manejador de errores.
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
            frmAgregar agregar = new frmAgregar("Trabajos"); // Abre el formulario para agregar un nuevo trabajo.
            agregar.ShowDialog(); // Pausa la ejecución hasta que el formulario se cierre.
            empleo(); // Actualiza la lista de empleos después de agregar un nuevo elemento.
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar("Pais"); // Abre el formulario para agregar un nuevo país.
            agregar.ShowDialog(); // Pausa la ejecución hasta que el formulario se cierre.
            pais(); // Actualiza la lista de países después de agregar un nuevo elemento.
        }

        private void btnMotivos_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar("Motivos");
            agregar.ShowDialog();
            motivos();
        }

        // convierte un objeto de tipo Image a un arreglo de bytes para guardarlo a la base de datos 
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

            // compara pixel a pixel las imagenes 
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
            btnGuardar.Enabled = false; // Desactiva el botón temporalmente para evitar múltiples envíos.
            errorProvider1.Clear(); // Limpia los errores visuales previos.

            // Validación inicial de los comboboxes obligatorios.
            if (!gl.validaCombox(cbDoc, errorProvider1) ||
                !gl.validaCombox(cbPaisEmision, errorProvider1) ||
                !gl.validaCombox(cbTrabajo, errorProvider1) ||
                !gl.validaCombox(cbPaisRes, errorProvider1) ||
                !gl.validaCombox(cbPaisNa, errorProvider1) ||
                !gl.validaCombox(cbPaisDestino, errorProvider1) ||
                !gl.validaCombox(cbMotivos, errorProvider1) ||
                !gl.validaCombox(cbSexo, errorProvider1))
            {
                btnGuardar.Enabled = true; // Reactiva el botón si hay errores en la validación.
                return;
            }

            // Validación de campos de texto importantes.
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                errorProvider1.SetError(txtApellido, "No puede estar vacío.");
                btnGuardar.Enabled = true; // Reactiva el botón si hay errores en los datos.
                return;
            }

            // Validación de la fecha de nacimiento para evitar fechas futuras.
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

            // Validación de longitud mínima en campos importantes.
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
                btnGuardar.Enabled = true; // Reactiva el botón si la imagen ya existe.
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
                f.Filter = "Imágenes JPG,PNG|*.jpg;*.png"; // Permite seleccionar solo archivos JPG o PNG.
                if (f.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileInfo f2 = new System.IO.FileInfo(f.FileName);
                    if ((f2.Length / 1024) > 120) // Verifica que el tamaño del archivo no supere los 120 KB.
                    {
                        throw new Exception("¡El tamaño del archivo no puede superar los 120 kilobytes!");
                    }
                    else
                    {
                        pic.Load(f.FileName); // Carga la imagen seleccionada en el PictureBox.
                        imagenCargada = true; // Indica que la imagen fue cargada correctamente.
                    }
                }
                else
                {
                    pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_; // Restaura la imagen predeterminada si no se selecciona una nueva.
                    imagenCargada = false; // Marca que no se cargó ninguna imagen válida.
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
                if (string.IsNullOrWhiteSpace(txtIdentidad.Text)) // Valida que el campo de documento no esté vacío.
                {
                    MessageBox.Show("Por favor, ingresa un número de documento válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    int contadorRechazos = 0; // Contador para registrar transacciones rechazadas.
                    int contadortxt = 0; // Contador para registrar transacciones específicas.

                    if (!listo)
                    {
                        query = ClaseInspPrimaria.ObtenerConsultaBuscarPersona(); // Obtiene la consulta SQL para buscar personas.

                        using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@Identidad", txtIdentidad.Text.Trim()); // Agrega el parámetro de búsqueda.

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable personas = new DataTable();
                                adapter.Fill(personas); // Llena la tabla con los datos obtenidos de la base.

                                if (personas.Rows.Count > 0)
                                {
                                    foreach (DataRow row in personas.Rows) // Recorre los registros encontrados.
                                    {
                                        if (row["Estado"] != DBNull.Value)
                                        {
                                            int estado = Convert.ToInt32(row["Estado"]);
                                            if (estado == 0) contadorRechazos++; // Incrementa si el estado es rechazado.
                                            if (estado == 2) contadortxt++; // Incrementa si el estado es específico.
                                        }

                                        dgvTransacciones.Rows.Add(row["Fecha"].ToString(), row["tipoDocu"].ToString(), row["no"].ToString(), row["Origen"].ToString(), row["Destino"].ToString());
                                        dgvObservaciones.Rows.Add(row["Observaciones"].ToString(), row["usuario"].ToString()); // Agrega las transacciones y observaciones al DataGridView.
                                    }


                                    // Asigna los datos de la primera fila a los controles correspondientes.
                                    txtNombre.Text = personas.Rows[0]["Nombres"].ToString();
                                    txtApellido.Text = personas.Rows[0]["Apellidos"].ToString();
                                    dtpFechaNa.Value = Convert.ToDateTime(personas.Rows[0]["f_Nacimiento"]);
                                    cbSexo.SelectedValue = personas.Rows[0]["IdSexo"];
                                    cbPaisNa.SelectedValue = personas.Rows[0]["IdPaisNacimiento"];
                                    cbDoc.SelectedValue = personas.Rows[0]["TipoDocumento"];
                                    cbPaisEmision.SelectedValue = personas.Rows[0]["IdPaisEmision"];
                                    dtpfechaVenci.Value = Convert.ToDateTime(personas.Rows[0]["f_regFinal"]);

                                    // Manejo de la imagen almacenada en la base de datos.
                                    if (personas.Rows[0]["Imagen"] != DBNull.Value)
                                    {
                                        byte[] imagenBytes = (byte[])personas.Rows[0]["Imagen"];
                                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                                        {
                                            pic.Image = Image.FromStream(ms); // Carga la imagen desde la base de datos.
                                        }
                                    }
                                    else
                                    {
                                        pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_; // Usa una imagen predeterminada si no hay imagen almacenada.
                                    }

                                    // Actualiza los contadores visuales.
                                    contadorNegadoTxt.Text = contadorRechazos.ToString();
                                    contadortxtx.Text = contadortxt.ToString();

                                    listo = true; // Marca que se completó la búsqueda correctamente.
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron registros para el número de documento proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); // Notifica si no hay registros.
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
            // Restablece la interfaz a su estado inicial para la sección de información.
            listo = false;
            dgvObservaciones.DataSource = null;
            dgvObservaciones.Rows.Clear();
            dgvTransacciones.DataSource = null;
            dgvTransacciones.Rows.Clear();
            contadortxtx.Text = ""; // Limpia el contador.
            btnCancelar.PerformClick(); // Ejecuta la acción general de cancelar.
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpia todos los campos y restablece los valores predeterminados.
            gl.limpiarcampos(Documentoviaje);
            cbTrabajo.SelectedIndex = -1;
            cbPaisRes.SelectedIndex = -1;
            gl.limpiarcampos(groupBox4);
            gl.limpiarcampos(datosdeviaje);
            gl.limpiarcampos(groupBox2);
            gl.limpiarcampos(groupBox5);
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_; // Imagen predeterminada.
            listo = false;
            dgvObservaciones.DataSource = null;
            dgvObservaciones.Rows.Clear();
            dgvTransacciones.DataSource = null;
            dgvTransacciones.Rows.Clear();
            contadortxtx.Text = "";
            contadorNegadoTxt.Text = ""; // Limpia los contadores.
            errorProvider1.Clear(); // Limpia los errores visuales.
            dtpFechaNa.Value = DateTime.Now;
            dtpfechaVenci.Value = DateTime.Now; // Restablece las fechas a la actual.
        }


        private void cbDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambia la lógica de validación según el tipo de documento seleccionado.
            var selectedDocument = cbDoc.SelectedItem as document;
            if (selectedDocument != null && selectedDocument.codigo == 2) // Si es pasaporte.
            {

                txtIdentidad.TextChanged -= txtIdentidad_TextChanged;
                txtIdentidad.TextChanged -= txtIdentidad_TextChangedPasaporte;
                txtIdentidad.TextChanged += txtIdentidad_TextChangedPasaporte; // Aplica validación para pasaporte.
            }
            else
            {
                txtIdentidad.TextChanged -= txtIdentidad_TextChanged;
                txtIdentidad.TextChanged -= txtIdentidad_TextChangedPasaporte;
                txtIdentidad.TextChanged += txtIdentidad_TextChanged; // Aplica validación estándar.
            }
        }




        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {
            // Valida que solo se ingresen hasta 13 dígitos numéricos.
            string texto = txtIdentidad.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^\d{0,13}$"))
            {
                MessageBox.Show("Solo se permiten hasta 13 dígitos numéricos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentidad.Text = texto.Substring(0, texto.Length - 1); // Corrige el texto.
                txtIdentidad.SelectionStart = txtIdentidad.Text.Length;
            }
        }


        private void txtIdentidad_TextChangedPasaporte(object sender, EventArgs e)
        {
            // Valida que solo se permitan letras, números y un máximo de 13 caracteres para pasaportes.
            string texto = txtIdentidad.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z0-9]{0,13}$"))
            {
                MessageBox.Show("Solo se permiten letras y números. Máximo 13 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentidad.Text = texto.Substring(0, texto.Length - 1); // Corrige el texto.
                txtIdentidad.SelectionStart = txtIdentidad.Text.Length;
            }
        }





        private void txtResidencia_TextChanged(object sender, EventArgs e)
        {
            // Valida la entrada para el campo de residencia.
            string texto = txtResidencia.Text;
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"\s{2,}", " "); // Elimina espacios dobles.
            txtResidencia.Text = texto;
            txtResidencia.SelectionStart = texto.Length;

            if (!ValidarCaracteresPermitidos(texto)) // Valida caracteres permitidos.
            {
                MostrarAdvertencia("Solo se permiten letras, números, espacios, comas, puntos, el signo # y vocales con tilde. Máximo 80 caracteres.");
                CorregirTexto(txtResidencia);
                return;
            }

            if (ContieneTresCaracteresIgualesConsecutivos(texto)) // Valida caracteres repetidos consecutivamente.
            {
                MostrarAdvertencia("No se permiten tres caracteres iguales consecutivos.");
                CorregirTexto(txtResidencia);
                return;
            }

            if (!ValidarLongitudMinima(texto, 20)) // Valida longitud mínima sin contar espacios.
            {
                errorProvider1.SetError(txtResidencia, "Debe contener al menos 20 caracteres (sin contar espacios).");
            }
            else
            {
                errorProvider1.Clear(); // Limpia el error si la validación es correcta.
            }
        }

        private bool ValidarCaracteresPermitidos(string texto)
        {
            // Valida si el texto cumple con los caracteres permitidos.
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z0-9.,#áéíóúÁÉÍÓÚ]*(\s{0,1}[a-zA-Z0-9.,#áéíóúÁÉÍÓÚ]*){0,150}$");
        }

        private bool ContieneTresCaracteresIgualesConsecutivos(string texto)
        {
            // Verifica si hay tres caracteres iguales consecutivos en el texto.
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1");
        }

        private bool ValidarLongitudMinima(string texto, int longitudMinima)
        {
            // Valida si el texto (sin espacios) tiene una longitud mínima.
            string textoSinEspacios = texto.Replace(" ", "");
            return textoSinEspacios.Length >= longitudMinima;
        }

        private void MostrarAdvertencia(string mensaje)
        {
            // Muestra un cuadro de mensaje con una advertencia.
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CorregirTexto(TextBox textBox)
        {
            // Elimina el último carácter ingresado si es inválido.
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {
            string texto = txtObservaciones.Text;

            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"\s{2,}", " "); // Reemplaza espacios dobles.
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

        private void datosdeviaje_Enter(object sender, EventArgs e)
        {

        }
    }
}
