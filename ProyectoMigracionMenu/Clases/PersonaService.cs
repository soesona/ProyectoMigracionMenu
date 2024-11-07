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

