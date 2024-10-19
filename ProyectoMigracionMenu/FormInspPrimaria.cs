using ProyectoMigracionMenu;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interfaz_grafica_de_inspeccion_primaria
{
    public partial class FormInspPrimaria : Form
    {
        public FormInspPrimaria()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {




            for (int i = 0; i < 7; i++)
            {

            }



        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BusquedaMigrantes BusquedaMigrantes = new BusquedaMigrantes();

BusquedaMigrantes.ShowDialog();
        }
    }
}
