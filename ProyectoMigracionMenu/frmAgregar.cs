using ProyectoMigracionMenu.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMigracionMenu
{
    public partial class frmAgregar : Form
    {
        SqlServerConnection gl = new SqlServerConnection();
        string _tabla;
        string query;

        public frmAgregar(string tabla)
        {
            InitializeComponent();
            _tabla = tabla;
        }

        private void txtAgregar_KeyPress(object sender, KeyPressEventArgs e)


        {
            string texto = txtAgregar.Text;
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"\s{2,}", " ");
           txtAgregar.Text = texto;
           txtAgregar.SelectionStart = texto.Length;


            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

           
            if (txtAgregar.Text.Length >= 20)
            {
                e.Handled = true;
                MostrarAdvertencia("Máximo 20 caracteres permitidos.");
                return;
            }

           
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MostrarAdvertencia("Solo se permiten letras y espacios.");
                return;
            }

        
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

         
            if (e.KeyChar == ' ' && txtAgregar.Text.EndsWith(" "))
            {
                e.Handled = true;
               
                return;
            }
        }

        private void txtAgregar_TextChanged(object sender, EventArgs e)
        {


            string texto =txtAgregar .Text;

            if (string.IsNullOrEmpty(texto))
                return;


            if (!ValidarCaracteresPermitidos(texto))
            {
                MostrarAdvertencia("Solo se permiten letras y espacios. Máximo 20 caracteres.");
                CorregirTexto(txtAgregar);
                return;
            }

          
            if (ContieneTresCaracteresIgualesConsecutivos(texto))
            {
                MostrarAdvertencia("No se permiten tres caracteres iguales consecutivos.");
                CorregirTexto(txtAgregar);
                return;
            }

           
            if (ContieneEspaciosConsecutivos(texto))
            {
                MostrarAdvertencia("No se permiten dos espacios consecutivos.");
                CorregirTexto(txtAgregar);
                return;
            }
        }


        private bool ValidarCaracteresPermitidos(string texto)
        {
          
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]{1,20}$");
        }

        private bool ContieneTresCaracteresIgualesConsecutivos(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"(.)\1\1");
        }

        private bool ContieneEspaciosConsecutivos(string texto)
        {

            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"\s{2,}");
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CorregirTexto(TextBox textBox)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
            {
                if (!string.IsNullOrWhiteSpace(txtAgregar.Text))
                {
                    if (txtAgregar.Text.Length <= 20 &&
                        ValidarCaracteresPermitidos(txtAgregar.Text) &&
                        !ContieneTresCaracteresIgualesConsecutivos(txtAgregar.Text) &&
                        !ContieneEspaciosConsecutivos(txtAgregar.Text))
                    {
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

        private void Documentoviaje_Enter(object sender, EventArgs e)
        {

        }
    }
}