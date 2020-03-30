using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotel.Controlador;
using SistemaHotel.Modelo;

namespace SistemaHotel.Vista {
    public partial class FrmHuesped : UserControl
    {
        public int IdHuesped;
        public int Idhabitacion_reserva;

        public FrmHuesped(int Idhabitacion_reserva)
        {
            InitializeComponent();
            this.Idhabitacion_reserva = Idhabitacion_reserva;
            this.HabilitaBotones(true, false);
        }

        private void frmHuesped_Load(object sender, EventArgs e) {
            this.tabla_huesped.DataSource = Controlador.NHuesped.Mostrar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool flag = NHuesped.Insertar_Huesped(txt_PrimerNombre.Text,txt_SegundoNombre.Text,txt_PrimerApellido.Text,txt_SegundoApellido.Text, txt_Dirección.Text,txt_Teléfono.Text, txt_nacionalidad.Text, txt_Correo.Text, Idhabitacion_reserva);
            if (flag)
            {
                MessageBox.Show("Ingresado exitosamente");
                this.Hide();
            }
            else {
                MessageBox.Show("Error");
            }
        }

        private void btn_Nuevo_Click (object sender, EventArgs e)
        {
            HabilitaBotones(false, false);
            //MessageBox.Show("" + Idhabitacion_reserva);
        }

        public void HabilitaBotones (bool nuevo, bool editar)
        {
            if (nuevo)
            {
                //Botones
                this.btn_Nuevo.Enabled = true;
                this.btn_Editar.Enabled = false;
                this.btn_guardar.Enabled = false;
                this.btn_Cancelar.Enabled = false;
                //Cajas de texto
                this.txt_PrimerNombre.Enabled = false;
                this.txt_SegundoNombre.Enabled = false;
                this.txt_PrimerApellido.Enabled = false;
                this.txt_SegundoApellido.Enabled = false;
                this.txt_Correo.Enabled = false;
                this.txt_Dirección.Enabled = false;
                this.txt_Teléfono.Enabled = false;
            }
            else if (!nuevo || editar)
            {
                //Botones
                this.btn_Nuevo.Enabled = false;
                this.btn_Editar.Enabled = false;
                ;
                this.btn_guardar.Enabled = true;
                this.btn_Cancelar.Enabled = true;
                //Cajas de texto
                this.txt_PrimerNombre.Enabled = true;
                this.txt_SegundoNombre.Enabled = true;
                this.txt_PrimerApellido.Enabled = true;
                this.txt_SegundoApellido.Enabled = true;
                this.txt_Correo.Enabled = true;
                this.txt_Dirección.Enabled = true;
                this.txt_Teléfono.Enabled = true;
            }
        }

        public bool ValidarTextBox (Bunifu.Framework.UI.BunifuMaterialTextbox textbox)
        {
            return (textbox.Text.Length == 0);
        }

        private void GuardarDatos ()
        {
            //Controlador.NCliente.Insertar(txt_PrimerNombre.Text, txt_SegundoNombre.Text, txt_PrimerApellido.Text, txt_SegundoApellido.Text, txt_Dirección.Text, txt_Teléfono.Text, txt_Correo.Text)
            if (ValidarTextBox(txt_PrimerNombre) ||
                ValidarTextBox(txt_SegundoNombre) ||
                ValidarTextBox(txt_PrimerApellido) ||
                ValidarTextBox(txt_SegundoApellido) ||
                ValidarTextBox(txt_Correo) ||
                ValidarTextBox(txt_Dirección) ||
                ValidarTextBox(txt_Teléfono))
            {
                MessageBox.Show("Verifique bien los campos");
            }
            else if (Controlador.NCliente.Insertar(txt_PrimerNombre.Text, txt_SegundoNombre.Text, txt_PrimerApellido.Text, txt_SegundoApellido.Text, txt_Dirección.Text, txt_Teléfono.Text, txt_Correo.Text))
            {
                MessageBox.Show("Guardado exitosamente");
                this.MostrarListaClientes();
                this.limpiar();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }

        public void MostrarListaClientes ()
        {
            this.tabla_huesped.DataSource = Controlador.NHuesped.Mostrar();
        }

        private void limpiar ()
        {
            this.txt_PrimerNombre.Text = "";
            this.txt_SegundoNombre.Text = "";
            this.txt_PrimerApellido.Text = "";
            this.txt_SegundoApellido.Text = "";
            this.txt_Correo.Text = "";
            this.txt_Dirección.Text = "";
            this.txt_Teléfono.Text = "";
            HabilitaBotones(true, false);
        }

        public void AgregarDatosDeTabla ()
        {
            IdHuesped = Convert.ToInt32(this.tabla_huesped.CurrentRow.Cells ["Id_huesped"].Value);
            this.txt_PrimerNombre.Text = Convert.ToString(this.tabla_huesped.CurrentRow.Cells ["p_nom"].Value);
            this.txt_SegundoNombre.Text = Convert.ToString(this.tabla_huesped.CurrentRow.Cells ["s_nom"].Value);
            this.txt_PrimerApellido.Text = Convert.ToString(this.tabla_huesped.CurrentRow.Cells ["p_apell"].Value);
            this.txt_SegundoApellido.Text = Convert.ToString(this.tabla_huesped.CurrentRow.Cells ["s_apell"].Value);
            this.txt_Dirección.Text = Convert.ToString(this.tabla_huesped.CurrentRow.Cells ["direccion"].Value);
            this.txt_Correo.Text = Convert.ToString(this.tabla_huesped.CurrentRow.Cells ["correo"].Value);
            this.txt_Teléfono.Text = Convert.ToString(this.tabla_huesped.CurrentRow.Cells ["tel"].Value);
            this.txt_nacionalidad.Text = Convert.ToString(this.tabla_huesped.CurrentRow.Cells ["nacionalidad"].Value);
        }

        private void tabla_huesped_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            AgregarDatosDeTabla();
            this.HabilitaBotones(false, true);
        }

        private void btn_Cancelar_Click (object sender, EventArgs e)
        {
            HabilitaBotones(true, false);
            limpiar();
        }
    }
}
