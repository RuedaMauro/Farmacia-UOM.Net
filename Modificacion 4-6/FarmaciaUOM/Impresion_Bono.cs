using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FarmaciaUOM.Entidades;
using Microsoft.Reporting.WinForms;

namespace FarmaciaUOM
{
    public partial class Impresion_Bono : Form
    {
        public Impresion_Bono()
        {
            InitializeComponent();
        }

        public Impresion_Bono(string f_Fecha, int f_BonoId, string f_comprobante_Para_Paciente)
        {
            Fecha = f_Fecha;
            BonoId = f_BonoId;
            comprobante_Para_Paciente = f_comprobante_Para_Paciente;
            InitializeComponent();
            Copias = 1;
        }

        private string Fecha;
        private int BonoId;
        private string comprobante_Para_Paciente;

        private int currentPageIndex;
        private IList<Stream> pages = new List<Stream>();
        public short Copias;

        private Stream CreateStream(string name, string fileNameExtension,
                Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            pages.Add(stream);

            return stream;
        }


        private void Export(LocalReport report)
        {
            string deviceInfo =
              "<DeviceInfo>" +
              "  <OutputFormat>EMF</OutputFormat>" +
              "  <PageWidth>21.56cm</PageWidth>" +
                //"  <PageHeight>15cm</PageHeight>" +
              "  <MarginTop>0.0in</MarginTop>" +
              "  <MarginLeft>0.0in</MarginLeft>" +
              "  <MarginRight>0.0in</MarginRight>" +
              "  <MarginBottom>0.0in</MarginBottom>" +
              "</DeviceInfo>";
            Warning[] warnings;


            report.Render("Image", deviceInfo, CreateStream, out warnings);

            foreach (Stream stream in pages)
                stream.Position = 0;
        }

        private void Impresion_Bono_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            string MostrarFoto = "0";


            //Info del policlinico

            CAD.HospitalDALTableAdapters.H3_CentroTableAdapter adapter3 = new CAD.HospitalDALTableAdapters.H3_CentroTableAdapter();
            CAD.HospitalDAL.H3_CentroDataTable aTable3 = adapter3.GetData();
            centroUOM c = new centroUOM();

            foreach (CAD.HospitalDAL.H3_CentroRow row2 in aTable3.Rows)
            {
                if (!row2.IsTelefonoNull()) c.Telefono = row2.Telefono;
                c.Nombre = row2.RazonSocial;
                c.Direccion = row2.Calle;
            }


            reportViewer1.LocalReport.Refresh();

            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("Usuario", Usuarios.usuario);
            parameters[1] = new ReportParameter("Imagen", "http://10.10.8.71/img/logoprint.jpg");
            parameters[2] = new ReportParameter("Comprobante_Para_El_Paciente", comprobante_Para_Paciente);
            parameters[3] = new ReportParameter("Mostrar_Fondo", MostrarFoto);

            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.SetParameters(parameters);






           
            }


        }


    
}
