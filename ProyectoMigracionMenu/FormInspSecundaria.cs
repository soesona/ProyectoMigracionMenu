using ProyectoMigracionMenu.Clases;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

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

                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    query = "SELECT A.IdPersonas Id, CASE WHEN TipoDocumento = 1 THEN 'Identidad' WHEN TipoDocumento = 2 THEN 'Pasaporte' ELSE 'Otro' END Doc, E.Descripcion paisEmisor, A.Identidad identidad, FORMAT(A.f_regFinal, 'dd-MM-yyyy') FechaV, A.Nombres Nombre, A.Apellidos, I.Descripcion Sexo, A.Fotografia Imagen,  " +
                            " CASE WHEN A.Estado = 1 THEN 'INSPECCIÓN PRIMARIA' End Estado, " +
                            " FORMAT(A.f_regCreado, 'dd-MM-yyyy') Fecha " +
                            " FROM Personas A " +
                            " INNER JOIN Pais E ON A.IdPaisEmision = E.IdPais " +
                            " INNER JOIN Sexo I ON A.IdSexo = I.IdSexo WHERE A.Estado = 1";
                    DataTable personas = gl.retornaTabla(query, sqlcon);
                    if (personas.Rows.Count > 0)
                    {
                        foreach (DataRow row in personas.Rows)
                        {
                            dgvTransacciones.Rows.Add(row["Id"].ToString(), row["Doc"].ToString(), row["paisEmisor"].ToString(),
                                row["identidad"].ToString(), row["FechaV"].ToString(), row["Nombre"].ToString(), row["Sexo"].ToString(), row["Estado"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
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
                    query = "SELECT A.IdPersonas Id, CASE WHEN TipoDocumento = 1 THEN 'Identidad' WHEN TipoDocumento = 2 THEN 'Pasaporte' ELSE 'Otro' END Doc, E.Descripcion paisEmisor, A.Identidad identidad, FORMAT(A.f_regFinal, 'dd-MM-yyyy') FechaV, A.Nombres Nombre, A.Apellidos, I.Descripcion Sexo, A.Fotografia Imagen,  " +
                            " CASE WHEN A.Estado = 1 THEN 'INSPECCIÓN PRIMARIA' End Estado, " +
                            " FORMAT(A.f_regCreado, 'dd-MM-yyyy') Fecha " +
                            " FROM Personas A " +
                            " INNER JOIN Pais E ON A.IdPaisEmision = E.IdPais " +
                            " INNER JOIN Sexo I ON A.IdSexo = I.IdSexo WHERE A.Estado = 1 AND a.IdPersonas = '" + dgvTransacciones.CurrentRow.Cells[0].Value.ToString() + "' ";
                    DataTable personas = gl.retornaTabla(query, sqlcon);
                    if (personas.Rows.Count > 0)
                    {
                        txtNombre.Text = personas.Rows[0]["Nombre"].ToString();
                        txtApellido.Text = personas.Rows[0]["Apellidos"].ToString();
                        txtTipoDoc.Text = personas.Rows[0]["Doc"].ToString();
                        txtPaisEmision.Text = personas.Rows[0]["paisEmisor"].ToString();
                        txtIdentidad.Text = personas.Rows[0]["identidad"].ToString();
                        txtRegistro.Text = personas.Rows[0]["Id"].ToString();

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

        private void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTipoDoc.Clear();
            txtPaisEmision.Clear();
            txtIdentidad.Clear();
            txtRegistro.Clear();
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