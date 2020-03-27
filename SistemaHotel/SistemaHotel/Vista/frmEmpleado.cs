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

namespace SistemaHotel.Vista
{
    public partial class FrmEmpleado: UserControl
    {
        private int Id;

        public FrmEmpleado ()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load (object sender, EventArgs e)
        {
            this.habilitar(true);
            this.tabla_empleado.DataSource = Controlador.NEmpleado.Mostrar_Empleados();
        }

        public void habilitar (bool nuevo)
        {
            if (nuevo)
            {
                //Botones
                this.btn_Nuevo.Enabled = true;
                this.btn_Editar.Enabled = false;
                this.btn_guardar.Enabled = false;
                this.btn_Cancelar.Enabled = false;
                //this.switch_habilitar.Enabled = false;
                //Cajas de texto
                this.txt_PrimerNombre.Enabled = false;
                this.txt_SegundoNombre.Enabled = false;
                this.txt_PrimerApellido.Enabled = false;
                this.txt_SegundoApellido.Enabled = false;
                this.txt_Correo.Enabled = false;
                this.txt_Dirección.Enabled = false;
                this.txt_Teléfono.Enabled = false;
            }
            else
            {
                //Botones
                this.btn_Nuevo.Enabled = false;
                this.btn_Editar.Enabled = false;
                ;
                this.btn_guardar.Enabled = true;
                this.btn_Cancelar.Enabled = true;
                // this.switch_habilitar.Enabled = true;
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

        private void txtBuscar_TextChanged (object sender, EventArgs e)
        {
            this.tabla_empleado.DataSource = NEmpleado.BuscarAsegurado(this.txt_Buscar.Text.Trim());
        }

        public bool validar (Bunifu.Framework.UI.BunifuMaterialTextbox textbox, string texto)
        {
            return (textbox.Text == texto);
        }

        private void btn_guardar_Click (object sender, EventArgs e)
        {
            if (validar(txt_PrimerNombre, "Primer Nombre") ||
                validar(txt_SegundoNombre, "Segundo Nombre") ||
                validar(txt_PrimerApellido, "Primer Apellido") ||
                validar(txt_SegundoApellido, "Segundo Apellido") ||
                validar(txt_Correo, "Correo") ||
                validar(txt_Dirección, "Dirección") ||
                validar(txt_Teléfono, "Teléfono"))
            {
                MessageBox.Show("Verifique bien los campos");
            }
            else if (Controlador.NEmpleado.Insertar(txt_PrimerNombre.Text, txt_SegundoNombre.Text, txt_PrimerApellido.Text, txt_SegundoApellido.Text, txt_Dirección.Text, txt_Teléfono.Text, txt_Correo.Text))
            {
                MessageBox.Show("Guardado exitosamente");
                this.limpiar();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void btn_Nuevo_Click (object sender, EventArgs e)
        {
            habilitar(false);
        }

        private void btn_Cancelar_Click (object sender, EventArgs e)
        {
            habilitar(true);
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

        }


        public void PresionarCelda ()
        {
            Id = Convert.ToInt32(this.tabla_empleado.CurrentRow.Cells ["id_cliente"].Value);
            this.txt_PrimerNombre.Text = Convert.ToString(this.tabla_empleado.CurrentRow.Cells ["Primer Nombre"].Value);
            this.txt_SegundoNombre.Text = Convert.ToString(this.tabla_empleado.CurrentRow.Cells ["Segundo Nombre"].Value);
            this.txt_PrimerApellido.Text = Convert.ToString(this.tabla_empleado.CurrentRow.Cells ["Primer Apellido"].Value);
            this.txt_SegundoApellido.Text = Convert.ToString(this.tabla_empleado.CurrentRow.Cells ["Segundo Apellido"].Value);
            this.txt_Dirección.Text = Convert.ToString(this.tabla_empleado.CurrentRow.Cells ["Dirección"].Value);
            this.txt_Correo.Text = Convert.ToString(this.tabla_empleado.CurrentRow.Cells ["Correo"].Value);
            this.txt_Teléfono.Text = Convert.ToString(this.tabla_empleado.CurrentRow.Cells ["Teléfono"].Value);
        }

        private void tabla_cliente_DoubleClick (object sender, EventArgs e)
        {
            PresionarCelda();
        }

        private void txt_Buscar_OnTextChange (object sender, EventArgs e)
        {
            this.tabla_empleado.DataSource = NCliente.BuscarAsegurado(this.txt_Buscar.Text.Trim());
        }

        private void txt_PrimerNombre_Enter (object sender, EventArgs e)
        {
            if (txt_PrimerNombre.Text == "Primer Nombre")
            {
                txt_PrimerNombre.Text = "";
            }
        }

        private void txt_PrimerNombre_Leave (object sender, EventArgs e)
        {
            if (txt_PrimerNombre.Text == "")
            {
                txt_PrimerNombre.Text = "Primer Nombre";
            }
        }

        private void txt_SegundoNombre_Enter (object sender, EventArgs e)
        {
            if (txt_SegundoNombre.Text == "Segundo Nombre")
            {
                txt_SegundoNombre.Text = "";
            }
        }

        private void txt_SegundoNombre_Leave (object sender, EventArgs e)
        {
            if (txt_SegundoNombre.Text == "")
            {
                txt_SegundoNombre.Text = "Segundo Nombre";
            }
        }

        private void txt_PrimerApellido_Enter (object sender, EventArgs e)
        {
            if (txt_PrimerApellido.Text == "Primer Apellido")
            {
                txt_PrimerApellido.Text = "";
            }
        }

        private void txt_PrimerApellido_Leave (object sender, EventArgs e)
        {
            if (txt_PrimerApellido.Text == "")
            {
                txt_PrimerApellido.Text = "Primer Apellido";
            }
        }

        private void txt_SegundoApellido_Enter (object sender, EventArgs e)
        {
            if (txt_SegundoApellido.Text == "Segundo Apellido")
            {
                txt_SegundoApellido.Text = "";
            }
        }

        private void txt_SegundoApellido_Leave (object sender, EventArgs e)
        {
            if (txt_SegundoApellido.Text == "")
            {
                txt_SegundoApellido.Text = "Segundo Apellido";
            }
        }

        private void txt_Dirección_Enter (object sender, EventArgs e)
        {
            if (txt_Dirección.Text == "Dirección")
            {
                txt_Dirección.Text = "";
            }
        }

        private void txt_Dirección_Leave (object sender, EventArgs e)
        {
            if (txt_Dirección.Text == "")
            {
                txt_Dirección.Text = "Dirección";
            }
        }

        private void txt_Correo_Enter (object sender, EventArgs e)
        {
            if (txt_Correo.Text == "Correo")
            {
                txt_Correo.Text = "";
            }
        }

        private void txt_Correo_Leave (object sender, EventArgs e)
        {
            if (txt_Correo.Text == "")
            {
                txt_Correo.Text = "Correo";
            }
        }

        private void txt_Teléfono_Enter (object sender, EventArgs e)
        {
            if (txt_Teléfono.Text == "Teléfono")
            {
                txt_Teléfono.Text = "";
            }
        }

        private void txt_Teléfono_Leave (object sender, EventArgs e)
        {
            if (txt_Teléfono.Text == "")
            {
                txt_Teléfono.Text = "Teléfono";
            }
        }

        private void txt_Buscar_Enter (object sender, EventArgs e)
        {
            if (txt_Buscar.text == "Busque un Cliente")
            {
                txt_Buscar.text = "";
            }
        }

        private void txt_Buscar_Leave (object sender, EventArgs e)
        {
            if (txt_Buscar.text == "")
            {
                txt_Buscar.text = "Busque un Cliente";
            }
        }

        private void txt_Teléfono_KeyPress (object sender, KeyPressEventArgs e)
        {
            Controlador.Tools.soloNúmeros(e);
        }

        private void btn_Editar_Click (object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click_1 (object sender, EventArgs e)
        {

        }
    }
}
