
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

        private void FormReportes_Load(object sender, EventArgs e)
        {
            int shadowSize = 5;
            int cornerRadius = 20;
            Color shadowColor = Color.Gray;


            ApplyShadowEffect(panelReporte, shadowSize, shadowColor, cornerRadius);
            ApplyRoundedCorners(panelReporte, cornerRadius);

            Clases.Delegaciones delegaciones = new Clases.Delegaciones();
            DataTable dtDelegaciones = delegaciones.CargarDelegaciones();

            CboDelegaciones.DataSource = dtDelegaciones;
            CboDelegaciones.DisplayMember = "NombreDelegacion";
            CboDelegaciones.ValueMember = "IdDelegacion";
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            int idDelegacion = (int)CboDelegaciones.SelectedValue;


            DataAccess dataAccess = new DataAccess();
            var dataSet = dataAccess.LlenarDataSet(fechaInicio, fechaFin, idDelegacion);


            var report = new ReporteEntradas();
            report.DataSource = dataSet;
            report.DataMember = "DSReporteEntradasDelegaciones";

            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters) p.Visible = false;

            report.parametros(fechaInicio, fechaFin);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowRibbonPreview();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now; 
            CboDelegaciones.SelectedIndex = -1; 
        }
    }
}
