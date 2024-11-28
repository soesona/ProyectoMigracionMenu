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
        /// <summary>
        /// Inserta una persona en la base de datos y ejecuta el procedimiento almacenado correspondiente.
        /// </summary>
        /// <returns>Devuelve un valor booleano que indica si la inserción fue exitosa.</returns>
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
                // Establece una conexión con la base de datos.
                using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
                {
                    // Asegura que la conexión esté abierta.
                    if (sqlcon.State != ConnectionState.Open)
                        sqlcon.Open();

                    // Crea el comando para ejecutar el procedimiento almacenado.
                    SqlCommand cmd = new SqlCommand("InsertarPersona", sqlcon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Agrega los parámetros al comando.
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

                    // Ejecuta el procedimiento almacenado.
                    cmd.ExecuteNonQuery();

                    // Si todo es correcto, retorna true.
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error, lanza una excepción con el mensaje del error.
                throw new Exception($"Ocurrió un error al guardar los datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene la consulta SQL para buscar a una persona por su identidad.
        /// </summary>
        /// <returns>Una cadena con la consulta SQL.</returns>
        public static string ObtenerConsultaBuscarPersona()
        {
            return "SELECT FORMAT(A.f_regCreado, 'dd-MM-yyyy') Fecha, " +
                   "CASE WHEN TipoDocumento = 1 THEN 'Identidad' " +
                   "WHEN TipoDocumento = 2 THEN 'Pasaporte' ELSE 'Otro' END tipoDocu, " +
                   "A.Identidad no, E.Descripcion Origen, I.Descripcion Destino, " +
                   "A.Observacion Observaciones, A.UsuarioCreado usuario, A.Nombres, A.Apellidos, " +
                   "A.Fotografia Imagen, A.f_Nacimiento, A.IdSexo, A.IdPaisNacimiento, " +
                   "A.IdPaisEmision, A.f_regFinal, A.TipoDocumento, A.Estado " +
                   "FROM Personas A " +
                   "INNER JOIN Pais E ON A.IdPaisResidencia = E.IdPais " +
                   "INNER JOIN Pais I ON A.IdPaisDestino = I.IdPais " +
                   "WHERE A.Identidad = @Identidad";  // Utiliza un parámetro para la identidad
        }
    }
}
