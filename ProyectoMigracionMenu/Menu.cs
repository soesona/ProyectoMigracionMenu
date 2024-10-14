using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMigracionMenu
{
    public partial class Menu : Form
    {

        private Form activeForm;
        public Menu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            DoubleBufferedPanel(panelContenedor);
            OpenChildForm(new FormDashboard(), null);
        }
        private void DoubleBufferedPanel(Control control)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(childForm);
            this.panelContenedor.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTitulo.Text = childForm.Text;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReportes(), sender);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDashboard(), sender);
        }

        private void BtnInspeccionPrimaria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInspPrimariaINICIOcs(), sender);
        }

        private void BtnInspeccionSecundaria_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInspSecundariaINICIO(), sender);
        }
    }
}
