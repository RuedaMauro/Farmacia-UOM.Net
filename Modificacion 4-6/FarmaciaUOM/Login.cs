using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarmaciaUOM.Entidades;
using System.Net;

namespace FarmaciaUOM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            VariablesGlobales.Usuarioseccional = "003";

            if(Init(txt_user.Text,txt_password.Text)=="OK=54")
            {
                this.Hide();
                PrincipalFarmacia principalF = new PrincipalFarmacia();
                principalF.Show();
            }
            else
            {
                MessageBox.Show("Error, el usuario o la contraseña es Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_user.Text = "";
                txt_password.Text = "";
                txt_user.Focus();          
            }

        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No se ha podido resolver la dirección IP del usuario");
        }


        public string Init(string Usuario, string Clave)
        {

            CAD.HospitalDALTableAdapters.H2_Usuario_LoginTableAdapter adtr = new CAD.HospitalDALTableAdapters.H2_Usuario_LoginTableAdapter();
            CAD.HospitalDAL.H2_Usuario_LoginDataTable aTable = adtr.GetData(Usuario, Clave);

            if (aTable.Rows.Count > 0)
            {
                Usuarios.activo = aTable[0].activo;
                Usuarios.vencimiento = aTable[0].fechavencimiento;

                if (!Usuarios.activo) { return "ERROR=No es un usuario en actividad.</br>Comuniquese con Sistemas"; }
                if (Usuarios.vencimiento < DateTime.Now) { return "ERROR=El usuario ha superado la fecha de vencimiento.</br>Comuniquese con Sistemas"; }

                Usuarios.id = aTable[0].id;
                Usuarios.nombre = aTable[0].nombre;
                Usuarios.usuario = aTable[0].usuario;
                Usuarios.seccional = aTable[0].Seccional;
                if (!aTable[0].IstipoNull()) { Usuarios.tipo = aTable[0].tipo; } else { Usuarios.tipo = "Usuario"; }
                if (!aTable[0].IspermisosNull()) { Usuarios.permisos = aTable[0].permisos; } else { Usuarios.permisos = ""; }
                if (!aTable[0].IspermisosBNull()) { Usuarios.permisosB = aTable[0].permisosB; } else { Usuarios.permisosB = ""; }
                Usuarios.permisos = Usuarios.permisos + Usuarios.permisosB;

                VariablesGlobales.Usuarioid = Usuarios.id;
                VariablesGlobales.Usuarioseccional = Usuarios.seccionalnumero;
                VariablesGlobales.UsuarioTipo = Usuarios.tipo;
                VariablesGlobales.permisosG = Usuarios.permisosG;
                VariablesGlobales.ip = GetLocalIPAddress();
                try
                {
                    CAD.FarmaciaDALTableAdapters.QueriesTableAdapter query = new CAD.FarmaciaDALTableAdapters.QueriesTableAdapter();
                    query.H3_Farmacia_Usuario_Login(Convert.ToInt32(Usuarios.id), "Inicio Sesión Farmacia // " + VariablesGlobales.ip);

                }
                catch
                {

                }

                return "OK=54";

            }
            return "ERROR=Usuario y/o Contraseña incorrecto";
        }
        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Hide();
                PrincipalFarmacia principalF = new PrincipalFarmacia();
                principalF.Show();
            }
        }
    }
}
