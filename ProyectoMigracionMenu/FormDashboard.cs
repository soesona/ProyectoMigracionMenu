using ProyectoMigracionMenu.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoMigracionMenu
{
    public partial class FormDashboard : Form
    {
        private int todayCount = 0;
        private int monthCount = 0;
        private int yearCount = 0;
        private PersonaService personaService = new PersonaService(); 

        public FormDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void ApplyShadowEffect(Panel panel, int shadowSize, Color shadowColor, int cornerRadius)
        {
            Panel shadowPanel = new Panel();
            shadowPanel.Size = panel.Size;
            shadowPanel.Location = new Point(panel.Location.X + shadowSize, panel.Location.Y + shadowSize);
            shadowPanel.BackColor = shadowColor;

            ApplyRoundedCorners(shadowPanel, cornerRadius);

            panel.Parent.Controls.Add(shadowPanel);
            shadowPanel.SendToBack();
        }

        private void ApplyRoundedCorners(Panel panel, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            int shadowSize = 5;
            int cornerRadius = 20;
            Color shadowColor = Color.Gray;

            ApplyShadowEffect(panelHoy, shadowSize, shadowColor, cornerRadius);
            ApplyRoundedCorners(panelHoy, cornerRadius);

            ApplyShadowEffect(panelMes, shadowSize, shadowColor, cornerRadius);
            ApplyRoundedCorners(panelMes, cornerRadius);

            ApplyShadowEffect(panelAno, shadowSize, shadowColor, cornerRadius);
            ApplyRoundedCorners(panelAno, cornerRadius);

            UpdateDashboard();
        }

        private int GetUserActivityCount(DateTime date)
        {
            string usuarioActual = Login.UsuarioActual.Nombre; 
            return personaService.ObtenerConteoActividadUsuario(date, usuarioActual);
        }

        private void UpdateDashboard()
        {
            DateTime today = DateTime.Today;
            todayCount = GetUserActivityCount(today);
            monthCount = GetMonthlyUserActivityCount(today); 
            yearCount = GetYearlyUserActivityCount(today); 

            PersonasHoy.Text = todayCount.ToString();
            PersonasMes.Text = monthCount.ToString();
            PersonasAno.Text = yearCount.ToString();

            UpdateChart();
        }

        private int GetMonthlyUserActivityCount(DateTime date)
        {
            DateTime monthStart = new DateTime(date.Year, date.Month, 1);
            return personaService.ObtenerConteoActividadUsuarioPorRango(monthStart, date);
        }

        private int GetYearlyUserActivityCount(DateTime date)
        {
            DateTime yearStart = new DateTime(date.Year, 1, 1);
            return personaService.ObtenerConteoActividadUsuarioPorRango(yearStart, date);
        }

        private void UpdateChart()
        {
            var monthlyData = new Dictionary<int, int>();
            DateTime currentDate = DateTime.Today;
            for (int i = 1; i <= 12; i++)
            {
                DateTime monthStart = new DateTime(currentDate.Year, i, 1);
                DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1); // Fin del mes
                int monthlyCount = personaService.ObtenerConteoActividadUsuarioPorRango(monthStart, monthEnd);
                monthlyData[i] = monthlyCount;
            }

            chart1.Series["Movimientos"].Points.Clear();
            foreach (var data in monthlyData)
            {
                chart1.Series["Movimientos"].Points.AddXY(data.Key, data.Value);
            }
        }

        private void panelHoy_Paint(object sender, PaintEventArgs e) { }
        private void panelMes_Paint(object sender, PaintEventArgs e) { }
        private void panelAno_Paint(object sender, PaintEventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
    }
}

namespace ProyectoMigracionMenu.Clases
{
    public class PersonaService
    {
        public int ObtenerConteoActividadUsuario(DateTime fecha, string usuarioActual)
        {
            int conteoActividad = 0;

            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT COUNT(*) FROM Personas WHERE UsuarioCreado = @usuario AND CAST(f_regCreado AS DATE) = @fecha";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@usuario", usuarioActual);
                    command.Parameters.AddWithValue("@fecha", fecha.Date);

                    conteoActividad = (int)command.ExecuteScalar();
                }
            }
            return conteoActividad;
        }

        public int ObtenerConteoActividadUsuarioPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            int conteoActividad = 0;
            string usuarioActual = Login.UsuarioActual.Nombre;

            using (SqlConnection conexion = new SqlServerConnection().EstablecerConexion())
            {
                string query = "SELECT COUNT(*) FROM Personas WHERE UsuarioCreado = @usuario AND CAST(f_regCreado AS DATE) BETWEEN @fechaInicio AND @fechaFin";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@usuario", usuarioActual);
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date);
                    command.Parameters.AddWithValue("@fechaFin", fechaFin.Date);

                    conteoActividad = (int)command.ExecuteScalar();
                }
            }
            return conteoActividad;
        }
    }
}