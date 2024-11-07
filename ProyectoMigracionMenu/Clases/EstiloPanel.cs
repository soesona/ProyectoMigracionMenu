using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    public static class EstiloPanel
    {
        public static void AplicarSombra(Panel panel, int shadowSize, Color shadowColor, int cornerRadius)
        {
            Panel shadowPanel = new Panel
            {
                Size = panel.Size,
                Location = new Point(panel.Location.X + shadowSize, panel.Location.Y + shadowSize),
                BackColor = shadowColor
            };

            AplicarEsquinasRedondeadas(shadowPanel, cornerRadius);

            panel.Parent.Controls.Add(shadowPanel);
            shadowPanel.SendToBack();
        }

        public static void AplicarEsquinasRedondeadas(Panel panel, int cornerRadius)
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
    }
}

