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
        public string GenerarToken(int idUsuario)
        {
            string token = Guid.NewGuid().ToString(); 
            DateTime fechaCreacion = DateTime.Now;
            DateTime fechaExpiracion = fechaCreacion.AddHours(1);

            AlmacenarTokenEnBD(token, idUsuario, fechaCreacion, fechaExpiracion);

            return token;
        }

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