﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    public class RecuperacionContrasena
    {
        private string connectionString = $"Server=ENAMORADO\\SQLEXPRESS;Database=MigracionPrueba;Integrated Security=True;"; 

        public int ObtenerIdUsuarioPorNombre(string nombreUsuario)
        {
            int idUsuario = 0;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT IdUsuario FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@Usuario", nombreUsuario);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    idUsuario = reader.GetInt32(0); 
                }
            }
            return idUsuario;
        }

        public string ObtenerCorreoDelUsuario(int idUsuario)
        {
            string correo = string.Empty;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT Correo FROM Usuarios WHERE IdUsuario = @IdUsuario";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    correo = reader.GetString(0); 
                }
            }
            return correo;
        }
        public bool ActualizarContrasena(int usuarioId, string nuevaContrasena)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "UPDATE Usuarios SET Clave = @Clave, f_ultimaActualizacion = GETDATE() WHERE IdUsuario = @IdUsuario";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Clave", nuevaContrasena); 
                    cmd.Parameters.AddWithValue("@IdUsuario", usuarioId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}