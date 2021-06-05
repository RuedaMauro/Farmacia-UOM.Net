using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarmaciaUOM.Entidades;

namespace FarmaciaUOM
{
    public partial class BuscarBonoContribucion : Form
    {
        public BuscarBonoContribucion()
        {
            InitializeComponent();
        }

        public List<Insumos> Insumos_tipo(int Id, string Insumo_tipo)
        {
            List<Insumos> il = new List<Insumos>();
            CAD.FarmaciaDALTableAdapters.Insumo_ListTableAdapter adapter = new CAD.FarmaciaDALTableAdapters.Insumo_ListTableAdapter();
            CAD.FarmaciaDAL.Insumo_ListDataTable aTable = adapter.GetData(Id,Insumo_tipo);


            foreach(CAD.FarmaciaDAL.Insumo_ListRow row in aTable.Rows)
            {
                Insumos ins_List = new Insumos();
                ins_List.tipo_De_Insumo = row.REM_NOMBRE;

                il.Add(ins_List);
            }

            return il;

        }

        public List<Insumos> CargarInsumos(int Id,string nombre)
        {
            List<Insumos> i = Insumos_tipo(Id,nombre);

            if (i != null)
            {
                return i;
            }
            else
            {
                return null;
            }


        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  grv_Bono_Contrib.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre = '{0}'", txt_Busq_Bono.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalFarmacia pf = new PrincipalFarmacia();
            pf.Show();
        }

        private void BuscarBonoContribucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmaciaDAL.FAR_PEDIDOS_PUBLICO_CAB' table. You can move, or remove it, as needed.
            this.fAR_PEDIDOS_PUBLICO_CABTableAdapter.Fill(this.farmaciaDAL.FAR_PEDIDOS_PUBLICO_CAB);



        }

        private void grv_Bono_Contrib_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarEnDatagrid(grv_Bono_Contrib, 0, txt_Busq_Bono);
        }


        public void BuscarEnDatagrid(DataGridView grv_Bono_Contrib, int Bono, TextBox txt_Busq_Bono)
        {
            foreach (DataGridViewRow row in grv_Bono_Contrib.Rows)
            {
                int fila = row.Index;
                string valor = Convert.ToString(row.Cells[Bono].Value);

                if (valor.Contains(txt_Busq_Bono.Text))
                    grv_Bono_Contrib.Rows[fila].DefaultCellStyle.BackColor = Color.DarkTurquoise;
                else
                    grv_Bono_Contrib.Rows[fila].DefaultCellStyle.BackColor = Color.White;

                //Si esta vacio el campo de busqueda quitar el sombreado
                if (txt_Busq_Bono.Text == string.Empty)
                    grv_Bono_Contrib.Rows[fila].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarEnDatagrid(grv_Bono_Contrib, 0, txt_Busq_Bono);
        }
    }
}
