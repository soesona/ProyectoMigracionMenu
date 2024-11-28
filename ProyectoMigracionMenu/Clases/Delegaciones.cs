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
        // carga las delegaciones desde la base de datos y las devuelve en un DataTable
        public DataTable CargarDelegaciones()
        {
         
            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {

                // crea un adaptador de datos sql que ejecuta un procedimiento almacenado llamado "Delegaciones_ComboBox".
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

