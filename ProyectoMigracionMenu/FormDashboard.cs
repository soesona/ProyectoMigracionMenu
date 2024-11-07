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

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            int shadowSize = 5;
            int cornerRadius = 20;
            Color shadowColor = Color.Gray;

            EstiloPanel.AplicarSombra(panelHoy, shadowSize, shadowColor, cornerRadius);
            EstiloPanel.AplicarEsquinasRedondeadas(panelHoy, cornerRadius);

            EstiloPanel.AplicarSombra(panelMes, shadowSize, shadowColor, cornerRadius);
            EstiloPanel.AplicarEsquinasRedondeadas(panelMes, cornerRadius);

            EstiloPanel.AplicarSombra(panelAno, shadowSize, shadowColor, cornerRadius);
            EstiloPanel.AplicarEsquinasRedondeadas(panelAno, cornerRadius);

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
            
            var monthlyData = new Dictionary<string, int>();
            DateTime currentDate = DateTime.Today;

            for (int i = 1; i <= 12; i++)
            {
                DateTime monthStart = new DateTime(currentDate.Year, i, 1);
                string monthName = monthStart.ToString("MMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));
                monthlyData[monthName] = 0; 
            }

            
            for (int i = 1; i <= 12; i++)
            {
                DateTime monthStart = new DateTime(currentDate.Year, i, 1);
                DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1);
                int monthlyCount = personaService.ObtenerConteoActividadUsuarioPorRango(monthStart, monthEnd);

                string monthName = monthStart.ToString("MMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));
                monthlyData[monthName] = monthlyCount;
            }

          
            chart1.Series["Movimientos"].Points.Clear();

           
            int monthIndex = 1;
            foreach (var data in monthlyData)
            {
                DataPoint point = new DataPoint(monthIndex, data.Value); 
                point.AxisLabel = data.Key;  
                chart1.Series["Movimientos"].Points.Add(point);
                monthIndex++;
            }

            
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Interval = 1; 
            chartArea.AxisX.Minimum = 1;  
            chartArea.AxisX.Maximum = 12; 
            chartArea.AxisX.LabelStyle.Angle = -45; 
            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;
            chartArea.AxisX.MajorGrid.LineWidth = 0; 

            
            chartArea.AxisY.Minimum = 0;
        }

    }
}

