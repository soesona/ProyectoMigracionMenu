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
        /// <summary>
        /// Carga las delegaciones desde la base de datos y las devuelve en un DataTable.
        /// </summary>
        /// <returns>Un DataTable con las delegaciones obtenidas desde la base de datos.</returns>
        public DataTable CargarDelegaciones()
        {
            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                // Crea un adaptador de datos SQL que ejecuta un procedimiento almacenado llamado "Delegaciones_ComboBox".
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

