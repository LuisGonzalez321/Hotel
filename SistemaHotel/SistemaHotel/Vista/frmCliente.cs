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

namespace SistemaHotel.Vista {
    public partial class FrmCliente: UserControl
    {

        private int IdCliente;

        public FrmCliente ()
        {
            InitializeComponent();
        }

        private void UserControl1_Load (object sender, EventArgs e)
        {
            this.HabilitaBotones(true, false);
            this.MostrarListaClientes();
        }

        public void MostrarListaClientes ()
        {
            this.tabla_cliente.DataSource = Controlador.NCliente.Mostrar();
        }

        public void HabilitaBotones(bool nuevo, bool editar) {
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
            else if(!nuevo || editar)
            {
                //Botones
                this.btn_Nuevo.Enabled = false;
                this.btn_Editar.Enabled = false; ;
                this.btn_guardar.Enabled = true;
                this.btn_Cancelar.Enabled = true;
                this.switch_habilitar.Enabled = true;
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

        public bool ValidarTextBox(Bunifu.Framework.UI.BunifuMaterialTextbox textbox)
        {
            return (textbox.Text.Length == 0);
        }

        private void GuardarDatos()
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.GuardarDatos();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            HabilitaBotones(false,false);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            HabilitaBotones(true,false);
            limpiar();
        }

        private void limpiar()
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


        private void switch_habilitar_Click(object sender, EventArgs e)
        {
            if (NCliente.habilitar(IdCliente)) this.tabla_cliente.DataSource = Controlador.NCliente.Mostrar(); 
        }

        private void tabla_cliente_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            HabilitaBotones(false, true);
            AgregarDatosDeTabla();
        }

        private void tabla_cliente_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            IdCliente = Convert.ToInt32(this.tabla_cliente.CurrentRow.Cells ["Id_cliente"].Value);
            string estado = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["estado"].Value);
            if (estado == "HABILITADO")
            {
                this.switch_habilitar.Value = true;
            }
            else if (estado == "DESHABILITADO")
            {
                this.switch_habilitar.Value = false;
            }
        }


        public void AgregarDatosDeTabla ()
        {
            IdCliente = Convert.ToInt32(this.tabla_cliente.CurrentRow.Cells ["Id_cliente"].Value);
            this.txt_PrimerNombre.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["Primer Nombre"].Value);
            this.txt_SegundoNombre.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["Segundo Nombre"].Value);
            this.txt_PrimerApellido.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["Primer Apellido"].Value);
            this.txt_SegundoApellido.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["Segundo Apellido"].Value);
            this.txt_Dirección.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["Dirección"].Value);
            this.txt_Correo.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["Correo"].Value);
            this.txt_Teléfono.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["Teléfono"].Value);
            string estado = Convert.ToString(this.tabla_cliente.CurrentRow.Cells ["estado"].Value);

            if (estado == "HABILITADO")
            {
                this.switch_habilitar.Value = true;
            }
            else if (estado == "DESHABILITADO")
            {
                this.switch_habilitar.Value = false;
            }
        }

        private void txt_Buscar_OnTextChange(object sender, EventArgs e)
        {
          this.tabla_cliente.DataSource = NCliente.BuscarAsegurado(this.txt_Buscar.Text.Trim());
        }
         
        private void txt_Teléfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.Tools.soloNúmeros(e);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            IdCliente = Convert.ToInt32(this.tabla_cliente.CurrentRow.Cells["id_cliente"].Value);
            bool flag =  NCliente.Editar(IdCliente, this.txt_PrimerNombre.Text, this.txt_SegundoNombre.Text, this.txt_PrimerApellido.Text, this.txt_SegundoApellido.Text, this.txt_Dirección.Text, this.txt_Correo.Text, this.txt_Teléfono.Text);
            if (flag)
            {
                MessageBox.Show("Editado Existosamente");
            }else
            {
                MessageBox.Show("Error al Editar");
            }
        }

        private void txt_PrimerNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  this.txt_SegundoNombre.Focus(); 
        }

        private void txt_SegundoNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  this.txt_PrimerApellido.Focus(); 
        }

        private void txt_PrimerApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  this.txt_SegundoApellido.Focus(); 
        }

        private void txt_SegundoApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.txt_Dirección.Focus();
        }

        private void txt_Dirección_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  this.txt_Correo.Focus(); 
        }

        private void txt_Correo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  this.txt_Teléfono.Focus(); 
        }

        private void txt_PrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.Tools.soloLetras(e);
        }

        private void txt_SegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.Tools.soloLetras(e);
        }

        private void txt_PrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.Tools.soloLetras(e);
        }

        private void txt_SegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controlador.Tools.soloLetras(e);
        }


    }
}
