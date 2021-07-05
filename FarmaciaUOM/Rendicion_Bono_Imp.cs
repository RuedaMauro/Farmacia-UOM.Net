using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FarmaciaUOM
{
    public partial class Rendicion_Bono_Imp : Form
    {
        public Rendicion_Bono_Imp()
        {
            InitializeComponent();
        }

        // Paramentros para el sp H2_PEDIDOS_PUBLICO_RENDICION

        public DateTime Fecha { get; set; }
        public string UsuarioRencion { get; set; }
        public DateTime FechaHasta { get; set; }
        public string UsuarioSeleccionado { get; set; }

        // Parametros para identificar el usuario ingresado en el login
        public int UsuarioLogin { get; set; }

        // Parametros para identificar el usuario ingresado en la rendicion de bono contribucion

        public int UsuarioRendBonoContr { get; set; }



        private void Rendicion_Bono_Imp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Centro' table. You can move, or remove it, as needed.
            this.centroTableAdapter.Fill(this.dataSet2.Centro);
            // TODO: This line of code loads data into the 'DataSet1.H2_PEDIDOS_PUBLICO_RENDICION' table. You can move, or remove it, as needed.
            this.H2_PEDIDOS_PUBLICO_RENDICIONTableAdapter.Fill(this.DataSet1.H2_PEDIDOS_PUBLICO_RENDICION,Fecha,UsuarioRencion,FechaHasta); // cambiar el sp en el report para poder utilizar la impresion en la rendicion del 10.0.0.30
            // Usuario ingresado con el login
            this.h2_USUARIOS_BY_ID_LISTTableAdapter.Fill(this.dataSet3.H2_USUARIOS_BY_ID_LIST,UsuarioLogin);
            // Usuario ingresado para la rendicion del bono contribucion
            this.h2_USUARIOS_BY_ID_LISTTableAdapter1.Fill(this.dataSet4.H2_USUARIOS_BY_ID_LIST,UsuarioRendBonoContr);


            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
