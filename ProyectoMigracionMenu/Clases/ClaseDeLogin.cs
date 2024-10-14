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

        public string Nombre { get; private set; }
        public string Delegacion { get; private set; }
        public string Rol { get; private set; }

        public bool IniciarSesion(string usuario, string clave)
        {
            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT u.Nombre, d.NombreDelegacion, r.NombreRol " +
                               "FROM Usuarios u " +
                               "JOIN Delegaciones d ON u.IdDelegacion = d.IdDelegacion " +
                               "JOIN Roles r ON u.IdRol = r.IdRol " +
                               "WHERE u.Usuario = @usuario AND u.Clave = @clave AND u.Activo = 1";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Nombre = reader["Nombre"].ToString();
                            Delegacion = reader["NombreDelegacion"].ToString();
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

