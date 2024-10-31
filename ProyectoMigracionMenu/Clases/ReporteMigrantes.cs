using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    public class ReporteMigrantes
    {
        public DataTable GenerarReporteMigrantes(int idDelegacion, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
            {
                string query = @"
                SELECT 
                    d.NombreDelegacion,
                    SUM(CASE WHEN m.IdSexo = 1 THEN 1 ELSE 0 END) AS TotalFemeninos,
                    SUM(CASE WHEN m.IdSexo = 2 THEN 1 ELSE 0 END) AS TotalMasculinos,
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

                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@IdDelegacion", idDelegacion);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}