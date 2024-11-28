using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    public class TokenGenerador
    {
        // Método principal para generar un token único para un usuario específico.
        // Incluye la creación de un identificador único, la asignación de fechas de creación y expiración, 
        // y el almacenamiento del token en la base de datos.
        public string GenerarToken(int idUsuario)
        {
            string token = Guid.NewGuid().ToString();
            DateTime fechaCreacion = DateTime.Now;
            DateTime fechaExpiracion = fechaCreacion.AddHours(1);

            AlmacenarTokenEnBD(token, idUsuario, fechaCreacion, fechaExpiracion);

            return token;
        }

        // Método privado para almacenar el token generado en la base de datos.
        // Utiliza una conexión SQL y parámetros para registrar el token junto con su usuario asociado, 
        // fecha de creación y fecha de expiración.
        private void AlmacenarTokenEnBD(string token, int idUsuario, DateTime fechaCreacion, DateTime fechaExpiracion)
        {
            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "INSERT INTO Tokens (Token, IdUsuario, FechaCreacion, FechaExpiracion) VALUES (@Token, @IdUsuario, @FechaCreacion, @FechaExpiracion)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Token", token);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);
                    cmd.Parameters.AddWithValue("@FechaExpiracion", fechaExpiracion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método público para verificar si un token es válido para un usuario específico.
        // Revisa la base de datos para comprobar que el token existe, no ha expirado y no ha sido usado previamente.
        public bool VerificarToken(int idUsuario, string token)
        {
            bool tokenValido = false;
            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT COUNT(*) FROM Tokens WHERE IdUsuario = @IdUsuario AND Token = @Token AND FechaExpiracion > GETDATE() AND Usado = 0";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Token", token);

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        tokenValido = true;
                        MarcarTokenComoUsado(idUsuario, token);
                    }
                }
            }
            return tokenValido;
        }

        // Método privado para marcar un token como usado en la base de datos.
        // Se invoca automáticamente después de verificar un token válido, para evitar su reutilización.
        private void MarcarTokenComoUsado(int idUsuario, string token)
        {
            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "UPDATE Tokens SET Usado = 1 WHERE IdUsuario = @IdUsuario AND Token = @Token";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Token", token);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}