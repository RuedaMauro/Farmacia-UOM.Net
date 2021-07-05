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
    public partial class Buscar_Bono_Imp : Form
    {
        public Buscar_Bono_Imp()
        {
            InitializeComponent();
        }

        public int nroDePedidoCAB { get; set; }
        public int nroDePedidoDET { get; set; }
        public int idUsuario { get; set; }

        private void Buscar_Bono_Imp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet5.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CAB' table. You can move, or remove it, as needed.
         
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter.Fill(this.DataSet5.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CAB,nroDePedidoCAB);
            // TODO: This line of code loads data into the 'DataSet5.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLE' table. You can move, or remove it, as needed.
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLETableAdapter.Fill(this.DataSet5.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLE,nroDePedidoDET);
            // TODO: This line of code loads data into the 'DataSet2.Centro' table. You can move, or remove it, as needed.
            this.CentroTableAdapter.Fill(this.DataSet2.Centro);

            this.h2_USUARIOS_BY_ID_LISTTableAdapter.Fill(this.dataSet3.H2_USUARIOS_BY_ID_LIST, idUsuario);
      

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
