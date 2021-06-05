using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FarmaciaUOM.Entidades;

namespace FarmaciaUOM
{
    public partial class DatosBono : Form
    {
        public DatosBono()
        {
            InitializeComponent();
        }

        private void NuevoPaciente()
        {
            Pacientes paciente = new Pacientes();

            lbl_Apellido_Nombre.Text = "Paciente: ";
            lbl_Dni.Text = "DNI: ";
            lbl_Seccional.Text = "SECCIONAL: ";
            lbl_NHC.Text = "";
            lbl_edad.Text = "";
            lbl_id.Text = "";


            lbl_Apellido_Nombre.Text = "Paciente: " + paciente.Paciente;
            lbl_Dni.Text = "DNI:" + paciente.Tipo_Documento;
            lbl_Telefono.Text = "Teléfono: " + paciente.Telefono;
            lbl_Seccional.Text = "Seccional: " + paciente.Seccional;


        }
            

        public List<Insumos> Insumos_tipo(int Id, string Insumo_tipo)
        {
            List<Insumos> il = new List<Insumos>();
            CAD.FarmaciaDALTableAdapters.Insumo_ListTableAdapter adapter = new CAD.FarmaciaDALTableAdapters.Insumo_ListTableAdapter();
            CAD.FarmaciaDAL.Insumo_ListDataTable aTable = adapter.GetData(Id, Insumo_tipo);

            foreach (CAD.FarmaciaDAL.Insumo_ListRow row in aTable.Rows)
            {
                Insumos ins_List = new Insumos();
                ins_List.tipo_De_Insumo = row.REM_NOMBRE;

                il.Add(ins_List);
            }

            return il;

        }

        public List<Insumos> CargarInsumos(int Id, string nombre)
        {
            List<Insumos> i = Insumos_tipo(Id, nombre);

            if (i != null)
            {
                return i;
            }
            else
            {
                return null;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BonoContribucion bc = new BonoContribucion();
            bc.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatosBono_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmaciaDAL1.Insumo_cbo' table. You can move, or remove it, as needed.
            this.insumo_cboTableAdapter.Fill(this.farmaciaDAL1.Insumo_cbo);
            // TODO: This line of code loads data into the 'farmaciaDAL1.Insumo_List_All' table. You can move, or remove it, as needed.
            this.insumo_List_AllTableAdapter.Fill(this.farmaciaDAL1.Insumo_List_All);

        }

        private void txt_Insumos_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < grv_Insumos_Detalles.Columns.Count - 1; i++)
            {
                grv_Insumos_Detalles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            grv_Insumos_Detalles.Columns[grv_Insumos_Detalles.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < grv_Insumos_Detalles.Columns.Count; i++)
            {
                int colw = grv_Insumos_Detalles.Columns[i].Width;
                grv_Insumos_Detalles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                grv_Insumos_Detalles.Columns[i].Width = colw;
            }


          

        }

      /*  public List<Insumos>Insumos_Lista(string nombre)
        {

           List<Insumos> insumos_lista = new List<Insumos>();
           CAD.FarmaciaDALTableAdapters.Insumo_List_AllTableAdapter adapter = new CAD.FarmaciaDALTableAdapters.Insumo_List_AllTableAdapter();
           CAD.FarmaciaDAL.Insumo_List_AllDataTable aTable = adapter.GetData(nombre);

           foreach (CAD.FarmaciaDAL.Insumo_List_AllRow row in aTable.Rows)
           { 
              Insumos ins = new Insumos();

              ins.tipo_De_Insumo = row.REM_NOMBRE;
              ins.cant = row.REM_UNIDADES;
              ins.precio = row.REM_PRECIO;
              ins.subtotal = row.REM_PRECIO;
              
           }

           return insumos_lista;
        }
        */



        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Apellido_Nombre_Click(object sender, EventArgs e)
        {

            Pacientes pc = new Pacientes();


            lbl_Apellido_Nombre.Text = "cambio" + pc.Paciente; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbo_precio.Text != "" && cbo_cant.Text != "" && cbo_cant2.Text != "" )
            {
                lbl_Precio_Total.Text = " Precio TOTAL ($):" + cbo_precio.Text;
            }
            else
            {

                MessageBox.Show("Error", "primero complete todos los campos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                
            
            }

            /*
            try
            {
                // do stuff
            }
            catch (Exception ex)
            {
                this.ShowAlert(ex.Message);
            }

            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbo_precio.Text = "";
            lbl_Precio_Total.Text = "Precio TOTAL ($):";
            cbo_cant.Text = "";
            cbo_cant2.Text = "";

        }


        //    private void button2_Click(object sender, EventArgs e)
        //{
        /*this.Hide();
        DatosBono er = new DatosBono();
        er.Show();
            
        BonoContribucion Parent = new BonoContribucion(this.Owner);

        if()
        */
        //        }

    }
}
