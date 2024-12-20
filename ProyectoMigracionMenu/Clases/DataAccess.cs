﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    public class DataAccess
    {
        /// <summary>
        /// Método para llenar el reporte general con totales de hombres, mujeres y menores por delegación.
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio para filtrar los registros.</param>
        /// <param name="fechaFin">Fecha de fin para filtrar los registros.</param>
        /// <param name="nombreDelegacion">Nombre de la delegación para filtrar los registros.</param>
        /// <returns>Devuelve un conjunto de datos con la información del reporte general.</returns>
        public DSReporteEntradas LlenarReporteGeneral(DateTime fechaInicio, DateTime fechaFin, string nombreDelegacion)
        {
            DSReporteEntradas dataSet = new DSReporteEntradas();

            // Ajustar las fechas para incluir todo el día desde el inicio hasta el final
            fechaInicio = fechaInicio.Date;
            fechaFin = fechaFin.Date.AddDays(1).AddMilliseconds(-1);

            using (SqlConnection connection = new SqlServerConnection().EstablecerConexion())
            {
                string query = @"
                SELECT 
                    d.NombreDelegacion,  
                    SUM(CASE WHEN m.IdSexo = 2 THEN 1 ELSE 0 END) AS TotalFemeninos,  
                    SUM(CASE WHEN m.IdSexo = 1 THEN 1 ELSE 0 END) AS TotalMasculinos,  
                    SUM(CASE WHEN DATEDIFF(YEAR, m.f_Nacimiento, GETDATE()) < 18 THEN 1 ELSE 0 END) AS TotalMenores
                FROM 
                    Personas m
                JOIN 
                    Usuarios u ON m.UsuarioCreado = u.Nombre
                JOIN 
                    Delegaciones d ON u.IdDelegacion = d.IdDelegacion
                WHERE 
                    d.NombreDelegacion = @NombreDelegacion AND  
                    m.f_regCreado BETWEEN @FechaInicio AND @FechaFin
                GROUP BY 
                    d.NombreDelegacion;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros para la delegación y las fechas
                    command.Parameters.AddWithValue("@NombreDelegacion", nombreDelegacion);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Llenar el DataSet con los datos obtenidos
                        adapter.Fill(dataSet.DSReporteEntradasDelegaciones);
                    }
                }
            }

            return dataSet;
        }

        /// <summary>
        /// Método para llenar el reporte de migrantes rechazados con el estado en 0.
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio para filtrar los registros.</param>
        /// <param name="fechaFin">Fecha de fin para filtrar los registros.</param>
        /// <param name="nombreDelegacion">Nombre de la delegación para filtrar los registros.</param>
        /// <returns>Devuelve un conjunto de datos con la información de migrantes rechazados.</returns>
        public DSReporteRechazados LlenarReporteRechazados(DateTime fechaInicio, DateTime fechaFin, string nombreDelegacion)
        {
            DSReporteRechazados dataSet = new DSReporteRechazados();

            fechaInicio = fechaInicio.Date;
            fechaFin = fechaFin.Date.AddDays(1).AddMilliseconds(-1);

            using (SqlConnection connection = new SqlServerConnection().EstablecerConexion())
            {
                string query = @"
            SELECT 
                CONCAT(m.Nombres, ' ', m.Apellidos) AS NombreCompleto,
                m.Identidad AS NumeroDocumento,
                DATEDIFF(YEAR, m.f_Nacimiento, GETDATE()) AS Edad,
                CASE WHEN m.IdSexo = 1 THEN 'Masculino' 
                     WHEN m.IdSexo = 2 THEN 'Femenino' 
                END AS Sexo,
                pbn.Descripcion AS PaisNacimiento,
                pbd.Descripcion AS PaisDestino
            FROM 
                Personas m
            JOIN 
                Pais pbn ON m.IdPaisNacimiento = pbn.IdPais
            JOIN 
                Pais pbd ON m.IdPaisDestino = pbd.IdPais
            WHERE 
                m.Estado = 0  
                AND m.f_regCreado BETWEEN @FechaInicio AND @FechaFin
                AND EXISTS (
                    SELECT 1 FROM Usuarios u 
                    WHERE u.Nombre = m.UsuarioCreado
                    AND u.IdDelegacion IN (SELECT IdDelegacion FROM Delegaciones WHERE NombreDelegacion = @NombreDelegacion)
                )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreDelegacion", nombreDelegacion);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet.DSReporteRechazosDelegaciones);
                    }
                }
            }

            return dataSet;
        }

        /// <summary>
        /// Método para llenar el reporte de migrantes aceptados con el estado en 2.
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio para filtrar los registros.</param>
        /// <param name="fechaFin">Fecha de fin para filtrar los registros.</param>
        /// <param name="nombreDelegacion">Nombre de la delegación para filtrar los registros.</param>
        /// <returns>Devuelve un conjunto de datos con la información de migrantes aceptados.</returns>
        public dsEntra LlenarReporteEntradas(DateTime fechaInicio, DateTime fechaFin, string nombreDelegacion)
        {
            dsEntra dataSet = new dsEntra();

            fechaInicio = fechaInicio.Date;
            fechaFin = fechaFin.Date.AddDays(1).AddMilliseconds(-1);

            using (SqlConnection connection = new SqlServerConnection().EstablecerConexion())
            {
                string query = @"
            SELECT 
                CONCAT(m.Nombres, ' ', m.Apellidos) AS NombreCompleto,
                m.Identidad AS NumeroDocumento,
                DATEDIFF(YEAR, m.f_Nacimiento, GETDATE()) AS Edad,
                CASE WHEN m.IdSexo = 1 THEN 'Masculino' 
                     WHEN m.IdSexo = 2 THEN 'Femenino' 
                END AS Sexo,
                pbn.Descripcion AS PaisNacimiento,
                pbd.Descripcion AS PaisDestino
            FROM 
                Personas m
            JOIN 
                Pais pbn ON m.IdPaisNacimiento = pbn.IdPais
            JOIN 
                Pais pbd ON m.IdPaisDestino = pbd.IdPais
            WHERE 
                m.Estado = 2
                AND m.f_regCreado BETWEEN @FechaInicio AND @FechaFin
                AND EXISTS (
                    SELECT 1 FROM Usuarios u 
                    WHERE u.Nombre = m.UsuarioCreado
                    AND u.IdDelegacion IN (SELECT IdDelegacion FROM Delegaciones WHERE NombreDelegacion = @NombreDelegacion)
                )";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreDelegacion", nombreDelegacion);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet.DataTable1);
                    }
                }
            }

            return dataSet;
        }
    }
}
