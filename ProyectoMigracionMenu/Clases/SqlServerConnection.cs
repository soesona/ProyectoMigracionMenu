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
    class SqlServerConnection
    {
        private string connectionString;
        public SqlServerConnection()
        {
            string server = "ENAMORADO\\SQLEXPRESS";
            string database = "MigracionQA";
          

           connectionString = $"Server={server};Database={database};Integrated Security=True;";
        }

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
        public DataTable retornaTabla(string ssql, SqlConnection cox)
        {
            DataTable dta = new DataTable();
            try
            {

                SqlDataAdapter dad;
                dad = new SqlDataAdapter(ssql, cox);
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
        public void registra(string ssql, SqlConnection cox)
        {
            if (cox.State == System.Data.ConnectionState.Open)
            {
                cox.Close();
            }
            cox.Open();
            SqlDataAdapter Regda;
            Regda = new SqlDataAdapter(ssql, cox);
            Regda.SelectCommand.CommandTimeout = 180;
            Regda.SelectCommand.ExecuteNonQuery();
            cox.Close();
        }
        public void limpiarcampos(GroupBox tlp1)
        {
            foreach (var combo1 in tlp1.Controls)
            {
                if (combo1 is TextBox)
                {
                    ((TextBox)combo1).Clear();
                }
                else if (combo1 is NumericUpDown)
                {
                    ((NumericUpDown)combo1).Value = 1;
                }
                else if (combo1 is CheckBox)
                {
                    ((CheckBox)combo1).Checked = false;
                }
                else if (combo1 is RadioButton)
                {
                    ((RadioButton)combo1).Checked = false;
                }
                else if (combo1 is RichTextBox)
                {
                    ((RichTextBox)combo1).Clear();
                }
                else if (combo1 is ComboBox)
                {
                    ((ComboBox)combo1).SelectedIndex = -1;
                }

            }
        }
        public bool validarInt(TextBox a, ErrorProvider e)
        {
            bool no_error = true;
            // esta funcion es para validar textbox de tipo INT

            int entero = 0;
            try
            {
                e.SetError(a, "");
                entero = Convert.ToInt32(a.Text);
                if (entero < 0)
                {
                    a.Text = "0";
                    e.SetError(a, "Error al ingresar el valor.");
                }
            }
            catch
            {
                a.Text = "0";
                e.SetError(a, "");
                e.SetError(a, "Por favor ingrese un valor correcto.");
                return false;
            }

            return no_error;
        }
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

        public DataTable ObtenerSexo()
        {
            DataTable ta = new DataTable();
            try
            {
                using (SqlConnection sqlcon = EstablecerConexion())
                {
                    string query = "select IdSexo, Descripcion from Sexo ";
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
        public DataTable ObtenerMotivos()
        {
            DataTable ta = new DataTable();
            try
            {
                using (SqlConnection sqlcon = EstablecerConexion())
                {
                    string query = "select IdMotivos, Descripcion from Motivos WHERE Activo = 1 ";
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
        public DataTable ObtenerEmpleo()
        {
            DataTable ta = new DataTable();
            try
            {
                using (SqlConnection sqlcon = EstablecerConexion())
                {
                    string query = "select IdTrabajo, Descripcion from Trabajos WHERE Activo = 1 ";
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
        public bool validaCombox(ComboBox texto, ErrorProvider e)
        {
            bool no_error = true;

            if (texto.SelectedIndex == -1)
            {
                e.SetError(texto, "Debe Seleccionar una opción.");
                return false;
            }
            else
            {
                e.SetError(texto, "");
            }
            return no_error;
        }
    }
}
