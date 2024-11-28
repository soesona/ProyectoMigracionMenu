using ProyectoMigracionMenu.Clases;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Inspeccionsecundaria
{
    public partial class FormInspSecundaria : Form
    {
        // Instancias necesarias para realizar conexiones y ejecutar consultas
        SqlServerConnection gl = new SqlServerConnection();
        string query = string.Empty;
        SqlDataAdapter da;
        DataTable ta;
        bool listo = false;
        private SqlServerConnection conexion;

        /// <summary>
        /// Constructor del formulario.
        /// Inicializa los componentes y establece la carga inicial de datos en el grid.
        /// </summary>
        public FormInspSecundaria()
        {
            InitializeComponent();  // Inicializa los componentes del formulario
            this.DoubleBuffered = true;  // Mejora el rendimiento de la interfaz
            llenadoGrid();  // Llama al método para cargar los datos en el grid al iniciar
        }

        /// <summary>
        /// Método para llenar el DataGrid con datos de personas activas.
        /// Realiza la consulta y carga los datos en el DataGrid.
        /// </summary>
        private void llenadoGrid()
        {
            try
            {
                dgvTransacciones.Rows.Clear();  // Limpia las filas del DataGrid

                ClaseInspSecundaria claseInsp = new ClaseInspSecundaria();
                query = claseInsp.ConsultaPersonasActivas();  // Obtiene la consulta de personas activas

                // Realiza la conexión y la consulta para obtener los datos
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    DataTable personas = gl.retornaTabla(query, sqlcon);  // Llama a un método para obtener los datos

                    if (personas.Rows.Count > 0)
                    {
                        // Si existen datos, los agrega al DataGrid
                        foreach (DataRow row in personas.Rows)
                        {
                            dgvTransacciones.Rows.Add(
                                row["Id"].ToString(),
                                row["Doc"].ToString(),
                                row["paisEmisor"].ToString(),
                                row["identidad"].ToString(),
                                row["FechaV"].ToString(),
                                row["NombreCompleto"].ToString(),
                                row["Sexo"].ToString(),
                                row["Observacion"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);  // Muestra un mensaje de error si algo sale mal
            }
        }

        /// <summary>
        /// Maneja el evento cuando se cambia la selección en el DataGrid.
        /// Muestra los detalles de la persona seleccionada en los controles del formulario.
        /// </summary>
        private void dgvTransacciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransacciones.Rows.Count > 0)
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    // Verifica que la fila seleccionada no esté vacía
                    if (string.IsNullOrWhiteSpace(dgvTransacciones.CurrentRow.Cells[0].Value.ToString()))
                    {
                        return;
                    }

                    ClaseInspSecundaria claseInsp = new ClaseInspSecundaria();
                    query = claseInsp.ConsultaPersonasActivas() + " AND A.IdPersonas = @IdPersona";  // Modifica la consulta para filtrar por ID

                    using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@IdPersona", dgvTransacciones.CurrentRow.Cells[0].Value.ToString());

                        // Llama a la consulta y llena los datos en los controles del formulario
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable personas = new DataTable();
                            adapter.Fill(personas);

                            if (personas.Rows.Count > 0)
                            {
                                // Rellena los controles con los datos de la persona seleccionada
                                txtNombre.Text = personas.Rows[0]["Nombres"].ToString();
                                txtApellido.Text = personas.Rows[0]["Apellidos"].ToString();
                                txtTipoDoc.Text = personas.Rows[0]["Doc"].ToString();
                                txtPaisEmision.Text = personas.Rows[0]["paisEmisor"].ToString();
                                txtIdentidad.Text = personas.Rows[0]["identidad"].ToString();
                                txtRegistro.Text = personas.Rows[0]["Id"].ToString();
                                txtObservacion.Text = personas.Rows[0]["Observacion"].ToString();
                                txtAlertas.Text = personas.Rows[0]["AlertasMigratorias"].ToString();

                                // Muestra la fecha si está disponible
                                string fechaTexto = personas.Rows[0]["Fecha"].ToString();
                                if (!string.IsNullOrEmpty(fechaTexto))
                                {
                                    dtpFecha.Value = DateTime.ParseExact(fechaTexto, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                                    // Si la persona tiene una imagen, la carga
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
                                        pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;  // Imagen por defecto
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Limpia todos los controles del formulario.
        /// Restaura los valores por defecto de los controles de texto y la imagen.
        /// </summary>
        private void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTipoDoc.Clear();
            txtPaisEmision.Clear();
            txtIdentidad.Clear();
            txtRegistro.Clear();
            txtAlertas.Clear();
            txtObservacion.Clear();
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;  // Restablece la imagen por defecto
        }

        /// <summary>
        /// Maneja el evento para cancelar el proceso y modificar el estado de la persona.
        /// Actualiza el estado de la persona en la base de datos a "inactivo" y recarga los datos.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea continuar con el proceso?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result != DialogResult.OK)
                {
                    return;  // Si el usuario no confirma, sale del método
                }

                // Actualiza el estado de la persona en la base de datos
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    query = "update Personas set Estado = 0 WHERE IdPersonas = '" + dgvTransacciones.CurrentRow.Cells[0].Value.ToString() + "' ";
                    gl.registra(query, sqlcon);
                    MessageBox.Show("Registro modificado con éxito. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();  // Limpia los controles
                    llenadoGrid();  // Vuelve a cargar los datos
                }
            }
        }

        /// <summary>
        /// Maneja el evento para guardar el proceso y modificar el estado de la persona.
        /// Actualiza el estado de la persona en la base de datos a "activo" y recarga los datos.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea continuar con el proceso?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result != DialogResult.OK)
                {
                    return;  // Si el usuario no confirma, sale del método
                }

                // Actualiza el estado de la persona en la base de datos
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    query = "update Personas set Estado = 2 WHERE IdPersonas = '" + dgvTransacciones.CurrentRow.Cells[0].Value.ToString() + "' ";
                    gl.registra(query, sqlcon);
                    MessageBox.Show("Registro modificado con éxito. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();  // Limpia los controles
                    llenadoGrid();  // Vuelve a cargar los datos
                }
            }
        }
    }
}