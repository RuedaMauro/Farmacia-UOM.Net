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

        BonoContribucion formulario;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (e.CloseReason == CloseReason.ApplicationExitCall) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "¿Está seguro que desea cancelar la operación?", "¿Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Application.Exit();
                    break;
                        
            }
        }

        SqlConnection connexion = new SqlConnection("Data Source=10.10.9.7;Initial Catalog=Hospital;User ID=sa;Password=soy1962$");
      
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BonoContribucion re = new BonoContribucion();
            re.Show();
        }

        SqlConnection SqlCon = new SqlConnection("Data Source=10.10.9.7;Initial Catalog=Hospital;User ID=sa;Password=soy1962$");

        private void DatosBono_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmaciaDAL.FAR_INSUMOS_CENTRAL' table. You can move, or remove it, as needed.
            this.fAR_INSUMOS_CENTRALTableAdapter.Fill(this.farmaciaDAL.FAR_INSUMOS_CENTRAL);
            // TODO: This line of code loads data into the 'farmaciaDAL1.Insumo_cbo' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'farmaciaDAL1.Insumo_List_All' table. You can move, or remove it, as needed.

            string sqlQuery = @"SELECT 
                                 REM_NOMBRE + ' ' + REM_GRAMAJE AS Insumo,
                                 PED_PRECIO_INS AS Total,
                                 PED_CANTIDAD_INS AS Cantidad
                               FROM 
                                 FAR_PEDIDOS_PUBLICO_DET 
                               INNER JOIN FAR_INSUMOS_CENTRAL
                                 ON FAR_PEDIDOS_PUBLICO_DET.PED_ID = FAR_INSUMOS_CENTRAL.REM_ID 
                               ORDER BY 
                                 REM_NOMBRE ASC";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, SqlCon);

            SqlCon.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sdr.Fill(dt);

            cbo_Insumos.DisplayMember = "Insumo";
            cbo_Insumos.DataSource = dt;

            SqlCon.Close();



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

        private void button2_Click(object sender, EventArgs e)
        {
            int precio;
            int cantidad;
            int totalPedido;
            int totalConDescuento;
            int descuento = Convert.ToInt32(txt_Desc_Bono.Text);
            int precioFinal;
            int contador = 0;
            const int columna = 3;

            if (cbo_precio.Text != "" && cbo_cant.Text != "" && cbo_cant2.Text != "" )
            {
                if (descuento == 0)
                {
                    int.TryParse(cbo_precio.Text, out precio);
                    int.TryParse(cbo_cant.Text, out cantidad);

                    totalPedido = precio * cantidad;

                    int totalSinDescuento = 0;

                    grv_Insumos_Detalles.Rows.Add(cbo_Insumos.Text, cbo_cant.Text, cbo_precio.Text, totalPedido,totalSinDescuento.ToString());

                    foreach (DataGridViewRow row in grv_Insumos_Detalles.Rows)
                    {
                        contador += Convert.ToInt32(row.Cells[columna].Value);
                    }

                    Convert.ToString(contador);
                    lbl_Precio_Total.Text = " Precio TOTAL ($): " + contador;

                    VariablesGlobales.descuento = "0";

                }
                else if (descuento >= 1 && descuento <= 100)
                {
                    int.TryParse(cbo_precio.Text, out precio);
                    int.TryParse(cbo_cant.Text, out cantidad);

                    totalPedido = precio * cantidad;
                    totalConDescuento =  (descuento * totalPedido) / 100;
                    precioFinal = totalPedido - totalConDescuento;
                    Convert.ToString(precioFinal);

                    grv_Insumos_Detalles.Rows.Add(cbo_Insumos.Text, cbo_cant.Text, cbo_precio.Text, precioFinal,txt_Desc_Bono.Text);

                    foreach (DataGridViewRow row in grv_Insumos_Detalles.Rows)
                    {
                        contador += Convert.ToInt32(row.Cells[columna].Value);
                    }

                    Convert.ToString(contador);
                    lbl_Precio_Total.Text = " Precio TOTAL ($): " + contador;
                
                    //-------------------------------------------------------------------------

                    // capturo el descuento para asi despues realizar el insert en datosBono
                    VariablesGlobales.descuento = Convert.ToString(descuento);

                    //--------------------------------------------------------------------------
                }
  
                else
                {
                    MessageBox.Show("El descuento ingresado no es válido, ingrese los datos nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (cbo_precio.Text!="" && cbo_precio.Text == "" && cbo_cant2.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if(cbo_precio.Text != "" && cbo_precio.Text !="" && cbo_cant2.Text == "" )
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbo_precio.Text = "";
            cbo_cant.Text = "";
            lbl_Usuario.Text = "";
            lbl_Precio_Total.Text = "Precio TOTAL ($):";
            grv_Insumos_Detalles.Rows.Clear();
            cbo_cant2.Text = "";

        }

        // INSERT DE TABLA FAR_PEDIDOS_PUBLIC_CAB

        SqlConnection conexion = new SqlConnection("Data Source=10.10.9.7;Initial Catalog=Hospital;User ID=sa;Password=soy1962$");
        DateTime fecha = DateTime.Today;

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO FAR_PEDIDOS_PUBLICO_CAB 
                               (PED_NOMBRE_CLI,
                                PED_USUARIO,
                                NHC,
                                PED_FECHA,
                                COD_AUDITOR) 
                             VALUES
                               (@d1,
                                @d2,
                                @d3,
                                GETDATE(),
                                @d4) 
                             SELECT SCOPE_IDENTITY()";

            string queryCapturarPed_id = @"SELECT
	                                        TOP 1 Ped_id
                                           FROM
	                                         FAR_PEDIDOS_PUBLICO_CAB
                                           ORDER BY
	                                         ped_id DESC ";

            string query2 = @"INSERT INTO FAR_PEDIDOS_PUBLICO_DET 
                               (PED_ID,
                                PED_INSUMO_ID,
                                PED_CANTIDAD_INS,
                                PED_PRECIO_INS,
                                PED_INS_DESC,
                                CANT_UNIDADES,
                                NRO_LOTE) 
                              VALUES
                               (@d5,
                                @d6,
                                @d7,
                                @d8,
                                @d9,
                                @d10,
                                @d11)";

            SqlCommand sqlCommand = new SqlCommand(query,conexion);
            SqlCommand SqlCommand3 = new SqlCommand(queryCapturarPed_id, conexion);
            
            //SqlCommand sqlCommand3 = new SqlCommand(query3, conexion);

            conexion.Open();

          
            // Parametros para insertar registros en far_pedidos_cab
 
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@d1", VariablesGlobales.dbPaciente.ToString());
            sqlCommand.Parameters.AddWithValue("@d2", UsuarioValidado.UsuarioId.ToString());
            sqlCommand.Parameters.AddWithValue("@d3", VariablesGlobales.dbNHC.ToString());
            sqlCommand.Parameters.AddWithValue("@d4", 0);

            int Paciente = Convert.ToInt32(sqlCommand.ExecuteScalar());
            int pedId = Convert.ToInt32(SqlCommand3.ExecuteScalar());

            SqlCommand sqlCommand2 = new SqlCommand(query2, conexion);

            sqlCommand.Parameters.AddWithValue("@d5", pedId);
            sqlCommand.Parameters.AddWithValue("@d6", 3016);
            sqlCommand.Parameters.AddWithValue("@d7", cbo_cant.Text);
            decimal precio = Convert.ToDecimal(cbo_precio.Text);
            sqlCommand.Parameters.AddWithValue("@d8", precio);
            sqlCommand.Parameters.AddWithValue("@d9", VariablesGlobales.descuento);
            sqlCommand.Parameters.AddWithValue("@d10 ", cbo_cant.Text);
            sqlCommand.Parameters.AddWithValue("@d11 ", "-1");

            sqlCommand.ExecuteNonQuery();
            
            
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            MessageBox.Show("Bono agregado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Close();
            
        }
      

        private void nuevoBonoContribucion(string cliente, string usuario, string nhc, int auditor)
        {
            Bono pedCarg = new Bono();
         
            cliente = lbl_Apellido_Nombre.Text;
            nhc = lbl_NHC.Text;
            usuario = pedCarg.Usuario;


            CAD.BonoFarmaciaTableAdapters.QueriesTableAdapter query = new CAD.BonoFarmaciaTableAdapters.QueriesTableAdapter();
            query.H2_Insert_Pedidos_Publico_Cab(cliente, usuario,nhc,auditor);


        }

        private void detallesBonoContrib(long numDePedido, int insumoId, decimal insumoCant, decimal insumoPrecio, string descuento, int cantUnidades, long Usuario, string nroDeLote)
        {
            
            Bono_Det pedCargDetalles = new Bono_Det();

            nroDeLote = "-1";
            cantUnidades = 0;
        }


        private void txt_Insumos_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Telefono_Click(object sender, EventArgs e)
        {

        }

        private void cbo_Insumos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Apellido(object sender, EventArgs e)
        {

        }


        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

    

    }
}
