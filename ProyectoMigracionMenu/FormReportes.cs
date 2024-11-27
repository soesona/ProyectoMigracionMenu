
using DevExpress.XtraReports.UI;
using Microsoft.Reporting.WinForms;
using ProyectoMigracionMenu.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProyectoMigracionMenu
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Activa el doble búfer para mejorar el rendimiento visual
            CargarReportes(); // Carga los tipos de reportes disponibles
        }


        // Clase interna que define los tipos de reportes disponibles
        public class TiposReportes
        {
            public int Id { get; set; }         
            public string Descripcion { get; set; }  
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

            // Parámetros de estilo para los paneles
            int shadowSize = 5;
            int cornerRadius = 20;
            Color shadowColor = Color.Gray;

            // Aplica estilos visuales
            EstiloPanel.AplicarSombra(PanelTipoReporte, shadowSize, shadowColor, cornerRadius);
            EstiloPanel.AplicarEsquinasRedondeadas(PanelTipoReporte, cornerRadius);
            EstiloPanel.AplicarSombra(panelReporte, shadowSize, shadowColor, cornerRadius);
            EstiloPanel.AplicarEsquinasRedondeadas(panelReporte, cornerRadius);

            Clases.Delegaciones delegaciones = new Clases.Delegaciones();
            DataTable dtDelegaciones = delegaciones.CargarDelegaciones();

            CboDelegaciones.DataSource = dtDelegaciones;
            CboDelegaciones.DisplayMember = "NombreDelegacion";
            CboDelegaciones.ValueMember = "IdDelegacion";
            CboDelegaciones.SelectedIndex = -1;
        }

        // Método para mostrar el reporte seleccionado
        private void MostrarReporte()
        {
            // Obtiene los valores seleccionados de las fechas, delegación y reporte seleccionado
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            string nombreDelegacion = CboDelegaciones.Text;
            int tipoReporteId = (int)CboTipoReporte.SelectedValue;

            DataAccess dataAccess = new DataAccess();

            // Genera el reporte basado en el tipo seleccionado
            switch (tipoReporteId)
            {
                case 1:

                    // Reporte general de entradas
                    DSReporteEntradas dataSetGeneral = dataAccess.LlenarReporteGeneral(fechaInicio, fechaFin, nombreDelegacion);
                    ReporteEntradas reporteGeneral = new ReporteEntradas();
                    reporteGeneral.DataSource = dataSetGeneral.DSReporteEntradasDelegaciones;
                    reporteGeneral.DataMember = dataSetGeneral.DSReporteEntradasDelegaciones.TableName;

                    // Oculta los parámetros del reporte
                    foreach (DevExpress.XtraReports.Parameters.Parameter p in reporteGeneral.Parameters)
                        p.Visible = false;

                    // Configura los parámetros del reporte
                    reporteGeneral.parametros(fechaInicio, fechaFin, nombreDelegacion);

                    // Muestra el reporte
                    ReportPrintTool printToolGeneral = new ReportPrintTool(reporteGeneral);
                    printToolGeneral.ShowRibbonPreview();
                    break;

                case 2:
                    // Reporte de migrantes rechazados
                    DSReporteRechazados dataSetRechazados = dataAccess.LlenarReporteRechazados(fechaInicio, fechaFin, nombreDelegacion);
                    ReporteRechazados reporteRechazados = new ReporteRechazados();
                    reporteRechazados.DataSource = dataSetRechazados.DSReporteRechazosDelegaciones;
                    reporteRechazados.DataMember = dataSetRechazados.DSReporteRechazosDelegaciones.TableName;


                    foreach (DevExpress.XtraReports.Parameters.Parameter p in reporteRechazados.Parameters)
                        p.Visible = false;


                    reporteRechazados.parametros(fechaInicio, fechaFin, nombreDelegacion);


                    ReportPrintTool printToolRechazados = new ReportPrintTool(reporteRechazados);
                    printToolRechazados.ShowRibbonPreview();
                    break;

                case 3:
                    // Reporte de migrantes aceptados
                    dsEntra dsEntras = dataAccess.LlenarReporteEntradas(fechaInicio, fechaFin, nombreDelegacion);
                    rptEntra reporteEntra = new rptEntra();
                    reporteEntra.DataSource = dsEntras.DataTable1;
                    reporteEntra.DataMember = dsEntras.DataTable1.TableName;


                    foreach (DevExpress.XtraReports.Parameters.Parameter p in reporteEntra.Parameters)
                        p.Visible = false;


                    reporteEntra.parametros(fechaInicio, fechaFin, nombreDelegacion);


                    ReportPrintTool printToolE = new ReportPrintTool(reporteEntra);
                    printToolE.ShowRibbonPreview();
                    break;

                default:
                    MessageBox.Show("Selecciona un tipo de reporte válido.");
                    break;
            }
        }

        // Evento del botón para generar el reporte
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool hayError = false;

            // Validaciones para asegurarse de que los datos son correctos
            if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                errorProvider1.SetError(dtpFechaInicio, "La fecha de inicio no puede ser mayor que la fecha de fin.");
                hayError = true;
            }

            if (CboDelegaciones.SelectedIndex == -1)
            {
                errorProvider1.SetError(CboDelegaciones, "Selecciona una delegación.");
                hayError = true;
            }

            if (CboTipoReporte.SelectedIndex == -1)
            {
                errorProvider1.SetError(CboTipoReporte, "Selecciona un tipo de reporte.");
                hayError = true;
            }

            if (hayError)
            {
                return;
            }

            MostrarReporte();


        }

        // Evento del botón para limpiar los filtros
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            // Restablece los valores de los controles a sus valores predeterminados
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now; 
            CboDelegaciones.SelectedIndex = -1;
            CboTipoReporte.SelectedIndex = -1;
            errorProvider1.Clear();
        }

        // Carga los tipos de reportes disponibles en el combo box
        private void CargarReportes()
        {
            try
            {
               

                List<TiposReportes> opcionesReporte = new List<TiposReportes>
        {
            new TiposReportes { Id = 1, Descripcion = "General de entradas" },
            new TiposReportes { Id = 2, Descripcion = "Migrantes rechazados" },
            new TiposReportes { Id = 3, Descripcion = "Migrantes aceptados" }
        };

                CboTipoReporte.DataSource = opcionesReporte;
                CboTipoReporte.DisplayMember = "Descripcion";
                CboTipoReporte.ValueMember = "Id";
                CboTipoReporte.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
