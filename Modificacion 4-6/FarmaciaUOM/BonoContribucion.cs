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
    public partial class BonoContribucion : Form
    {
        private DatosBono m_form = null;

        public BonoContribucion()
        {
            InitializeComponent();
        }

        private void BonoContribucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genteDAL.Tipo_Documento' table. You can move, or remove it, as needed.
            this.tipo_DocumentoTableAdapter.Fill(this.genteDAL.Tipo_Documento);
            // TODO: This line of code loads data into the 'genteDAL.Tipo_Documento' table. You can move, or remove it, as needed.
            this.tipo_DocumentoTableAdapter.Fill(this.genteDAL.Tipo_Documento);
            // TODO: This line of code loads data into the 'genteDAL.Tipo_Documento' table. You can move, or remove it, as needed.
            this.tipo_DocumentoTableAdapter.Fill(this.genteDAL.Tipo_Documento);
            this.tipo_DocumentoTableAdapter.Fill(this.genteDAL.Tipo_Documento);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            panel_Buscar.Visible = true;
            this.Refresh();
            BuscarPersona();
            panel_Buscar.Visible = false;
        }

        public void CargarPacienteID(long Id)
        {
            Pacientes p = Paciente_ID(Id);
            if (p != null)
            {
                CargarPaciente_id();
            }
        }

        public Pacientes Paciente_ID(long ID)
        {
            List<Pacientes> lista = new List<Pacientes>();
            CAD.HospitalDALTableAdapters.H2_Afiliado_Encabezado_IDTableAdapter adapter = new CAD.HospitalDALTableAdapters.H2_Afiliado_Encabezado_IDTableAdapter();
            CAD.HospitalDAL.H2_Afiliado_Encabezado_IDDataTable aTable = adapter.GetData(ID);

            int pos = 0;

            foreach (CAD.HospitalDAL.H2_Afiliado_Encabezado_IDRow row in aTable.Rows)
            {
                Pacientes p = new Pacientes();
                pos++;
                p.Nro_Busqueda = pos;
                p.cuil_titu = row.cuil_titu;
                p.cuil = row.cuil;
                if (!row.IssexoNull()) p.sexo = row.sexo; else p.sexo = "1";
                p.documento = row.documento;
                p.Documento = row.documento;
                if (!row.Isfecha_nacimientoNull()) p.fecha_nacimiento = row.fecha_nacimiento;
                if (!row.IsSeccionalNull()) p.Seccional = row.Seccional;

                if (!row.IsLocalidadNull()) { p.localidad = row.Localidad; }

                p.Paciente = row.apellido;

                if (!row.IsNro_SeccionalNull()) p.Nro_Seccional = row.Nro_Seccional.ToString(); else p.Nro_Seccional = "999";

                if (!row.IstelefonoNull()) p.Telefono = row.telefono;
                p.Titular = "";

                if (!row.IsOSNull()) p.ObraSocial = row.OS; else p.ObraSocial = "Sin Seccionalizar";
                if (!row.IsOSIdNull()) p.OSId = row.OSId; else p.OSId = 999;
                p.HC_UOM = row.HC_UOM_CENTRAL;

                if (!row.IsDiscapacidadNull())
                {
                    p.Discapacidad = Convert.ToInt32(row.Discapacidad);

                }
                else
                {
                    p.Discapacidad = 0;
                }

                if (!row.IsComentarioNull()) { p.Comentario = row.Comentario; }

                p.Documento_real = row.documento_real;
                p.Tipo_Documento = row.Tipo_doc;

                p.NHC = row.cuil;
                lista.Add(p);
            }
            if (lista.Count > 0)
            {
                return lista[0];
            }
            else
            {   
                MessageBox.Show("No se encontró paciente con el criterio de busqueda ingresado", "Paciente no encontado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            return null;
        }



        public List<Pacientes> Paciente_DOC(Int32 DOC, string T_Doc)
        {
            List<Pacientes> lista = new List<Pacientes>();
            CAD.HospitalDALTableAdapters.H2_Afiliado_Encabezado_DOCTableAdapter adapter = new CAD.HospitalDALTableAdapters.H2_Afiliado_Encabezado_DOCTableAdapter();
            CAD.HospitalDAL.H2_Afiliado_Encabezado_DOCDataTable aTable = adapter.GetData(DOC, T_Doc);

            int pos = 0;
            foreach (CAD.HospitalDAL.H2_Afiliado_Encabezado_DOCRow row in aTable.Rows)
            {
                Pacientes p = new Pacientes();
                pos++;
                p.Nro_Busqueda = pos;
                p.cuil_titu = row.cuil_titu;
                p.cuil = row.cuil;
                p.Documento_real = row.documento_real;

                if (!row.IssexoNull()) p.sexo = row.sexo; else p.sexo = "1";
                p.documento = row.documento;
                p.Documento = row.documento;
                p.Tipo_Documento = row.Tipo_doc;
                p.cod_tipo_documento = row.cod_tipo;
                if (!row.Isfecha_nacimientoNull()) p.fecha_nacimiento = row.fecha_nacimiento;
                if (!row.IsSeccionalNull()) p.Seccional = row.Seccional;

                if (!row.IsLocalidadNull()) { p.localidad = row.Localidad; }

                p.Paciente = row.apellido;

                if (!row.IsNro_SeccionalNull()) p.Nro_Seccional = row.Nro_Seccional.ToString(); else p.Nro_Seccional = "999";

                if (!row.IstelefonoNull()) p.Telefono = row.telefono;
                p.Titular = "";

                if (!row.IsOSNull()) p.ObraSocial = row.OS; else p.ObraSocial = "Sin Seccionalizar";
                if (!row.IsOSIdNull()) p.OSId = row.OSId; else p.OSId = 999;


                if (!row.IsDiscapacidadNull())
                {
                    p.Discapacidad = Convert.ToInt32(row.Discapacidad);

                }
                else
                {
                    p.Discapacidad = 0;
                }
                p.HC_UOM = row.HC_UOM_CENTRAL;
                p.NHC = row.cuil;

                if (!row.IsComentarioNull()) { p.Comentario = row.Comentario; }



                lista.Add(p);
            }

            if (lista.Count > 0)
            {
                return lista;
            }
            else
            {
                MessageBox.Show("No se encontró paciente con el criterio de busqueda ingresado", "Paciente no encontado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return null;
        }

        public List<Pacientes> Paciente_NHC(long NHC)
        {
            List<Pacientes> lista = new List<Pacientes>();
            CAD.HospitalDALTableAdapters.H2_Afiliado_Encabezado_NHCTableAdapter adapter = new CAD.HospitalDALTableAdapters.H2_Afiliado_Encabezado_NHCTableAdapter();
            CAD.HospitalDAL.H2_Afiliado_Encabezado_NHCDataTable aTable = adapter.GetData(NHC);

            int pos = 0;

            foreach (CAD.HospitalDAL.H2_Afiliado_Encabezado_NHCRow row in aTable.Rows)
            {
                Pacientes p = new Pacientes();
                pos++;
                p.Nro_Busqueda = pos;
                p.cuil_titu = row.cuil_titu;
                p.cuil = row.cuil;

                p.documento = row.documento;
                if (!row.Isfecha_nacimientoNull()) p.fecha_nacimiento = row.fecha_nacimiento;
                if (!row.IsSeccionalNull()) p.Seccional = row.Seccional;


                if (!row.IsLocalidadNull()) { p.localidad = row.Localidad; }

                p.Paciente = row.apellido;

                if (!row.IsNro_SeccionalNull()) p.Nro_Seccional = row.Nro_Seccional.ToString(); else p.Nro_Seccional = "999";

                if (!row.IstelefonoNull()) p.Telefono = row.telefono;
                p.Titular = "";

                if (!row.IsOSNull()) p.ObraSocial = row.OS; else p.ObraSocial = "Sin Seccionalizar";
                if (!row.IsOSIdNull()) p.OSId = row.OSId; else p.OSId = 999;

                p.HC_UOM = row.HC_UOM_CENTRAL;
                if (!row.IsDiscapacidadNull())
                {
                    p.Discapacidad = Convert.ToInt32(row.Discapacidad);

                }
                else
                {
                    p.Discapacidad = 0;
                }

                p.NHC = row.cuil;
                p.Documento = row.documento;
                p.Documento_real = row.documento_real;
                p.Tipo_Documento = row.Tipo_doc;

                if (!row.IsComentarioNull()) { p.Comentario = row.Comentario; }

                lista.Add(p);
            }

            if (lista.Count > 0)
            {
                return lista;
            }
            else
            {
                MessageBox.Show("No se encontraron pacientes con ese nro de HC", "Paciente no encontado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<Pacientes> Paciente_Apellido(string Apellido)
        {
            List<Pacientes> lista = new List<Pacientes>();
            CAD.HospitalDALTableAdapters.H2_Gente_BuscarPacientes_ApellidoTableAdapter adapter = new CAD.HospitalDALTableAdapters.H2_Gente_BuscarPacientes_ApellidoTableAdapter();
            CAD.HospitalDAL.H2_Gente_BuscarPacientes_ApellidoDataTable aTable = adapter.GetData(Apellido);

            int pos = 0;
            foreach (CAD.HospitalDAL.H2_Gente_BuscarPacientes_ApellidoRow row in aTable.Rows)
            {
                Pacientes p = new Pacientes();
                pos++;
                p.Nro_Busqueda = pos;
                p.Paciente = row.apellido;
                p.Documento = row.documento;
                if (!row.IstelefonoNull() && row.telefono.Length > 5) p.Telefono = row.telefono; else p.Telefono = "";
                p.HC_UOM = row.HC_UOM_CENTRAL;
                p.NHC = row.cuil;
                p.Documento_real = row.documento_real;
                p.Tipo_Documento = row.Tipo_doc;
                lista.Add(p);

                if (!row.IsComentarioNull()) { p.Comentario = row.Comentario; }
            }

            return lista;
        }

        public string Edad(DateTime nacimiento)
        {
            // Crear fechas     
            if (nacimiento.Year == 1 && nacimiento.Month == 1) { return ""; }

            DateTime hoy = DateTime.Now;

            // Años
            int edadAnos = hoy.Year - nacimiento.Year;
            if (hoy.Month < nacimiento.Month || (hoy.Month == nacimiento.Month &&
            hoy.Day < nacimiento.Day))
                edadAnos--;

            // Meses
            int edadMeses = hoy.Month - nacimiento.Month;
            if (hoy.Day < nacimiento.Day)
                edadMeses--;
            if (edadMeses < 0)
                edadMeses += 12;

            // Mostrar
            return edadAnos + " años " + edadMeses + " meses";
        }


        public List<Pacientes> CargarPacienteDOC(int Documento, string TDoc)
        {
            List<Pacientes> p = Paciente_DOC(Documento, TDoc);
            if (p != null)
            {
                return p;
            }
            else
            {
                return null;
            }
        }

        public List<Pacientes> CargarPacienteNHC(long NHC)
        {
            List<Pacientes> p = Paciente_NHC(NHC);
            if (p != null)
            {
                return p;
            }
            else
            {
                return null;
            }
        }

        public List<Pacientes> CargarPacienteAyN(string AyN)
        {
            return Paciente_Apellido(AyN);
        }

        private void BuscarPersona()
        {
            List<Pacientes> pp = new List<Pacientes>();
            dgv_Pacientes.DataSource = null;

            if (txt_dni.Text != "")
            {
                pp = CargarPacienteDOC(Convert.ToInt32(txt_dni.Text), cbo_Tipo_Doc.SelectedValue.ToString());
                dgv_Pacientes.AutoGenerateColumns = false;
                dgv_Pacientes.DataSource = pp;
            }
            else
            {
                if (txt_NHC.Text != "" && txt_NHC.Text.Length > 8)
                {
                    pp = CargarPacienteNHC(Convert.ToInt64(txt_NHC.Text.Replace("-", "")));
                    dgv_Pacientes.AutoGenerateColumns = false;
                    dgv_Pacientes.DataSource = pp;
                }
                else
                {
                    if (txt_AyN.Text != "")
                    {
                        pp = CargarPacienteAyN(txt_AyN.Text);
                        dgv_Pacientes.AutoGenerateColumns = false;
                        dgv_Pacientes.DataSource = pp;
                    }
                }

            }
            dgv_Pacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipo_DocumentoTableAdapter.FillBy(this.genteDAL.Tipo_Documento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgv_Pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosBono dt = new DatosBono();
            dt.Show();
        }



        private void cbo_Tipo_Doc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarPaciente_id()
        {
            DatosBono parent = (DatosBono)this.Owner;
            Pacientes paciente = new Pacientes();

            paciente = Paciente_ID(Convert.ToInt64(txt_paciente_id.Text.Replace("-", "")));
            parent.lbl_Apellido_Nombre.Text = "Paciente: " + paciente.Paciente;
            parent.lbl_Dni.Text = "DNI:" + paciente.Tipo_Documento;  
            parent.lbl_Telefono.Text ="Teléfono: " + paciente.Telefono;
            parent.lbl_Seccional.Text = "Seccional: " + paciente.Seccional;



            //parent.lbl_edad.Text = edad;

            this.Close();
        }

        private void dgv_Pacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            panel_Buscar.Visible = true;
            label6.Text = "Buscando....";
            this.Refresh();

            if (dgv_Pacientes.Rows.Count > 0)
            {
                if (e.RowIndex != -1)
                {
                    string buscar = dgv_Pacientes[5, dgv_Pacientes.CurrentCell.RowIndex].Value.ToString();

                    
               //     CargarPacienteID(Convert.ToInt64(buscar));
                }
            }
            
        }
    }
}
