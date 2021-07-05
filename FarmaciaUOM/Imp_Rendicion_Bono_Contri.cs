using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using FarmaciaUOM.Entidades;

namespace FarmaciaUOM
{
    public partial class Imp_Rendicion_Bono_Contri : Form
    {
        List<RendicionTotal> Rt = new List<RendicionTotal>();

        CAD.BonoFarmacia.Rendicion_BonoDataTable rendicionBonoTable = new CAD.BonoFarmacia.Rendicion_BonoDataTable();
        CAD.BonoFarmacia.Rendicion_BonoRow rbr;

        public DataGridView dgv_RendicionBono;
        public ReportDataSource fuente = new ReportDataSource();

        public Imp_Rendicion_Bono_Contri(DataGridView dgvRendicionBono)
        {
            dgv_RendicionBono = dgvRendicionBono;
            InitializeComponent();
        }


        private void Imp_Rendicion_Bono_Contri_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgv_RendicionBono.Rows)
            {
                rbr = rendicionBonoTable.NewRendicion_BonoRow();if (row.Cells[0].Value != "") { rbr.Paciente = row.Cells[0].Value.ToString(); } // Paciente
                if (row.Cells[1].Value != "") { rbr.NHC = row.Cells[1].Value.ToString(); } // NHC
                rbr.Insumo = row.Cells[2].Value.ToString(); // Insumo
                rbr.Cantidad = row.Cells[3].Value.ToString(); // Cantidad
                if (row.Cells[4].Value != "") { rbr.Total = Convert.ToDecimal(row.Cells[4].Value).ToString(); }//int Precio
                rendicionBonoTable.Rows.Add(rbr);
            }

            reportViewer1.RefreshReport();

            ReportParameter[] parametros = new ReportParameter[5];

            parametros[0] = new ReportParameter("imagen", "http://10.0.0.30/img/logoprint.jpg");
            parametros[1] = new ReportParameter("Usuario", UsuarioRendicionBono.UsuarioRendicion);
            parametros[2] = new ReportParameter("Desde", UsuarioRendicionBono.RendicionFechaDesde.ToString());
            parametros[3] = new ReportParameter("Hasta", UsuarioRendicionBono.RendicionFechaHasta.ToString());
            parametros[4] = new ReportParameter("Usuario", UsuarioRendicionBono.UsuarioRendicion);

            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.SetParameters(parametros);


            this.reportViewer1.RefreshReport();
        }

        
         /*   long u = Convert.ToInt64(Request.QueryString["Usuario"].ToString());
            UsuariosBLL ubll = new UsuariosBLL();
            parameters[0] = new ReportParameter("Imagen", "http://" + Request.Url.Host + ":" + Request.Url.Port + HttpContext.Current.Request.ApplicationPath + "/img/logoprint.jpg");
            parameters[1] = new ReportParameter("User", ((usuarios)Session["Usuario"]).nombre + " - Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            parameters[2] = new ReportParameter("Desde", Request.QueryString["Desde"].ToString());
            parameters[3] = new ReportParameter("Hasta", Request.QueryString["Hasta"].ToString());
            if (u != 0)
            parameters[4] = new ReportParameter("Usuario", ubll.UsuariobyId_Item(u).nombre);
            else parameters[4] = new ReportParameter("Usuario", "TODOS");
            ReportViewer1.LocalReport.EnableExternalImages = true;
            ReportViewer1.LocalReport.SetParameters(parameters);

        */
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
