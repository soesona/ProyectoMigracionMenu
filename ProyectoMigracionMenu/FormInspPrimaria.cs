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

        /// <summary>
        /// Constructor de la clase FormInspPrimaria. Inicializa el formulario y carga los datos necesarios.
        /// </summary>
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

        /// <summary>
        /// Clase interna para representar los tipos de documentos.
        /// </summary>
        private class document
        {
            public int codigo { get; set; }
            public string des { get; set; }
        }

        /// <summary>
        /// Evento que se dispara cuando el formulario se carga. Actualmente no tiene implementación.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {

            }
        }

        /// <summary>
        /// Carga los países desde la base de datos y los asigna a los ComboBoxes correspondientes.
        /// </summary>
        private void pais()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    DataTable ta = new SqlServerConnection().ObtenerPaises(); // Método para obtener datos de países.
                    if (ta.Rows.Count > 0)
                    {
                        // Copias separadas para cada uso de país.
                        DataTable taEmision = ta.Copy();
                        DataTable taDestino = ta.Copy();
                        DataTable taRes = ta.Copy();
                        DataTable taNac = ta.Copy();

                        cbPaisEmision.DataSource = taEmision; // Población del combo de país de emisión.
                        cbPaisEmision.DisplayMember = "Descripcion";
                        cbPaisEmision.ValueMember = "IdPais";
                        cbPaisEmision.SelectedIndex = -1;

                        // Configuración para los otros controles de país.
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

        /// <summary>
        /// Carga las opciones de sexo desde la base de datos y las asigna al ComboBox correspondiente.
        /// </summary>
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

        /// <summary>
        /// Carga los motivos del viaje desde la base de datos y los asigna al ComboBox correspondiente.
        /// </summary>
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

        /// <summary>
        /// Carga los empleos disponibles desde la base de datos y los asigna al ComboBox correspondiente.
        /// </summary>
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

        /// <summary>
        /// Carga los tipos de documentos disponibles para selección en el ComboBox.
        /// </summary>
        private void documento()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    // Crea una lista con los tipos de documentos disponibles.
                    var list = new List<document>
                    {
                        new document { codigo = 1, des = "IDENTIDAD" },
                        new document { codigo = 2, des = "PASAPORTE" }
                    };
                    // Asigna la lista al ComboBox de documentos.
                    cbDoc.DataSource = list;
                    cbDoc.DisplayMember = "des";
                    cbDoc.ValueMember = "codigo";
                    cbDoc.SelectedIndex = -1;
                }

                // Evento que se ejecuta cuando cambia la selección del ComboBox.
                cbDoc.SelectedIndexChanged += cbDoc_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }


        /// <summary>
        /// Abre el formulario para agregar un nuevo trabajo y actualiza la lista de empleos después de cerrar el formulario.
        /// </summary>
        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar("Trabajos"); // Abre el formulario para agregar un nuevo trabajo.
            agregar.ShowDialog(); // Pausa la ejecución hasta que el formulario se cierre.
            empleo(); // Actualiza la lista de empleos después de agregar un nuevo elemento.
        }

        /// <summary>
        /// Abre el formulario para agregar un nuevo país y actualiza la lista de países después de cerrar el formulario.
        /// </summary>
        private void btnPaises_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar("Pais"); // Abre el formulario para agregar un nuevo país.
            agregar.ShowDialog(); // Pausa la ejecución hasta que el formulario se cierre.
            pais(); // Actualiza la lista de países después de agregar un nuevo elemento.
        }

        /// <summary>
        /// Abre el formulario para agregar un nuevo motivo y actualiza la lista de motivos después de cerrar el formulario.
        /// </summary>
        private void btnMotivos_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar("Motivos"); // Abre el formulario para agregar un nuevo motivo.
            agregar.ShowDialog(); // Pausa la ejecución hasta que el formulario se cierre.
            motivos(); // Actualiza la lista de motivos después de agregar un nuevo elemento.
        }

        /// <summary>
        /// Convierte un objeto de tipo Image a un arreglo de bytes para poder guardarlo en la base de datos.
        /// </summary>
        /// <param name="imageIn">La imagen que se va a convertir.</param>
        /// <returns>Un arreglo de bytes que representa la imagen.</returns>
        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Guarda la imagen en un flujo de memoria en formato JPEG.
                return ms.ToArray(); // Convierte el flujo de memoria a un arreglo de bytes.
            }
        }

        /// <summary>
        /// Obtiene la imagen asociada a una persona desde la base de datos usando su Identidad.
        /// </summary>
        /// <param name="identidad">El identificador único de la persona.</param>
        /// <returns>La imagen asociada a la persona, o null si no se encuentra.</returns>
        private Image ObtenerImagenDesdeBaseDeDatos(string identidad)
        {
            using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT Fotografia FROM Personas WHERE Identidad = @Identidad";
                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Identidad", identidad); // Añade el parámetro de identidad a la consulta.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Fotografia"] != DBNull.Value) // Si hay una imagen en la base de datos.
                            {
                                byte[] imgData = (byte[])reader["Fotografia"]; // Extrae los bytes de la imagen.
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    return Image.FromStream(ms); // Convierte los bytes de la imagen de vuelta a un objeto Image.
                                }
                            }
                        }
                    }
                }
            }
            return null; // Retorna null si no se encuentra la imagen.
        }

        /// <summary>
        /// Compara dos imágenes para ver si son idénticas.
        /// </summary>
        /// <param name="img1">La primera imagen a comparar.</param>
        /// <param name="img2">La segunda imagen a comparar.</param>
        /// <returns>True si las imágenes son iguales, de lo contrario, False.</returns>
        private bool ImagesAreEqual(Image img1, Image img2)
        {
            if (img1 == null || img2 == null)
            {
                return false; // Si alguna de las imágenes es null, no son iguales.
            }

            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                return false; // Si las dimensiones de las imágenes son diferentes, no son iguales.
            }

            // Compara pixel por pixel las imágenes.
            using (Bitmap bmp1 = new Bitmap(img1))
            using (Bitmap bmp2 = new Bitmap(img2))
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    for (int x = 0; x < bmp1.Width; x++)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y)) // Si algún pixel no coincide, las imágenes no son iguales.
                        {
                            return false;
                        }
                    }
                }
            }

            return true; // Si todas las comparaciones de píxeles son iguales, las imágenes son iguales.
        }

        /// <summary>
        /// Guarda los datos de la persona en la base de datos después de realizar una serie de validaciones.
        /// </summary>
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
                MessageBox.Show("La imagen seleccionada es la misma que la registrada anteriormente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnGuardar.Enabled = true;
                return;
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón para cargar una imagen en el PictureBox.
        /// Permite seleccionar solo archivos de imagen en formato JPG o PNG.
        /// Verifica que el tamaño de la imagen no supere los 120 KB.
        /// </summary>
        private bool imagenCargada = false;

        private void btnfotografia_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea un cuadro de diálogo para seleccionar el archivo de imagen.
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "Imágenes JPG,PNG|*.jpg;*.png"; // Permite seleccionar solo archivos JPG o PNG.

                // Verifica si el usuario seleccionó un archivo.
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la información del archivo seleccionado.
                    System.IO.FileInfo f2 = new System.IO.FileInfo(f.FileName);

                    // Verifica que el tamaño del archivo no supere los 120 KB.
                    if ((f2.Length / 1024) > 120)
                    {
                        throw new Exception("¡El tamaño del archivo no puede superar los 120 kilobytes!");
                    }
                    else
                    {
                        // Carga la imagen seleccionada en el PictureBox.
                        pic.Load(f.FileName);
                        imagenCargada = true; // Indica que la imagen fue cargada correctamente.
                    }
                }
                else
                {
                    // Restaura la imagen predeterminada si no se seleccionó ninguna imagen.
                    pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
                    imagenCargada = false; // Marca que no se cargó ninguna imagen válida.
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepción.
                MessageBox.Show("ERROR: " + ex.Message, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de búsqueda.
        /// Valida el número de documento ingresado y busca los registros correspondientes en la base de datos.
        /// Muestra los resultados en los controles correspondientes y actualiza los contadores de transacciones rechazadas y específicas.
        /// </summary>
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida que el campo de documento no esté vacío.
                if (string.IsNullOrWhiteSpace(txtIdentidad.Text))
                {
                    MessageBox.Show("Por favor, ingresa un número de documento válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    // Inicializa contadores para rechazos y transacciones específicas.
                    int contadorRechazos = 0;
                    int contadortxt = 0;

                    // Verifica si la búsqueda no ha sido realizada anteriormente.
                    if (!listo)
                    {
                        // Obtiene la consulta SQL para buscar personas en la base de datos.
                        query = ClaseInspPrimaria.ObtenerConsultaBuscarPersona();

                        using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                        {
                            // Agrega el parámetro de búsqueda al comando SQL.
                            cmd.Parameters.AddWithValue("@Identidad", txtIdentidad.Text.Trim());

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable personas = new DataTable();
                                adapter.Fill(personas); // Llena la tabla con los datos obtenidos de la base de datos.

                                // Verifica si se encontraron registros en la base de datos.
                                if (personas.Rows.Count > 0)
                                {
                                    foreach (DataRow row in personas.Rows) // Recorre los registros encontrados.
                                    {
                                        // Verifica el estado y actualiza los contadores.
                                        if (row["Estado"] != DBNull.Value)
                                        {
                                            int estado = Convert.ToInt32(row["Estado"]);
                                            if (estado == 0) contadorRechazos++; // Incrementa si el estado es rechazado.
                                            if (estado == 2) contadortxt++; // Incrementa si el estado es específico.
                                        }

                                        // Agrega los datos de la transacción al DataGridView.
                                        dgvTransacciones.Rows.Add(row["Fecha"].ToString(), row["tipoDocu"].ToString(), row["no"].ToString(), row["Origen"].ToString(), row["Destino"].ToString());
                                        dgvObservaciones.Rows.Add(row["Observaciones"].ToString(), row["usuario"].ToString());
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

                                    // Maneja la imagen almacenada en la base de datos.
                                    if (personas.Rows[0]["Imagen"] != DBNull.Value)
                                    {
                                        byte[] imagenBytes = (byte[])personas.Rows[0]["Imagen"];
                                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                                        {
                                            pic.Image = Image.FromStream(ms); // Carga la imagen desde el byte array.
                                        }
                                    }
                                    else
                                    {
                                        // Usa una imagen predeterminada si no hay imagen almacenada.
                                        pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
                                    }

                                    // Actualiza los contadores visuales.
                                    contadorNegadoTxt.Text = contadorRechazos.ToString();
                                    contadortxtx.Text = contadortxt.ToString();

                                    listo = true; // Marca que se completó la búsqueda correctamente.
                                }
                                else
                                {
                                    // Muestra un mensaje si no se encuentran registros.
                                    MessageBox.Show("No se encontraron registros para el número de documento proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepción.
                MessageBox.Show("ERROR: " + ex.Message, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        /// <summary>
        /// Método que restablece la interfaz a su estado inicial para la sección de información.
        /// Limpia las filas de los DataGridViews y el contador, y ejecuta la acción general de cancelar.
        /// </summary>
        private void btnCancelarInfo_Click(object sender, EventArgs e)
        {
            listo = false;
            dgvObservaciones.DataSource = null;
            dgvObservaciones.Rows.Clear();
            dgvTransacciones.DataSource = null;
            dgvTransacciones.Rows.Clear();
            contadortxtx.Text = ""; // Limpia el contador.
            btnCancelar.PerformClick(); // Ejecuta la acción general de cancelar.
        }

        /// <summary>
        /// Método que limpia todos los campos del formulario y restablece los valores predeterminados.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gl.limpiarcampos(Documentoviaje); // Limpia los campos del documento de viaje.
            cbTrabajo.SelectedIndex = -1; // Restablece el valor del combo de trabajo.
            cbPaisRes.SelectedIndex = -1; // Restablece el valor del combo de país de residencia.
            gl.limpiarcampos(groupBox4); // Limpia los campos dentro de groupBox4.
            gl.limpiarcampos(datosdeviaje); // Limpia los campos del grupo de datos de viaje.
            gl.limpiarcampos(groupBox2); // Limpia los campos de groupBox2.
            gl.limpiarcampos(groupBox5); // Limpia los campos de groupBox5.
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_; // Restaura la imagen predeterminada.
            listo = false; // Marca que no hay datos cargados correctamente.
            dgvObservaciones.DataSource = null;
            dgvObservaciones.Rows.Clear();
            dgvTransacciones.DataSource = null;
            dgvTransacciones.Rows.Clear();
            contadortxtx.Text = ""; // Limpia los contadores visuales.
            contadorNegadoTxt.Text = "";
            errorProvider1.Clear(); // Limpia los errores visuales si existen.
            dtpFechaNa.Value = DateTime.Now; // Restablece la fecha de nacimiento al valor actual.
            dtpfechaVenci.Value = DateTime.Now; // Restablece la fecha de vencimiento al valor actual.
        }

        /// <summary>
        /// Evento que se dispara cuando se cambia el índice del combo de documentos.
        /// Modifica la validación del campo de identidad dependiendo del tipo de documento seleccionado.
        /// </summary>
        private void cbDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDocument = cbDoc.SelectedItem as document;
            if (selectedDocument != null && selectedDocument.codigo == 2) // Si es pasaporte.
            {
                txtIdentidad.TextChanged -= txtIdentidad_TextChanged;
                txtIdentidad.TextChanged -= txtIdentidad_TextChangedPasaporte;
                txtIdentidad.TextChanged += txtIdentidad_TextChangedPasaporte; // Aplica validación para pasaporte.
            }
            else
            {
                txtIdentidad.TextChanged -= txtIdentidad_TextChangedPasaporte;
                txtIdentidad.TextChanged += txtIdentidad_TextChanged; // Aplica validación estándar.
            }
        }

        /// <summary>
        /// Valida que solo se ingresen hasta 13 dígitos numéricos en el campo de identidad.
        /// </summary>
        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {
            string texto = txtIdentidad.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^\d{0,13}$"))
            {
                MessageBox.Show("Solo se permiten hasta 13 dígitos numéricos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentidad.Text = texto.Substring(0, texto.Length - 1); // Corrige el texto.
                txtIdentidad.SelectionStart = txtIdentidad.Text.Length;
            }
        }

        /// <summary>
        /// Valida que solo se permitan letras, números y un máximo de 13 caracteres en el campo de identidad para pasaporte.
        /// </summary>
        private void txtIdentidad_TextChangedPasaporte(object sender, EventArgs e)
        {
            string texto = txtIdentidad.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z0-9]{0,13}$"))
            {
                MessageBox.Show("Solo se permiten letras y números. Máximo 13 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentidad.Text = texto.Substring(0, texto.Length - 1); // Corrige el texto.
                txtIdentidad.SelectionStart = txtIdentidad.Text.Length;
            }
        }

        /// <summary>
        /// Valida la entrada del campo de residencia, corrigiendo espacios dobles y asegurando que los caracteres sean permitidos.
        /// También valida que la longitud mínima del texto sea de 20 caracteres (sin contar espacios).
        /// </summary>
        private void txtResidencia_TextChanged(object sender, EventArgs e)
        {
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

            if (!ValidarLongitudMinima(texto, 20)) // Valida longitud mínima.
            {
                errorProvider1.SetError(txtResidencia, "Debe contener al menos 20 caracteres (sin contar espacios).");
            }
            else
            {
                errorProvider1.Clear(); // Limpia el error si la longitud es válida.
            }
        }

        /// <summary>
        /// Verifica si el texto contiene solo los caracteres permitidos según una expresión regular.
        /// </summary>
        private bool ValidarCaracteresPermitidos(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z0-9.,#áéíóúÁÉÍÓÚ]*(\s{0,1}[a-zA-Z0-9.,#áéíóúÁÉÍÓÚ]*){0,150}$");
        }

        /// <summary>
        /// Verifica si el texto contiene tres caracteres iguales consecutivos.
        /// </summary>
        private bool ContieneTresCaracteresIgualesConsecutivos(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1");
        }

        /// <summary>
        /// Valida si el texto (sin espacios) tiene una longitud mínima especificada.
        /// </summary>
        /// <param name="texto">El texto a validar.</param>
        /// <param name="longitudMinima">La longitud mínima que debe tener el texto sin espacios.</param>
        /// <returns>Devuelve true si el texto tiene la longitud mínima, false en caso contrario.</returns>
        private bool ValidarLongitudMinima(string texto, int longitudMinima)
        {
            string textoSinEspacios = texto.Replace(" ", ""); // Elimina los espacios del texto.
            return textoSinEspacios.Length >= longitudMinima; // Valida la longitud del texto sin contar espacios.
        }

        /// <summary>
        /// Muestra un cuadro de mensaje con una advertencia.
        /// </summary>
        /// <param name="mensaje">El mensaje que se desea mostrar en el cuadro de advertencia.</param>
        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra la advertencia.
        }

        /// <summary>
        /// Elimina el último carácter ingresado en el TextBox si es inválido.
        /// </summary>
        /// <param name="textBox">El TextBox que contiene el texto a corregir.</param>
        private void CorregirTexto(TextBox textBox)
        {
            if (textBox.Text.Length > 0) // Si hay texto en el TextBox.
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1); // Elimina el último carácter.
                textBox.SelectionStart = textBox.Text.Length; // Establece el cursor al final del texto.
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el texto del campo 'Observaciones' cambia.
        /// Realiza validaciones sobre el texto ingresado y muestra advertencias o errores si es necesario.
        /// </summary>
        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {
            string texto = txtObservaciones.Text;

            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"\s{2,}", " "); // Reemplaza espacios dobles por uno solo.
            txtObservaciones.Text = texto;
            txtObservaciones.SelectionStart = texto.Length; // Coloca el cursor al final.

            if (string.IsNullOrWhiteSpace(texto)) // Si el texto está vacío.
            {
                errorProvider1.SetError(txtObservaciones, "El campo 'Observaciones' no puede estar vacío."); // Muestra error.
                return;
            }

            if (!ValidarCaracteresPermitidos(texto)) // Si el texto contiene caracteres no permitidos.
            {
                MostrarAdvertencia("Solo se permiten letras, números, espacios, puntos, comas y vocales con tilde. Máximo 150 caracteres.");
                CorregirTexto(txtObservaciones); // Corrige el texto eliminando el último carácter.
                return;
            }

            if (ContieneTresCaracteresIgualesConsecutivos(texto)) // Si el texto contiene tres caracteres iguales consecutivos.
            {
                MostrarAdvertencia("No se permiten tres caracteres iguales consecutivos.");
                CorregirTexto(txtObservaciones); // Corrige el texto eliminando el último carácter.
                return;
            }

            if (!ValidarLongitudMinima(texto, 20)) // Si el texto no cumple con la longitud mínima.
            {
                errorProvider1.SetError(txtObservaciones, "Debe contener al menos 20 caracteres (sin contar espacios).");
            }
            else
            {
                errorProvider1.Clear(); // Limpia el error si la longitud es válida.
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el texto del campo 'Nombre' cambia.
        /// Realiza validaciones sobre el texto ingresado y muestra advertencias o errores si es necesario.
        /// </summary>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;

            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]{0,20}$")) // Verifica si solo contiene letras y espacios, máximo 20 caracteres.
            {
                MessageBox.Show("Solo se permiten letras y espacios. Entre 3 y 20 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Text = texto.Substring(0, texto.Length - 1); // Elimina el último carácter si es inválido.
                txtNombre.SelectionStart = txtNombre.Text.Length;
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1")) // Verifica si hay tres caracteres iguales consecutivos.
            {
                MessageBox.Show("No se permiten tres caracteres iguales consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Text = texto.Substring(0, texto.Length - 1); // Elimina el último carácter si es inválido.
                txtNombre.SelectionStart = txtNombre.Text.Length;
                return;
            }

            if (texto.Length > 0 && texto.Length < 3) // Verifica que la longitud sea mínima de 3 caracteres.
            {
                errorProvider1.SetError(txtNombre, "Debe contener al menos 3 caracteres.");
            }
            else if (texto.Length >= 3 && texto.Length <= 20) // Si la longitud es válida, limpia los errores.
            {
                errorProvider1.Clear();
            }
        }

        /// <summary>
        /// Evento que se dispara cuando el texto del campo 'Apellido' cambia.
        /// Realiza validaciones sobre el texto ingresado y muestra advertencias o errores si es necesario.
        /// </summary>
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            string texto = txtApellido.Text;

            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]{0,20}$")) // Verifica si solo contiene letras y espacios, máximo 20 caracteres.
            {
                MessageBox.Show("Solo se permiten letras y espacios. Entre 3 y 20 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Text = texto.Substring(0, texto.Length - 1); // Elimina el último carácter si es inválido.
                txtApellido.SelectionStart = txtApellido.Text.Length;
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1")) // Verifica si hay tres caracteres iguales consecutivos.
            {
                MessageBox.Show("No se permiten tres caracteres iguales consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Text = texto.Substring(0, texto.Length - 1); // Elimina el último carácter si es inválido.
                txtApellido.SelectionStart = txtApellido.Text.Length;
                return;
            }

            if (texto.Length > 0 && texto.Length < 3) // Verifica que la longitud sea mínima de 3 caracteres.
            {
                errorProvider1.SetError(txtApellido, "Debe contener al menos 3 caracteres.");
            }
            else if (texto.Length >= 3 && texto.Length <= 20) // Si la longitud es válida, limpia los errores.
            {
                errorProvider1.Clear();
            }
        }

        private void datosdeviaje_Enter(object sender, EventArgs e)
        {

        }
    }
}
