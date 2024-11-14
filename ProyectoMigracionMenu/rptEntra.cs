﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ProyectoMigracionMenu
{
    public partial class rptEntra : DevExpress.XtraReports.UI.XtraReport
    {
        public rptEntra()
        {
            InitializeComponent();
        }
        public void parametros(DateTime fechaInicio, DateTime fechaFin, string nombreDelegacion)
        {
            try
            {
                Parameters["FechaInicio"].Value = fechaInicio.ToString("yyyy-MM-dd");
                Parameters["FechaFin"].Value = fechaFin.ToString("yyyy-MM-dd");
                Parameters["Delegacion"].Value = nombreDelegacion;

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
