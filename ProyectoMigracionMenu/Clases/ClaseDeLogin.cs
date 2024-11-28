using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ProyectoMigracionMenu.Clases
{
    public class ClaseDeLogin
    {
        /// <summary>
        /// Propiedades que almacenan el nombre, delegación, rol e IdDelegacion del usuario.
        /// </summary>
        public string Nombre { get; private set; }
        public string Delegacion { get; private set; }
        public string Rol { get; private set; }

        public int IdDelegacion { get; private set; }

        /// <summary>
        /// Método que valida las credenciales de inicio de sesión (usuario y clave).
        /// </summary>
        /// <param name="usuario">El nombre de usuario que se quiere validar.</param>
        /// <param name="clave">La clave asociada al usuario para su autenticación.</param>
        /// <returns>Devuelve verdadero si las credenciales son correctas, de lo contrario, falso.</returns>
        public bool IniciarSesion(string usuario, string clave)
        {
            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT u.Nombre, d.NombreDelegacion, r.NombreRol, u.IdDelegacion " +
                               "FROM Usuarios u " +
                               "JOIN Delegaciones d ON u.IdDelegacion = d.IdDelegacion " +
                               "JOIN Roles r ON u.IdRol = r.IdRol " +
                               "WHERE u.Usuario COLLATE Latin1_General_CS_AS = @usuario " + // Se compara el nombre de usuario de forma sensible a mayúsculas y minúsculas
                               "AND u.Clave COLLATE Latin1_General_CS_AS = @clave " + // Se compara la clave de forma sensible a mayúsculas y minúsculas
                               "AND u.Activo = 1"; // Verifica que el usuario esté activo en la base de datos

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Asigna los valores obtenidos de la consulta a las propiedades de la clase.
                            Nombre = reader["Nombre"].ToString();
                            Delegacion = reader["NombreDelegacion"].ToString();
                            IdDelegacion = Convert.ToInt32(reader["IdDelegacion"]);
                            Rol = reader["NombreRol"].ToString();
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}

