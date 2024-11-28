using System;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoMigracionMenu.Clases
{
    /// <summary>
    /// Clase para manejar la conexión y operaciones con la base de datos SQL Server.
    /// </summary>
    class SqlServerConnection
    {
        private string connectionString;

        /// <summary>
        /// Constructor que configura la cadena de conexión para conectarse a la base de datos.
        /// </summary>
        public SqlServerConnection()
        {
            string server = "ENAMORADO\\SQLEXPRESS";
            string database = "MigracionQA";
            connectionString = $"Server={server};Database={database};Integrated Security=True;";
        }

        /// <summary>
        /// Establece y abre una conexión a la base de datos.
        /// </summary>
        /// <returns>Una conexión SQL abierta.</returns>
        public SqlConnection EstablecerConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
            }
            return conexion;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados como un DataTable.
        /// </summary>
        /// <param name="ssql">Consulta SQL a ejecutar.</param>
        /// <param name="cox">Conexión SQL activa.</param>
        /// <returns>Un DataTable con los resultados de la consulta.</returns>
        public DataTable retornaTabla(string ssql, SqlConnection cox)
        {
            DataTable dta = new DataTable();
            try
            {
                SqlDataAdapter dad = new SqlDataAdapter(ssql, cox);
                dad.Fill(dta);
                cox.Close();
                return dta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dta;
            }
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve el primer valor de la primera columna como un entero.
        /// </summary>
        /// <param name="ssql">Consulta SQL a ejecutar.</param>
        /// <param name="cox">Conexión SQL activa.</param>
        /// <returns>El valor entero obtenido de la consulta.</returns>
        public int retornaEntero(string ssql, SqlConnection cox)
        {
            int retorno = 0;
            try
            {
                DataTable dta = new DataTable();
                SqlDataAdapter dad = new SqlDataAdapter(ssql, cox);
                dad.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    retorno = Convert.ToInt32(dta.Rows[0][0].ToString());
                }
                cox.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        /// <summary>
        /// Ejecuta una instrucción SQL que no devuelve resultados (como INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="ssql">Instrucción SQL a ejecutar.</param>
        /// <param name="cox">Conexión SQL activa.</param>
        public void registra(string ssql, SqlConnection cox)
        {
            if (cox.State == System.Data.ConnectionState.Open)
            {
                cox.Close();
            }
            cox.Open();
            SqlDataAdapter Regda = new SqlDataAdapter(ssql, cox);
            Regda.SelectCommand.CommandTimeout = 180;
            Regda.SelectCommand.ExecuteNonQuery();
            cox.Close();
        }

        /// <summary>
        /// Limpia los valores de todos los controles en un GroupBox (e.g., TextBox, ComboBox).
        /// </summary>
        /// <param name="tlp1">El GroupBox que contiene los controles a limpiar.</param>
        public void limpiarcampos(GroupBox tlp1)
        {
            foreach (var control in tlp1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is RichTextBox)
                {
                    ((RichTextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
        }

        /// <summary>
        /// Valida que el contenido de un TextBox sea un número entero y positivo.
        /// </summary>
        /// <param name="a">El TextBox a validar.</param>
        /// <param name="e">El ErrorProvider asociado al TextBox.</param>
        /// <returns>True si el valor es válido, de lo contrario, false.</returns>
        public bool validarInt(TextBox a, ErrorProvider e)
        {
            bool no_error = true;
            try
            {
                e.SetError(a, "");
                int entero = Convert.ToInt32(a.Text);
                if (entero < 0)
                {
                    a.Text = "0";
                    e.SetError(a, "Error al ingresar el valor.");
                }
            }
            catch
            {
                a.Text = "0";
                e.SetError(a, "Por favor ingrese un valor correcto.");
                no_error = false;
            }
            return no_error;
        }

        /// <summary>
        /// Recupera la lista de países activos desde la base de datos.
        /// </summary>
        /// <returns>Un DataTable con los países activos.</returns>
        public DataTable ObtenerPaises()
        {
            DataTable ta = new DataTable();
            try
            {
                using (SqlConnection sqlcon = EstablecerConexion())
                {
                    string query = "select IdPais, Descripcion from Pais where Activo = 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    da.Fill(ta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los países: " + ex.ToString());
            }
            return ta;
        }

        /// <summary>
        /// Recupera la lista de opciones de sexo desde la base de datos.
        /// </summary>
        /// <returns>Un DataTable con las opciones de sexo.</returns>
        public DataTable ObtenerSexo()
        {
            DataTable ta = new DataTable();
            try
            {
                using (SqlConnection sqlcon = EstablecerConexion())
                {
                    string query = "select IdSexo, Descripcion from Sexo";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    da.Fill(ta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener sexo: " + ex.ToString());
            }
            return ta;
        }

        /// <summary>
        /// Recupera la lista de motivos activos desde la base de datos.
        /// </summary>
        /// <returns>Un DataTable con los motivos activos.</returns>
        public DataTable ObtenerMotivos()
        {
            DataTable ta = new DataTable();
            try
            {
                using (SqlConnection sqlcon = EstablecerConexion())
                {
                    string query = "select IdMotivos, Descripcion from Motivos WHERE Activo = 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    da.Fill(ta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los motivos: " + ex.ToString());
            }
            return ta;
        }

        /// <summary>
        /// Recupera la lista de empleos activos desde la base de datos.
        /// </summary>
        /// <returns>Un DataTable con los empleos activos.</returns>
        public DataTable ObtenerEmpleo()
        {
            DataTable ta = new DataTable();
            try
            {
                using (SqlConnection sqlcon = EstablecerConexion())
                {
                    string query = "select IdTrabajo, Descripcion from Trabajos WHERE Activo = 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                    da.Fill(ta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los empleos: " + ex.ToString());
            }
            return ta;
        }

        /// <summary>
        /// Valida que un ComboBox tenga una opción seleccionada.
        /// </summary>
        /// <param name="texto">El ComboBox a validar.</param>
        /// <param name="e">El ErrorProvider asociado al ComboBox.</param>
        /// <returns>True si el ComboBox tiene una opción seleccionada, de lo contrario, false.</returns>
        public bool validaCombox(ComboBox texto, ErrorProvider e)
        {
            bool no_error = true;

            if (texto.SelectedIndex == -1)
            {
                e.SetError(texto, "Debe seleccionar una opción.");
                no_error = false;
            }
            else
            {
                e.SetError(texto, "");
            }
            return no_error;
        }
    }
}