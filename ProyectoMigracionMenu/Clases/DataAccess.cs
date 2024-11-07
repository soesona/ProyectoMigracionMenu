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
       
            public DSReporteEntradas LlenarDataSet(DateTime fechaInicio, DateTime fechaFin, int idDelegacion)
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
                    u.IdDelegacion = @IdDelegacion AND  
                    m.f_regCreado BETWEEN @FechaInicio AND @FechaFin
                GROUP BY 
                    d.NombreDelegacion;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdDelegacion", idDelegacion);
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
        }
    } 