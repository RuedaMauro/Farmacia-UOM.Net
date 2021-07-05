using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarmaciaUOM.Entidades;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;


namespace FarmaciaUOM
{
    public partial class BuscarBonoContribucion : Form
    {
        public BuscarBonoContribucion()
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
      
        SqlConnection connexion = new SqlConnection("Data Source=10.10.9.7;Initial Catalog=Hospital;User ID=sa;Password=soy1962$");

        private void BuscarBonoContribucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bonoFarmacia.Buscar_Bono_Contrib' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'bonoFarmacia.Buscar_Bono_Contrib' table. You can move, or remove it, as needed.
         
            // pdf Bono cabezera y bono detalle sp h2_farmacia_bono_cab

            // TODO: This line of code loads data into the 'farmaciaDAL.FAR_PEDIDOS_PUBLICO_CAB1' table. You can move, or remove it, as needed.

            string query = @"SELECT        
                              FAR_PEDIDOS_PUBLICO_CAB.PED_ID AS Bono,
                              FAR_PEDIDOS_PUBLICO_CAB.PED_NOMBRE_CLI AS Paciente,
                              FAR_PEDIDOS_PUBLICO_CAB.NHC AS NHC, 
                              FAR_PEDIDOS_PUBLICO_CAB.PED_FECHA AS Fecha,
                              Usuarios.nombre AS Usuario
                           FROM            
                              FAR_PEDIDOS_PUBLICO_CAB 
                           INNER JOIN
                              Usuarios 
                           ON CONVERT(int, FAR_PEDIDOS_PUBLICO_CAB.PED_USUARIO) = Usuarios.id
                           WHERE        
                              (FAR_PEDIDOS_PUBLICO_CAB.PED_USUARIO <> 'Administrador')
                           ORDER BY 
                               FAR_PEDIDOS_PUBLICO_CAB.PED_ID DESC";

            SqlCommand sqlcommand = new SqlCommand(query, connexion);
            connexion.Open();

            SqlDataAdapter sdr = new SqlDataAdapter(sqlcommand);

            DataTable dt = new DataTable();

            sdr.Fill(dt);

            grv_Bono_Contrib.DataSource = dt;

      
        }


        private void grv_Bono_Contrib_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Refresh();

            

            if (grv_Bono_Contrib.Rows.Count > 0)
            {
                Buscar_Bono_Imp bbi = new Buscar_Bono_Imp();
                bbi.nroDePedidoCAB = Convert.ToInt32(grv_Bono_Contrib.Rows[e.RowIndex].Cells["Bono"].Value.ToString());
                bbi.nroDePedidoDET = Convert.ToInt32(grv_Bono_Contrib.Rows[e.RowIndex].Cells["Bono"].Value.ToString());
                bbi.idUsuario = Convert.ToInt32(UsuarioValidado.UsuarioId);
                bbi.ShowDialog();
            }

            connexion.Close();
                        
        }

        
        public List<ListaInsumos> buscarBono(int nroBono)
        {
            List<ListaInsumos> ins = new List<ListaInsumos>();
            CAD.FarmaciaDALTableAdapters.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter adapter= new CAD.FarmaciaDALTableAdapters.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter();
            CAD.FarmaciaDAL.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABDataTable aTable = adapter.GetData(nroBono);

                foreach (CAD.FarmaciaDAL.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABRow row in aTable.Rows)
                {
                    ListaInsumos ins_list = new ListaInsumos();

                    ins_list.pedidoId = row.Bono;
                    ins_list.cliente = row.Paciente;
                    ins_list.NHCpaciente= row.NHC;
                    ins_list.FechaPed = row.Fecha;
                    ins_list.pedUsuario = row.Usuario;
        
                    ins.Add(ins_list);
                    
                }
                return ins;
         }


        private void TxtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarEnDatagrid(grv_Bono_Contrib, "PED_ID", txt_Busq_Bono);

        }
        
        public void BuscarEnDatagrid(DataGridView grv_Bono_Contrib, string Bono, TextBox txt_Busq_Bono)
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
        
        public List<ListaInsumos> CargarInsumo(int insumoF)
        {
            return buscarBono(insumoF);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_Busq_Bono.Text == "")
            {
                BuscarBonoContribucion_Load(sender,e);
            }
            else
            {
                string cadenaSql = @"SELECT
                                          FAR_PEDIDOS_PUBLICO_CAB.PED_ID AS Bono,
                                          FAR_PEDIDOS_PUBLICO_CAB.PED_NOMBRE_CLI AS Paciente,
                                          FAR_PEDIDOS_PUBLICO_CAB.NHC AS NHC, 
                                          FAR_PEDIDOS_PUBLICO_CAB.PED_FECHA AS Fecha,
                                          Usuarios.nombre AS Usuario
                                        FROM 
                                          FAR_PEDIDOS_PUBLICO_CAB 
                                        INNER JOIN Usuarios 
                                        ON 
                                          CONVERT(int,FAR_PEDIDOS_PUBLICO_CAB.PED_USUARIO) = Usuarios.id
                                        WHERE
                                          FAR_PEDIDOS_PUBLICO_CAB.PED_USUARIO <> 'Administrador'
                                        AND 
                                          '" + Convert.ToInt32(txt_Busq_Bono.Text) + "'= FAR_PEDIDOS_PUBLICO_CAB.PED_ID OR FAR_PEDIDOS_PUBLICO_CAB.PED_FECHA BETWEEN '" + dtDesde.Text + "' AND '" + dtHasta.Text + " '";

                SqlDataAdapter adapter = new SqlDataAdapter(cadenaSql, connexion);
                DataSet ds = new DataSet();

                adapter.Fill(ds);
                grv_Bono_Contrib.DataSource = ds.Tables[0];


                connexion.Close();
            }
                /*
            foreach (DataGridViewRow row in grv_Bono_Contrib.Rows)
            {
                string valor = row.Cells["PED_ID"].Value.ToString();
                string encontrar = "" + txt_Busq_Bono.Text + "";
                bool encontrado = valor.StartsWith(encontrar);

                if (encontrado)
                {
                    row.Selected = true;
                    grv_Bono_Contrib.CurrentCell = grv_Bono_Contrib.Rows[row.Index].Cells[0];
                    return;

                }
               
            }
            */
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //grv_Bono_Contrib.ro = String.Format("fecha LIKE '%/' + '{0}' + '/%'", dtDesde.Text);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            try
            {

                LocalReport rdlc = new LocalReport();
                rdlc.ReportPath = @"..\..\Report.rdlc";
                rdlc.DataSources.Add(new ReportDataSource ("Bono"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public SqlConnection cmd { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
