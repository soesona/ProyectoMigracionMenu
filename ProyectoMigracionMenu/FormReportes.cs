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
           CboDelegaciones.ValueMember = "NombreDelegacion";
        }

    }
}
