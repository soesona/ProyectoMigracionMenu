using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    public class ClaseInspPrimaria
    {
        public static bool InsertarPersona(string tipoDocumento, string identidad, string nombres, string apellidos,
                                           int idSexo, int idPaisEmision, string usuarioCreado, DateTime f_regCreado,
                                           DateTime f_regFinal, int estado, int idPaisNacimiento, int idPaisResidencia,
                                           string observacion, string lugarResidencia, DateTime f_Nacimiento, int idMotivoViaje,
                                           int idPaisDestino, int idTrabajo, byte[] fotografia, int diasOtogados,
                                           bool documentoRobado, bool documentoVencido, bool interpol, bool alertaMigratoria,
                                           bool prechequeo)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    if (sqlcon.State != ConnectionState.Open)
                        sqlcon.Open();

                    SqlCommand cmd = new SqlCommand("InsertarPersona", sqlcon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

               
                    cmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                    cmd.Parameters.AddWithValue("@Identidad", identidad);
                    cmd.Parameters.AddWithValue("@Nombres", nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@IdSexo", idSexo);
                    cmd.Parameters.AddWithValue("@IdPaisEmision", idPaisEmision);
                    cmd.Parameters.AddWithValue("@UsuarioCreado", usuarioCreado);
                    cmd.Parameters.AddWithValue("@f_regCreado", f_regCreado);
                    cmd.Parameters.AddWithValue("@f_regFinal", f_regFinal);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@IdPaisNacimiento", idPaisNacimiento);
                    cmd.Parameters.AddWithValue("@IdPaisResidencia", idPaisResidencia);
                    cmd.Parameters.AddWithValue("@Observacion", observacion);
                    cmd.Parameters.AddWithValue("@LugarResidencia", lugarResidencia);
                    cmd.Parameters.AddWithValue("@f_Nacimiento", f_Nacimiento);
                    cmd.Parameters.AddWithValue("@IdMotivoViaje", idMotivoViaje);
                    cmd.Parameters.AddWithValue("@IdPaisDestino", idPaisDestino);
                    cmd.Parameters.AddWithValue("@IdTrabajo", idTrabajo);
                    cmd.Parameters.AddWithValue("@Fotografia", fotografia);
                    cmd.Parameters.AddWithValue("@diasOtogados", diasOtogados);
                    cmd.Parameters.AddWithValue("@DocumentoRobado", documentoRobado);
                    cmd.Parameters.AddWithValue("@DocumentoVencido", documentoVencido);
                    cmd.Parameters.AddWithValue("@Interpol", interpol);
                    cmd.Parameters.AddWithValue("@AlertaMigratoria", alertaMigratoria);
                    cmd.Parameters.AddWithValue("@Prechequeo", prechequeo);

                    cmd.ExecuteNonQuery();

                    return true; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al guardar los datos: {ex.Message}");
            }
        }
    }
}
