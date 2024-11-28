using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{

    public class PersonaService
    {
        // Método para obtener el conteo de actividad de un usuario en una fecha específica.
        // Consulta cuántos registros en la tabla Personas fueron creados por el usuario actual en una fecha dada.
        public int ObtenerConteoActividadUsuario(DateTime fecha, string usuarioActual)
        {
            int conteoActividad = 0;

            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT COUNT(*) FROM Personas WHERE UsuarioCreado = @usuario AND CAST(f_regCreado AS DATE) = @fecha";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@usuario", usuarioActual);
                    command.Parameters.AddWithValue("@fecha", fecha.Date);

                    conteoActividad = (int)command.ExecuteScalar();
                }
            }
            return conteoActividad;
        }

        // Método para obtener el conteo de actividad de un usuario en un rango de fechas.
        // Realiza una consulta para contar los registros creados por el usuario actual dentro de un rango definido.
        public int ObtenerConteoActividadUsuarioPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            int conteoActividad = 0;
            string usuarioActual = Login.UsuarioActual.Nombre;

            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT COUNT(*) FROM Personas WHERE UsuarioCreado = @usuario AND CAST(f_regCreado AS DATE) BETWEEN @fechaInicio AND @fechaFin";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@usuario", usuarioActual);
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin.Date);

                    conteoActividad = (int)command.ExecuteScalar();
                }
            }
            return conteoActividad;
        }
    }
}