using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    public class DataAccess
    {
        public DSReporteEntradas LlenarReporteGeneral(DateTime fechaInicio, DateTime fechaFin, string nombreDelegacion)
        {
            DSReporteEntradas dataSet = new DSReporteEntradas();

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
                    command.Parameters.AddWithValue("@NombreDelegacion", nombreDelegacion);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet.DSReporteEntradasDelegaciones);
                    }
                }
            }

            return dataSet;
        }

        public DSReporteRechazados LlenarReporteRechazados(DateTime fechaInicio, DateTime fechaFin, string nombreDelegacion)
        {
            DSReporteRechazados dataSet = new DSReporteRechazados();

            using (SqlConnection connection = new SqlServerConnection().EstablecerConexion())
            {
                string query = @"
                    SELECT 
                        CONCAT(m.Nombres, ' ', m.Apellidos) AS NombreCompleto,
                        m.Identidad AS NumeroDocumento,
                        DATEDIFF(YEAR, m.f_Nacimiento, GETDATE()) AS Edad,
                        CASE WHEN m.IdSexo = 1 THEN 'Femenino' 
                             WHEN m.IdSexo = 2 THEN 'Masculino' 
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


    }
   
}