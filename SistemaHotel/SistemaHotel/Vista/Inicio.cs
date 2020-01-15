using SistemaHotel.Controlador;
using SistemaHotel.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Vista {
    public partial class Inicio : Form {

        public Inicio() {
            InitializeComponent();
        }

        public void Ingresar() {
            string login = txt_user.Text;
            string password = txt_pass.Text;
            string Rol = NUsuario.Rol_Usuario(login, password);

            if ((Rol == "Administrador") && (NUsuario.Validar_acceso(login, password) != null))
            {
                FormMenu fc = new FormMenu(0);
                fc.Show();
                this.Hide();
            }
            else if (Rol == "Empleado" && (NUsuario.Validar_acceso(login, password) != null))
            {
                FormMenu fc = new FormMenu(NUsuario.Mostrar(login, password));
                fc.id_empleado = NUsuario.Mostrar(login, password);
                fc.btn_empleado.Visible = false;
                fc.Show();
                this.Hide();
            }
            else { MessageBox.Show("Acceso Denegado al Sistema de Reservaciones", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_ingresar_Click(object sender, EventArgs e) {
            this.Ingresar();
        }
        private void btn_cerrar_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void txt_user_Enter(object sender, EventArgs e){
            if (txt_user.Text == "Usuario"){ txt_user.Text = ""; }
        }

        private void txt_user_Leave(object sender, EventArgs e){
            if (txt_user.Text == "") { txt_user.Text = "Usuario"; }
        }

        private void txt_pass_Enter(object sender, EventArgs e){
            if (txt_pass.Text == "Contraseña"){txt_pass.Text = ""; }
        }

        private void txt_pass_Leave(object sender, EventArgs e){
            if (txt_pass.Text == "") { txt_pass.Text = "Contraseña"; }
        }
        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.Enter) { txt_pass.Focus(); }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Ingresar(); }
        }
    }
}
