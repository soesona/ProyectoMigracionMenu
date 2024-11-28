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
    /// <summary>
    /// Formulario de Dashboard que muestra estadísticas de actividades del usuario.
    /// Muestra conteos diarios, mensuales y anuales de las actividades del usuario, 
    /// y actualiza una gráfica para representar estos datos visualmente.
    /// </summary>
    public partial class FormDashboard : Form
    {
        // Variables para almacenar los conteos de actividad del usuario
        private int todayCount = 0; // Conteo diario de actividades
        private int monthCount = 0; // Conteo mensual de actividades
        private int yearCount = 0;  // Conteo anual de actividades

        // Servicio para interactuar con la capa de datos de la entidad Persona
        private PersonaService personaService = new PersonaService();

        /// <summary>
        /// Constructor del formulario.
        /// Inicializa los componentes y habilita el doble buffer para mejorar el rendimiento gráfico.
        /// </summary>
        public FormDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Habilita el doble buffer para mejorar el rendimiento gráfico
        }

        /// <summary>
        /// Evento que se dispara al cargar el formulario.
        /// Aplica estilos visuales a los paneles y actualiza los datos mostrados en el dashboard.
        /// </summary>
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            // Parámetros para aplicar sombras y esquinas redondeadas a los paneles del formulario
            int shadowSize = 5;
            int cornerRadius = 20;
            Color shadowColor = Color.Gray;

            // Aplica estilos visuales a los paneles del formulario
            EstiloPanel.AplicarSombra(panelHoy, shadowSize, shadowColor, cornerRadius);
            EstiloPanel.AplicarEsquinasRedondeadas(panelHoy, cornerRadius);

            EstiloPanel.AplicarSombra(panelMes, shadowSize, shadowColor, cornerRadius);
            EstiloPanel.AplicarEsquinasRedondeadas(panelMes, cornerRadius);

            EstiloPanel.AplicarSombra(panelAno, shadowSize, shadowColor, cornerRadius);
            EstiloPanel.AplicarEsquinasRedondeadas(panelAno, cornerRadius);

            // Actualiza los datos mostrados en el dashboard
            UpdateDashboard();
        }

        /// <summary>
        /// Obtiene el conteo de actividad del usuario actual para una fecha específica.
        /// </summary>
        /// <param name="date">La fecha para la cual obtener el conteo de actividad.</param>
        /// <returns>El conteo de actividades del usuario para esa fecha.</returns>
        private int GetUserActivityCount(DateTime date)
        {
            string usuarioActual = Login.UsuarioActual.Nombre; // Obtiene el nombre del usuario actual
            return personaService.ObtenerConteoActividadUsuario(date, usuarioActual); // Llama al servicio para obtener el conteo
        }

        /// <summary>
        /// Actualiza las estadísticas del dashboard.
        /// Calcula los conteos de actividades y actualiza los textos y gráficas.
        /// </summary>
        private void UpdateDashboard()
        {
            DateTime today = DateTime.Today; // Fecha actual

            // Calcula los conteos de actividad
            todayCount = GetUserActivityCount(today); // Conteo diario
            monthCount = GetMonthlyUserActivityCount(today); // Conteo mensual
            yearCount = GetYearlyUserActivityCount(today); // Conteo anual

            // Actualiza los textos en los controles correspondientes
            PersonasHoy.Text = todayCount.ToString();
            PersonasMes.Text = monthCount.ToString();
            PersonasAno.Text = yearCount.ToString();

            // Actualiza la gráfica del dashboard
            UpdateChart();
        }

        /// <summary>
        /// Obtiene el conteo mensual de actividad del usuario actual.
        /// </summary>
        /// <param name="date">La fecha actual para calcular el conteo mensual.</param>
        /// <returns>El conteo de actividades en el mes actual.</returns>
        private int GetMonthlyUserActivityCount(DateTime date)
        {
            DateTime monthStart = new DateTime(date.Year, date.Month, 1); // Inicio del mes
            return personaService.ObtenerConteoActividadUsuarioPorRango(monthStart, date); // Conteo entre el inicio del mes y la fecha actual
        }

        /// <summary>
        /// Obtiene el conteo anual de actividad del usuario actual.
        /// </summary>
        /// <param name="date">La fecha actual para calcular el conteo anual.</param>
        /// <returns>El conteo de actividades en el año actual.</returns>
        private int GetYearlyUserActivityCount(DateTime date)
        {
            DateTime yearStart = new DateTime(date.Year, 1, 1); // Inicio del año
            return personaService.ObtenerConteoActividadUsuarioPorRango(yearStart, date); // Conteo entre el inicio del año y la fecha actual
        }

        /// <summary>
        /// Actualiza la gráfica mensual con los datos de actividad del usuario.
        /// Calcula el conteo mensual de actividades y lo muestra en una gráfica.
        /// </summary>
        private void UpdateChart()
        {
            // Diccionario para almacenar los datos de actividad por mes
            var monthlyData = new Dictionary<string, int>();
            DateTime currentDate = DateTime.Today; // Fecha actual

            // Inicializa los meses con valores en 0
            for (int i = 1; i <= 12; i++)
            {
                DateTime monthStart = new DateTime(currentDate.Year, i, 1); // Inicio de cada mes
                string monthName = monthStart.ToString("MMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES")); // Nombre del mes
                monthlyData[monthName] = 0; // Inicializa en 0
            }

            // Calcula el conteo de actividades por cada mes
            for (int i = 1; i <= 12; i++)
            {
                DateTime monthStart = new DateTime(currentDate.Year, i, 1); // Inicio del mes
                DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1); // Fin del mes
                int monthlyCount = personaService.ObtenerConteoActividadUsuarioPorRango(monthStart, monthEnd); // Conteo de actividades en el rango

                string monthName = monthStart.ToString("MMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES")); // Nombre del mes
                monthlyData[monthName] = monthlyCount; // Actualiza el conteo en el diccionario
            }

            // Limpia los puntos existentes en la serie de la gráfica
            chart1.Series["Movimientos"].Points.Clear();

            // Añade los puntos calculados a la gráfica
            int monthIndex = 1;
            foreach (var data in monthlyData)
            {
                DataPoint point = new DataPoint(monthIndex, data.Value); // Crea un punto con el índice del mes y el valor
                point.AxisLabel = data.Key; // Etiqueta del eje X con el nombre del mes
                chart1.Series["Movimientos"].Points.Add(point); // Añade el punto a la serie
                monthIndex++;
            }

            // Configura las propiedades del área de la gráfica
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Interval = 1; // Intervalos de 1 para el eje X
            chartArea.AxisX.Minimum = 1;  // Mínimo valor del eje X
            chartArea.AxisX.Maximum = 12; // Máximo valor del eje X
            chartArea.AxisX.LabelStyle.Angle = -45; // Ángulo de las etiquetas en el eje X
            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true; // Muestra las etiquetas finales
            chartArea.AxisX.MajorGrid.LineWidth = 0; // Oculta las líneas de la cuadrícula mayor

            // Configura las propiedades del eje Y
            chartArea.AxisY.Minimum = 0; // Mínimo valor del eje Y
        }
    }
}