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
    public partial class FrmCliente : UserControl {

        private int Id;
        public int id_empleado;
        public int no_habitación;
        public DateTime FechaEntrada;
        public DateTime FechaSalida;

        public FrmCliente()
        {
            InitializeComponent();
        }

        public FrmCliente(int id_empleado,int no_habitación,DateTime FechaEntrada,DateTime FechaSalida) {
            InitializeComponent();
            this.id_empleado = id_empleado;
            this.no_habitación = no_habitación;
            this.FechaEntrada = FechaEntrada;
            this.FechaSalida = FechaSalida;
        }

        private void UserControl1_Load(object sender, EventArgs e) {
            this.habilitar(true,false);
            this.tabla_cliente.DataSource = Controlador.NCliente.Mostrar();
        }

        public void habilitar(bool nuevo,bool editar) {
            if (nuevo) {
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
            } else if(!nuevo || editar){
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

        public bool validar(Bunifu.Framework.UI.BunifuMaterialTextbox textbox,string texto) {
            if (textbox.Text == texto) {
                textbox.Text = texto;
                return true;
            }
            return false;
        }

        private void Guardar(){
            if (validar(txt_PrimerNombre, "Primer Nombre") ||
               validar(txt_SegundoNombre, "Segundo Nombre") ||
               validar(txt_PrimerApellido, "Primer Apellido") ||
               validar(txt_SegundoApellido, "Segundo Apellido") ||
               validar(txt_Correo, "Correo") ||
               validar(txt_Dirección, "Dirección") ||
               validar(txt_Teléfono, "Teléfono")){
                MessageBox.Show("Verifique bien los campos");
            }
            else if (Controlador.NCliente.Insertar(txt_PrimerNombre.Text, txt_SegundoNombre.Text, txt_PrimerApellido.Text, txt_SegundoApellido.Text, txt_Dirección.Text, txt_Teléfono.Text, txt_Correo.Text)){
                FrmReserva frmreserva = new FrmReserva(NCliente.get_idCliente(), id_empleado, no_habitación, FechaEntrada, FechaSalida);
                MessageBox.Show("Guardado exitosamente");
                frmreserva.Show();
                this.limpiar();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e) {
            this.Guardar();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e) {
            habilitar(false,false);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) {
            habilitar(true,false);
        }

        private void limpiar() {
            this.txt_PrimerNombre.Text = "";
            this.txt_SegundoNombre.Text = "";
            this.txt_PrimerApellido.Text = "";
            this.txt_SegundoApellido.Text = "";
            this.txt_Correo.Text = "";
            this.txt_Dirección.Text = "";
            this.txt_Teléfono.Text = "";
            habilitar(true,false);
        }


        private void switch_habilitar_Click(object sender, EventArgs e)
        {
            if (NCliente.habilitar(Id))
            {
                this.tabla_cliente.DataSource = Controlador.NCliente.Mostrar();
            }
        }


        public void press()
        {
            Id=Convert.ToInt32(this.tabla_cliente.CurrentRow.Cells["id_cliente"].Value);
            this.txt_PrimerNombre.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells["Primer Nombre"].Value);
            this.txt_SegundoNombre.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells["Segundo Nombre"].Value);
            this.txt_PrimerApellido.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells["Primer Apellido"].Value);
            this.txt_SegundoApellido.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells["Segundo Apellido"].Value);
            this.txt_Dirección.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells["Dirección"].Value);
            this.txt_Correo.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells["Correo"].Value);
            this.txt_Teléfono.Text = Convert.ToString(this.tabla_cliente.CurrentRow.Cells["Teléfono"].Value);
            string estado = Convert.ToString(this.tabla_cliente.CurrentRow.Cells["estado"].Value);
            if (estado == "HABILITADO")
            {
                this.switch_habilitar.Value = true;
            }
            else if (estado == "DESHABILITADO")
            {
                this.switch_habilitar.Value = false;
            }
        }

        private void tabla_cliente_DoubleClick(object sender, EventArgs e) {
            habilitar(false, true);
            press();
        }

        private void txt_Buscar_OnTextChange(object sender, EventArgs e) {
            this.tabla_cliente.DataSource = NCliente.BuscarAsegurado(this.txt_Buscar.Text.Trim());
        }


        private void txt_PrimerNombre_Enter(object sender, EventArgs e) {
            if (txt_PrimerNombre.Text== "Primer Nombre") {
                txt_PrimerNombre.Text = "";
            }
        }

        private void txt_PrimerNombre_Leave(object sender, EventArgs e) {
            if(txt_PrimerNombre.Text=="") {
               txt_PrimerNombre.Text = "Primer Nombre";
            }
        }

        private void txt_SegundoNombre_Enter(object sender, EventArgs e) {
            if (txt_SegundoNombre.Text=="Segundo Nombre") {
                txt_SegundoNombre.Text = "";
            }
        }

        private void txt_SegundoNombre_Leave(object sender, EventArgs e) {
            if (txt_SegundoNombre.Text=="") {
                txt_SegundoNombre.Text = "Segundo Nombre";
            }
        }

        private void txt_PrimerApellido_Enter(object sender, EventArgs e) {
            if (txt_PrimerApellido.Text=="Primer Apellido") {
                txt_PrimerApellido.Text = "";
            }
        }

        private void txt_PrimerApellido_Leave(object sender, EventArgs e) {
            if (txt_PrimerApellido.Text == "") {
                txt_PrimerApellido.Text = "Primer Apellido";
            }
        }

        private void txt_SegundoApellido_Enter(object sender, EventArgs e) {
            if (txt_SegundoApellido.Text == "Segundo Apellido") {
                txt_SegundoApellido.Text = "";
            }
        }

        private void txt_SegundoApellido_Leave(object sender, EventArgs e) {
            if (txt_SegundoApellido.Text == "") {
                txt_SegundoApellido.Text = "Segundo Apellido";
            }
        }

        private void txt_Dirección_Enter(object sender, EventArgs e) {
            if (txt_Dirección.Text == "Dirección") {
                txt_Dirección.Text = "";
            }
        }

        private void txt_Dirección_Leave(object sender, EventArgs e) {
            if (txt_Dirección.Text == "") {
                txt_Dirección.Text = "Dirección";
            }
        }

        private void txt_Correo_Enter(object sender, EventArgs e) {
            if (txt_Correo.Text == "Correo") {
                txt_Correo.Text="";
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e) {
            if (txt_Correo.Text == "") {
                txt_Correo.Text = "Correo";
            }
        }

        private void txt_Teléfono_Enter(object sender, EventArgs e) {
            if (txt_Teléfono.Text == "Teléfono") {
                txt_Teléfono.Text = "";
            }
        }

        private void txt_Teléfono_Leave(object sender, EventArgs e) {
            if (txt_Teléfono.Text == "") {
                txt_Teléfono.Text = "Teléfono";
            }
        }

        private void txt_Buscar_Enter(object sender, EventArgs e) {
            if (txt_Buscar.text== "Busque un Cliente") {
                txt_Buscar.text = "";
            }
        }

        private void txt_Buscar_Leave(object sender, EventArgs e) {
            if (txt_Buscar.text == "") {
                txt_Buscar.text = "Busque un Cliente";
            }
        }

        private void txt_Teléfono_KeyPress(object sender, KeyPressEventArgs e) {
            Controlador.Tools.soloNúmeros(e);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(this.tabla_cliente.CurrentRow.Cells["id_cliente"].Value);
            bool flag =  NCliente.Editar(Id,this.txt_PrimerNombre.Text, this.txt_SegundoNombre.Text, this.txt_PrimerApellido.Text, this.txt_SegundoApellido.Text, this.txt_Dirección.Text, this.txt_Correo.Text, this.txt_Teléfono.Text);
            if (flag){
                MessageBox.Show("Editado Existosamente");
            }else
            {
                MessageBox.Show("Error al Editar");
            }
        }

        private void txt_PrimerNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { this.txt_SegundoNombre.Focus(); }
        }

        private void txt_SegundoNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { this.txt_PrimerApellido.Focus(); }
        }

        private void txt_PrimerApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { this.txt_SegundoApellido.Focus(); }
        }

        private void txt_SegundoApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { this.txt_Dirección.Focus(); }
        }

        private void txt_Dirección_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { this.txt_Correo.Focus(); }
        }

        private void txt_Correo_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter) { this.txt_Teléfono.Focus(); }
        }

        private void txt_Teléfono_KeyDown(object sender, KeyEventArgs e){
          
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

        private void txt_Dirección_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.tabla_cliente.DataSource = NCliente.BuscarAsegurado(textBox1.Text.Trim());
        }
    }
}
