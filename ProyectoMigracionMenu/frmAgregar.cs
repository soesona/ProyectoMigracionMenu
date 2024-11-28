using ProyectoMigracionMenu.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoMigracionMenu
{
    public partial class frmAgregar : Form
    {
        SqlServerConnection gl = new SqlServerConnection();
        string _tabla; // Variable que guarda el nombre de la tabla
        string query;  // Variable para las consultas SQL

        /// <summary>
        /// Constructor de la clase que recibe el nombre de la tabla y lo asigna a la variable _tabla
        /// </summary>
        public frmAgregar(string tabla)
        {
            InitializeComponent();
            _tabla = tabla;
        }

        /// <summary>
        /// Evento que se ejecuta cuando se presiona una tecla en el campo de texto txtAgregar.
        /// Realiza varias validaciones como: caracteres permitidos, longitud máxima, 
        /// tres caracteres consecutivos iguales y espacios consecutivos.
        /// </summary>
        private void txtAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = txtAgregar.Text;
            // Elimina los espacios consecutivos y los reemplaza por un solo espacio
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"\s{2,}", " ");
            txtAgregar.Text = texto;
            txtAgregar.SelectionStart = texto.Length;

            // Si la tecla presionada es "Backspace", no hace nada
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            // Si el texto supera los 20 caracteres, muestra advertencia y evita la entrada
            if (txtAgregar.Text.Length >= 20)
            {
                e.Handled = true;
                MostrarAdvertencia("Máximo 20 caracteres permitidos.");
                return;
            }

            // Permite solo letras y espacios en el campo de texto
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MostrarAdvertencia("Solo se permiten letras y espacios.");
                return;
            }

            // No permite tres caracteres consecutivos iguales
            if (txtAgregar.Text.Length >= 2)
            {
                string ultimosTresCaracteres = txtAgregar.Text.Length >= 2
                    ? txtAgregar.Text.Substring(txtAgregar.Text.Length - 2) + e.KeyChar
                    : txtAgregar.Text + e.KeyChar;

                if (ultimosTresCaracteres[0] == ultimosTresCaracteres[1] &&
                    ultimosTresCaracteres[1] == e.KeyChar)
                {
                    e.Handled = true;
                    MostrarAdvertencia("No se permiten tres caracteres iguales consecutivos.");
                    return;
                }
            }

            // Evita espacios consecutivos al final del texto
            if (e.KeyChar == ' ' && txtAgregar.Text.EndsWith(" "))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Evento que se ejecuta cada vez que el texto en el campo de texto txtAgregar cambia.
        /// Realiza validaciones adicionales para asegurar que el texto cumpla con los requisitos establecidos.
        /// </summary>
        private void txtAgregar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtAgregar.Text;

            // Si el texto está vacío, no realiza ninguna acción
            if (string.IsNullOrEmpty(texto))
                return;

            // Valida que solo se permitan letras y espacios, y que no se superen los 20 caracteres
            if (!ValidarCaracteresPermitidos(texto))
            {
                MostrarAdvertencia("Solo se permiten letras y espacios. Máximo 20 caracteres.");
                CorregirTexto(txtAgregar);
                return;
            }

            // Verifica si el texto contiene tres caracteres iguales consecutivos
            if (ContieneTresCaracteresIgualesConsecutivos(texto))
            {
                MostrarAdvertencia("No se permiten tres caracteres iguales consecutivos.");
                CorregirTexto(txtAgregar);
                return;
            }

            // Verifica si el texto contiene espacios consecutivos
            if (ContieneEspaciosConsecutivos(texto))
            {
                MostrarAdvertencia("No se permiten dos espacios consecutivos.");
                CorregirTexto(txtAgregar);
                return;
            }
        }

        /// <summary>
        /// Valida que el texto ingresado solo contenga letras, espacios y no exceda los 20 caracteres.
        /// </summary>
        private bool ValidarCaracteresPermitidos(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,20}$");
        }

        /// <summary>
        /// Verifica si el texto contiene tres caracteres iguales consecutivos.
        /// </summary>
        private bool ContieneTresCaracteresIgualesConsecutivos(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1");
        }

        /// <summary>
        /// Verifica si el texto contiene espacios consecutivos.
        /// </summary>
        private bool ContieneEspaciosConsecutivos(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"\s{2,}");
        }

        /// <summary>
        /// Muestra un mensaje de advertencia al usuario en caso de que alguna validación falle.
        /// </summary>
        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Corrige el texto del campo de texto eliminando el último carácter ingresado.
        /// </summary>
        private void CorregirTexto(TextBox textBox)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        /// <summary>
        /// Evento que se ejecuta cuando el usuario hace clic en el botón de agregar un nuevo registro.
        /// Valida el texto ingresado y, si es válido, lo agrega a la base de datos.
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
            {
                // Si el campo de texto no está vacío
                if (!string.IsNullOrWhiteSpace(txtAgregar.Text))
                {
                    // Si el texto es válido según las validaciones
                    if (txtAgregar.Text.Length <= 20 &&
                        ValidarCaracteresPermitidos(txtAgregar.Text) &&
                        !ContieneTresCaracteresIgualesConsecutivos(txtAgregar.Text) &&
                        !ContieneEspaciosConsecutivos(txtAgregar.Text))
                    {
                        // Verifica si ya existe el registro en la base de datos
                        query = "select count (*) from " + _tabla + " where Descripcion = '" + txtAgregar.Text + "'";
                        if (gl.retornaEntero(query, sqlcon) == 1)
                        {
                            MessageBox.Show("El registro ya ha sido registrado con anterioridad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Si no existe, lo inserta en la base de datos
                        query = "insert into " + _tabla + " (Descripcion, f_regCreado, Activo) values ('" + txtAgregar.Text + "',GETDATE(), 1)";
                        gl.registra(query, sqlcon);
                        MessageBox.Show("Registro Agregado con Éxito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtAgregar.Clear();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El texto ingresado solo debe contener letras, espacios, no puede exceder los 20 caracteres, no puede contener tres caracteres iguales consecutivos ni dos espacios seguidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAgregar.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un registro en el campo de descripción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAgregar.Focus();
                    return;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmAgregar_MouseDown(object sender, MouseEventArgs e)
        {

            
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }

       
    }
}