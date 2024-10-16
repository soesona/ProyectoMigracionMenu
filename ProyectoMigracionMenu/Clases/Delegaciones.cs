using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    public class Delegaciones
    {


        private string connectionString = "Server=ENAMORADO\\SQLEXPRESS;Database=MigracionPrueba;Integrated Security=True;";

        public DataTable CargarDelegaciones()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("Delegaciones_ComboBox", conexion))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
