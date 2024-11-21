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

        SqlServerConnection gl = new SqlServerConnection();
        string query = string.Empty;
        SqlDataAdapter da;
        DataTable ta;
        bool listo = false;
        private SqlServerConnection conexion;

        public FormInspSecundaria()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            llenadoGrid();
        }



        private void llenadoGrid()
        {

            try
            {
                dgvTransacciones.Rows.Clear();

                ClaseInspSecundaria claseInsp = new ClaseInspSecundaria();
                query = claseInsp.ConsultaPersonasActivas();

                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    DataTable personas = gl.retornaTabla(query, sqlcon);
                    if (personas.Rows.Count > 0)
                    {
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
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dgvTransacciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransacciones.Rows.Count > 0)
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    if (string.IsNullOrWhiteSpace(dgvTransacciones.CurrentRow.Cells[0].Value.ToString()))
                    {
                        return;
                    }

                    ClaseInspSecundaria claseInsp = new ClaseInspSecundaria();
                    query = claseInsp.ConsultaPersonasActivas() + " AND A.IdPersonas = @IdPersona";

                    using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@IdPersona", dgvTransacciones.CurrentRow.Cells[0].Value.ToString());
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable personas = new DataTable();
                            adapter.Fill(personas);

                            if (personas.Rows.Count > 0)
                            {
                                txtNombre.Text = personas.Rows[0]["Nombres"].ToString();
                                txtApellido.Text = personas.Rows[0]["Apellidos"].ToString();
                                txtTipoDoc.Text = personas.Rows[0]["Doc"].ToString();
                                txtPaisEmision.Text = personas.Rows[0]["paisEmisor"].ToString();
                                txtIdentidad.Text = personas.Rows[0]["identidad"].ToString();
                                txtRegistro.Text = personas.Rows[0]["Id"].ToString();
                                txtObservacion.Text = personas.Rows[0]["Observacion"].ToString();

                                txtAlertas.Text = personas.Rows[0]["AlertasMigratorias"].ToString();

                                string fechaTexto = personas.Rows[0]["Fecha"].ToString();
                                if (!string.IsNullOrEmpty(fechaTexto))
                                {
                                    dtpFecha.Value = DateTime.ParseExact(fechaTexto, "dd-MM-yyyy", CultureInfo.InvariantCulture);

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
                                }
                            }
                        }
                    }
                }
            }
        }
               
        

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
            pic.Image = ProyectoMigracionMenu.Properties.Resources.imagenes_de_usuario__3_;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea continuar con el proceso?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result != DialogResult.OK)
                {
                    return;
                }

                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    query = "update Personas set Estado = 0  WHERE IdPersonas = '" + dgvTransacciones.CurrentRow.Cells[0].Value.ToString() + "' ";
                    gl.registra(query, sqlcon);
                    MessageBox.Show("Registro modificado con éxito. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    llenadoGrid();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea continuar con el proceso?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result != DialogResult.OK)
                {
                    return;
                }

                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    query = "update Personas set Estado = 2 WHERE IdPersonas = '" + dgvTransacciones.CurrentRow.Cells[0].Value.ToString() + "' ";
                    gl.registra(query, sqlcon);
                    MessageBox.Show("Registro modificado con éxito. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    llenadoGrid();
                }
            }
        }
    }
}