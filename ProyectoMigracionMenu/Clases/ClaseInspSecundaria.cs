using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{

    public class ClaseInspSecundaria
    {
        /// <summary>
        /// Genera la consulta SQL para obtener información de personas activas junto con sus detalles de documentos, alertas migratorias y otra información personal.
        /// </summary>
        /// <returns>Una cadena que contiene la consulta SQL.</returns>
        public string ConsultaPersonasActivas()
        {
            return @"
            SELECT 
                A.IdPersonas AS Id, 
                CASE 
                    WHEN TipoDocumento = 1 THEN 'IDENTIDAD' 
                    WHEN TipoDocumento = 2 THEN 'PASAPORTE' 
                    ELSE 'Otro' 
                END AS Doc, 
                E.Descripcion AS PaisEmisor, 
                A.Identidad AS Identidad, 
                FORMAT(A.f_regFinal, 'dd-MM-yyyy') AS FechaV, 
                RTRIM(A.Nombres) + ' ' + RTRIM(A.Apellidos) AS NombreCompleto, 
                A.Nombres, 
                A.Apellidos, 
                I.Descripcion AS Sexo, 
                A.Fotografia AS Imagen, 
                A.Observacion AS Observacion, 
                FORMAT(A.f_regCreado, 'dd-MM-yyyy') AS Fecha, 
                CASE 
                    WHEN DocumentoRobado = 0 
                         AND DocumentoVencido = 0 
                         AND Interpol = 0 
                         AND AlertaMigratoria = 0 
                         AND Prechequeo = 0 
                    THEN 'NINGUNA'
                    ELSE (
                        CASE WHEN DocumentoRobado = 1 THEN 'DOCUMENTO ROBADO' ELSE '' END + 
                        CASE WHEN DocumentoVencido = 1 THEN 
                            CASE WHEN DocumentoRobado = 1 THEN ', ' ELSE '' END + 'DOCUMENTO VENCIDO' 
                        ELSE '' END + 
                        CASE WHEN Interpol = 1 THEN 
                            CASE WHEN DocumentoRobado = 1 OR DocumentoVencido = 1 THEN ', ' ELSE '' END + 'INTERPOL' 
                        ELSE '' END + 
                        CASE WHEN AlertaMigratoria = 1 THEN 
                            CASE WHEN DocumentoRobado = 1 OR DocumentoVencido = 1 OR Interpol = 1 THEN ', ' ELSE '' END + 'ALERTA MIGRATORIA' 
                        ELSE '' END + 
                        CASE WHEN Prechequeo = 1 THEN 
                            CASE WHEN DocumentoRobado = 1 OR DocumentoVencido = 1 OR Interpol = 1 OR AlertaMigratoria = 1 THEN ', ' ELSE '' END + 'PRECHEQUEO' 
                        ELSE '' END
                    )
                END AS AlertasMigratorias
            FROM 
                Personas A 
            INNER JOIN 
                Pais E ON A.IdPaisEmision = E.IdPais 
            INNER JOIN 
                Sexo I ON A.IdSexo = I.IdSexo 
            WHERE 
                A.Estado = 1";
        }
    }

}