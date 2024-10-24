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

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlServerConnection().EstablecerConexion())
            {
                if (!string.IsNullOrWhiteSpace(txtAgregar.Text))
                {
                    query = "insert into " + _tabla + " (Descripcion, f_regCreado, Activo) values ('" + txtAgregar.Text + "',GETDATE(), 1)";
                    gl.registra(query, sqlcon);
                    MessageBox.Show("Registro Agregado con Exito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAgregar.Clear();
                    this.Close();
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
    }
}
