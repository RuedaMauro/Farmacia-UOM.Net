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
    public partial class PrincipalFarmacia : Form
    {
        public PrincipalFarmacia()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Seleccionar_Operacion(object sender, EventArgs e)
        {
            if(cbo_Operacion.SelectedItem.ToString()=="Bono contribución")
            {
                this.Hide();
                BonoContribucion pf = new BonoContribucion();
                pf.Show();
            }
            else if(cbo_Operacion.SelectedItem.ToString()=="Buscar Bono contribución")
            {
                this.Hide();
                BuscarBonoContribucion bbc = new BuscarBonoContribucion();
                bbc.Show();
            }
            else if (cbo_Operacion.SelectedItem.ToString() == "Rendición Bono contribución")
            {
                this.Hide();
                RendicionBonoContribucion rbc = new RendicionBonoContribucion();
                rbc.Show();
            }
        }


    }
}
