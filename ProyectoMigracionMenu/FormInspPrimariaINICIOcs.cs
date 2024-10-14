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
    public partial class FormInspPrimariaINICIOcs : Form
    {
        public FormInspPrimariaINICIOcs()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void ApplyShadowEffectToButton(Button button, int shadowSize, Color shadowColor, int cornerRadius)
        {
           
            Panel shadowPanel = new Panel();
            shadowPanel.Size = button.Size;
            shadowPanel.Location = new Point(button.Location.X + shadowSize, button.Location.Y + shadowSize);
            shadowPanel.BackColor = shadowColor;

            
            ApplyRoundedCorners(shadowPanel, cornerRadius);

        
            button.Parent.Controls.Add(shadowPanel);
            shadowPanel.SendToBack();

        
            ApplyRoundedCorners(button, cornerRadius);
        }

        private void ApplyRoundedCorners(Control control, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            path.AddArc(new Rectangle(control.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
            path.AddArc(new Rectangle(control.Width - cornerRadius, control.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }

        private void FormInspPrimariaINICIOcs_Load(object sender, EventArgs e)
        {

            int shadowSize = 5;
            int cornerRadius = 20;
            Color shadowColor = Color.Gray;

           
            ApplyShadowEffectToButton(BtnEntradas, shadowSize, shadowColor, cornerRadius);
        }
    }
}
