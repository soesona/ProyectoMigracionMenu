using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    /// <summary>
    /// Clase encargada de manejar la recuperación de contraseñas de los usuarios.
    /// Proporciona métodos para obtener el ID del usuario, el correo electrónico y actualizar la contraseña.
    /// </summary>
    public class RecuperacionContrasena
    {
        /// <summary>
        /// Obtiene el ID de un usuario dado su nombre de usuario.
        /// Se realiza una consulta a la base de datos asegurando que el nombre de usuario sea único, sensible a mayúsculas y no contenga espacios múltiples.
        /// </summary>
        /// <param name="nombreUsuario">El nombre del usuario cuyo ID se desea obtener.</param>
        /// <returns>El ID del usuario si se encuentra, de lo contrario devuelve 0.</returns>
        public int ObtenerIdUsuarioPorNombre(string nombreUsuario)
        {
            int idUsuario = 0;  // Variable para almacenar el ID del usuario

            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                // Consulta SQL para obtener el IdUsuario, asegurándose de aplicar validaciones adicionales:
                // Comparación sensible a mayúsculas/minúsculas (COLLATE Latin1_General_CS_AS).
                // Excluye nombres de usuario con espacios múltiples.
                // Solo considera usuarios activos.
                string query = @"
                    SELECT IdUsuario 
                    FROM Usuarios 
                    WHERE Usuario COLLATE Latin1_General_CS_AS = @Usuario
                      AND Usuario NOT LIKE '%  %' 
                      AND Activo = 1";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@Usuario", nombreUsuario);

                // Ejecuta la consulta y obtiene el resultado
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())  // Si encuentra el usuario
                {
                    idUsuario = reader.GetInt32(0);  // Asigna el ID del usuario
                }
            }

            return idUsuario;  // Retorna el ID encontrado o 0 si no existe
        }

        /// <summary>
        /// Obtiene el correo electrónico de un usuario dado su ID.
        /// Realiza una consulta para recuperar el correo asociado al ID de usuario.
        /// </summary>
        /// <param name="idUsuario">El ID del usuario cuyo correo se desea obtener.</param>
        /// <returns>El correo electrónico del usuario.</returns>
        public string ObtenerCorreoDelUsuario(int idUsuario)
        {
            string correo = string.Empty;  // Variable para almacenar el correo

            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                // Consulta SQL para obtener el correo del usuario con el ID proporcionado
                string query = "SELECT Correo FROM Usuarios WHERE IdUsuario = @IdUsuario";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                // Ejecuta la consulta y obtiene el resultado
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())  // Si encuentra el correo
                {
                    correo = reader.GetString(0);  // Asigna el correo
                }
            }

            return correo;  // Retorna el correo encontrado o una cadena vacía si no existe
        }

        /// <summary>
        /// Actualiza la contraseña de un usuario en la base de datos.
        /// Este método también registra la fecha de la última actualización de la contraseña.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario cuya contraseña se desea actualizar.</param>
        /// <param name="nuevaContrasena">La nueva contraseña que se asignará al usuario.</param>
        /// <returns>True si la contraseña se actualizó con éxito, False si no.</returns>
        public bool ActualizarContrasena(int usuarioId, string nuevaContrasena)
        {
            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                // Consulta SQL para actualizar la contraseña y la fecha de última modificación
                string query = "UPDATE Usuarios SET Clave = @Clave, f_ultimaActualizacion = GETDATE() WHERE IdUsuario = @IdUsuario";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Clave", nuevaContrasena);  // Asigna la nueva contraseña
                    cmd.Parameters.AddWithValue("@IdUsuario", usuarioId);  // Asigna el ID del usuario

                    // Ejecuta el comando y verifica cuántas filas fueron afectadas
                    int rowsAffected = cmd.ExecuteNonQuery();
                    // Devuelve True si se actualizó al menos una fila, False en caso contrario
                    return rowsAffected > 0;
                }
            }
        }
    }
}