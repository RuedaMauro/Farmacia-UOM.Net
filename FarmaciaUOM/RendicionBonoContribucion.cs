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
using FarmaciaUOM;

namespace FarmaciaUOM
{
    public partial class RendicionBonoContribucion : Form
    {
        public RendicionBonoContribucion()
        {
            InitializeComponent();
        }

        SqlConnection cone = new SqlConnection("Data Source=10.10.9.7;Initial Catalog=Hospital;User ID=sa;Password=soy1962$");

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalFarmacia pf = new PrincipalFarmacia();
            pf.Show();
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

        private void RendicionBonoContribucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bonoFarmacia.RendicionBono' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'farmaciaDAL.FAR_PEDIDOS_PUBLICO_CAB' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'farmaciaDAL.Usuarios' table. You can move, or remove it, as needed.

            string sqlQuery = @"SELECT
                                  nombre 
                                FROM 
                                  Usuarios 
                                WHERE 
                                  Usuarios.nombre <> 'Administrador' 
                                AND 
                                  Usuarios.activo <> 0 
                                ORDER BY 
                                  nombre ASC";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, cone);

            cone.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
        
            sdr.Fill(dt);

            cboUsuarios.DisplayMember = "nombre";
            
            cboUsuarios.DataSource = dt;
            cone.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();

            // Get usuario id
            //-------------------------------------------------------------------------
            string consultaSql = @"SELECT 
                                     id
                                   FROM 
                                     Usuarios 
                                   WHERE 
                                     '" + cboUsuarios.Text + "'= Usuarios.nombre";

            SqlCommand sqlCommand2 = new SqlCommand(consultaSql, cone);
            string aux;

            cone.Open();

            aux = Convert.ToString(sqlCommand2.ExecuteScalar());
            UsuarioValidado.UsuarioIngresado = aux;

            //------------------------------------------------------------------------

            string cadenaSql = @"SELECT	
                                   FAR_PEDIDOS_PUBLICO_CAB.PED_NOMBRE_CLI AS Paciente,
                                   FAR_PEDIDOS_PUBLICO_CAB.NHC AS NHC,
                                   FAR_INSUMOS_CENTRAL.REM_NOMBRE AS Insumo,
                                   FAR_PEDIDOS_PUBLICO_DET.PED_CANTIDAD_INS AS Cantidad,
                                   FAR_PEDIDOS_PUBLICO_DET.PED_PRECIO_INS AS Total,
                                   FAR_PEDIDOS_PUBLICO_DET.PED_INS_DESC AS Descuento,
                                   FAR_PEDIDOS_PUBLICO_CAB.PED_FECHA AS Fecha
                                 FROM 
                                   FAR_PEDIDOS_PUBLICO_CAB 
                                 INNER JOIN 
                                   Usuarios 
                                 ON 
                                   CONVERT ( INT, FAR_PEDIDOS_PUBLICO_CAB.PED_USUARIO) = Usuarios.id 
                                 INNER JOIN 
                                   FAR_PEDIDOS_PUBLICO_DET 
                                 ON 
                                   FAR_PEDIDOS_PUBLICO_CAB.PED_ID = FAR_PEDIDOS_PUBLICO_DET.PED_ID 
                                 INNER JOIN
                                   FAR_INSUMOS_CENTRAL
                                 ON 
                                   FAR_INSUMOS_CENTRAL.REM_ID = FAR_PEDIDOS_PUBLICO_DET.PED_INSUMO_ID 
                                 WHERE 
                                   FAR_PEDIDOS_PUBLICO_CAB.PED_USUARIO='"+UsuarioValidado.UsuarioIngresado+
                               "'AND FAR_PEDIDOS_PUBLICO_CAB.PED_FECHA  >= '" + dateTimeDesde.Text + " 00:00:00" + 
                               "'AND FAR_PEDIDOS_PUBLICO_CAB.PED_FECHA  <='" + dateTimeHasta.Text + " 23:59:59'";


            SqlDataAdapter adapter = new SqlDataAdapter(cadenaSql, cone);
            DataSet ds = new DataSet();

           // "+UsuarioValidado.UsuarioIngresado+ "
            adapter.Fill(ds);
            dgvRendicionBonoCont.DataSource = ds.Tables[0];

            UsuarioRendicionBono.RendicionFechaDesde = Convert.ToDateTime(dateTimeDesde.Text);
            UsuarioRendicionBono.RendicionFechaHasta = Convert.ToDateTime(dateTimeHasta.Text);
        
            cone.Close();
        }        
           
        private void button1_Click(object sender, EventArgs e)
        {
           DateTime auxFecha = DateTime.Now;
           cboUsuarios.SelectedIndex = 1;

            Rendicion_Bono_Imp fr = new Rendicion_Bono_Imp();
           fr.Fecha = dateTimeDesde.Value;
           fr.UsuarioRencion = UsuarioValidado.UsuarioIngresado;
           fr.FechaHasta = dateTimeHasta.Value;

           fr.UsuarioLogin = ((int)VariablesGlobales.Usuarioid); // Usuario ingresado con el login
           fr.UsuarioRendBonoContr = Convert.ToInt32(UsuarioValidado.UsuarioIngresado); // usuario seleccionado en la rendicion del bono
           fr.ShowDialog();

           cone.Close();
        }

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection("Data Source=10.10.9.7;Initial Catalog=Hospital;User ID=sa;Password=soy1962$");

            string sqlQuery = @"SELECT
                                  FAR_PEDIDOS_PUBLICO_CAB.PED_NOMBRE_CLI AS Paciente,
                                  FAR_PEDIDOS_PUBLICO_CAB.NHC AS NHC,
                                  FAR_INSUMOS_CENTRAL.REM_NOMBRE AS Insumo,
                                  FAR_PEDIDOS_PUBLICO_DET.PED_CANTIDAD_INS AS Cantidad,
                                  FAR_PEDIDOS_PUBLICO_DET.PED_PRECIO_INS AS Total,
                                  FAR_PEDIDOS_PUBLICO_DET.PED_INS_DESC AS Descuento,
                                  FAR_PEDIDOS_PUBLICO_CAB.PED_FECHA AS Fecha
                                FROM
                                  FAR_PEDIDOS_PUBLICO_CAB
                                INNER JOIN
                                  Usuarios 
                                ON 
                                  CONVERT ( INT, FAR_PEDIDOS_PUBLICO_CAB.PED_USUARIO) = Usuarios.id
                                INNER JOIN 
                                  FAR_PEDIDOS_PUBLICO_DET
                                ON 
                                  FAR_PEDIDOS_PUBLICO_CAB.PED_ID = FAR_PEDIDOS_PUBLICO_DET.PED_ID
                                INNER JOIN 
                                  FAR_INSUMOS_CENTRAL 
                                ON 
                                  FAR_INSUMOS_CENTRAL.REM_ID = FAR_PEDIDOS_PUBLICO_DET.PED_INSUMO_ID
                                WHERE 
                                  FAR_PEDIDOS_PUBLICO_CAB.PED_USUARIO <> 'Administrador' 
                                AND 
                                  Usuarios.nombre ='" + cboUsuarios.Text.ToString() + "'";
            
            
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, cone);

            cone.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sdr.Fill(dt);

            dgvRendicionBonoCont.DataSource = dt;

            cone.Close();
       }

        private void cboUsuarios_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dgvRendicionBonoCont_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

