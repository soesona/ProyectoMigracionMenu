﻿using System;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoMigracionMenu.Clases
{
    class SqlServerConnection
    {
        private string connectionString;
        public SqlServerConnection()
        {
            string server = "ENAMORADO\\SQLEXPRESS";
            string database = "MigracionPrueba";
            // string user = "sa";
            // string password = "12345678";
            //  connectionString = $"Server={server};Database={database};User Id={user};Password={password};"; ESTO SI TIENEN POR USUARIO

            connectionString = $"Server={server};Database={database};Integrated Security=True;";
        }

        public SqlConnection EstablecerConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
            }
            return conexion;
        }
    }
}
