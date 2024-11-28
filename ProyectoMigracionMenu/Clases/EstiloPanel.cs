using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMigracionMenu.Clases
{
    /// <summary>
    /// Clase que proporciona métodos para aplicar estilos visuales a paneles en Windows Forms.
    /// </summary>
    public static class EstiloPanel
    {
        /// <summary>
        /// Aplica un efecto de sombra a un panel especificado.
        /// Crea un panel adicional detrás del original con un desplazamiento y color de sombra.
        /// </summary>
        /// <param name="panel">El panel al que se le aplicará el efecto de sombra.</param>
        /// <param name="shadowSize">El tamaño del desplazamiento de la sombra.</param>
        /// <param name="shadowColor">El color de la sombra.</param>
        /// <param name="cornerRadius">El radio de las esquinas redondeadas del panel de sombra.</param>
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

        /// <summary>
        /// Aplica esquinas redondeadas a un panel utilizando un radio especificado.
        /// Modifica la región del panel para lograr el efecto.
        /// </summary>
        /// <param name="panel">El panel al que se le aplicarán las esquinas redondeadas.</param>
        /// <param name="cornerRadius">El radio de las esquinas redondeadas.</param>
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

