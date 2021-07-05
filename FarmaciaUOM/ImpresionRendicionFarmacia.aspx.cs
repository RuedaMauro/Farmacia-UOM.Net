using System;
using System.Collections.Generic;
using System.Linq;

using FarmaciaUOM;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using FarmaciaUOM.Entidades;


public partial class Impresiones_ImpresionRendicionFarmacia
{


    protected void Page_Load(object sender, EventArgs e)
    {
        

            ReportParameter[] parameters = new ReportParameter[5];
  
            parameters[0] = new ReportParameter("imagen", "http://10.0.0.30/img/logoprint.jpg");
            parameters[1] = new ReportParameter("Usuario", UsuarioRendicionBono.UsuarioRendicion);
            parameters[2] = new ReportParameter("Desde", UsuarioRendicionBono.RendicionFechaDesde.ToString());
            parameters[3] = new ReportParameter("Hasta", UsuarioRendicionBono.RendicionFechaHasta.ToString());
            parameters[4] = new ReportParameter("Usuario", UsuarioRendicionBono.UsuarioRendicion);

        }

    }

  
