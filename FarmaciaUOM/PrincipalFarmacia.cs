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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (e.CloseReason == CloseReason.ApplicationExitCall) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "¿Está seguro que desea cerrar la aplicación?", "¿Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    {
                        Application.Exit();
                        break;
                    }
            }
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

        private void PrincipalFarmacia_Load(object sender, EventArgs e)
        {
            
        }


    }
}
