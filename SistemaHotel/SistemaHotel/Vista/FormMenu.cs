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
    public partial class FormMenu : Form {

        public int id_empleado;
        public DateTime FechEntrada;
        public DateTime FechaSalida;


        public FormMenu(int id_empleado) {
            InitializeComponent();
            this.tab.Hide();
            this.SetStyle(ControlStyles.ResizeRedraw,true);
            this.id_empleado = id_empleado;
        }

        private void FormMenu_Load(object sender, EventArgs e){
             this.tabla_habitación.DataSource = Controlador.NHabitación.Mostrar();
            if (id_empleado>0){
                btn_empleado.Visible = false;
            }
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x84) {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.panel_bottom.PointToClient(pos);
                if (pos.Y<cCaption) {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.panel_bottom.ClientSize.Width - cGrip && pos.Y >= this.panel_bottom.ClientSize.Height - cGrip) {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        
        private void btn_salir_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void btn_menu_Click(object sender, EventArgs e) {
            bool flag = this.panel_menu.Visible;
            if (flag) {
                this.btn_salir.SetBounds(945,0,37,36);
                this.panel_menu.Visible = false;
            } else {
                this.panel_menu.Visible = true;
                this.btn_salir.SetBounds(745, 0, 37, 36);
            }
        }
        private void btn_home_Click(object sender, EventArgs e){
            this.Controls.Clear();
            this.InitializeComponent();
            this.tab.Hide();
        }

        private void btn_Habitación_Click(object sender, EventArgs e)
        {
            this.tab.Show();
        }

        private void btn_reserar_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente(Convert.ToInt32(combox_idHab.selectedValue), id_empleado, this.date_fechaEntrada.Value, this.date_FechaSalida.Value);
            int width = tab.Size.Width;
            int height = tab.Size.Height;
            int x = 201; 
            int y = 41;
            frmcliente.SetBounds(x, y, width, height);
            this.tab.Hide();
            this.Controls.Add(frmcliente);
        }

        private void btn_cliente_Click(object sender, EventArgs e){

            this.Controls.Clear();
            this.InitializeComponent();
            this.tab.Hide();

            frmCliente usercontrol = new frmCliente();
            int width = tab.Size.Width;
            int height = tab.Size.Height;
            int x = 201;
            int y = 41;
            usercontrol.SetBounds(x, y, width, height);
            this.tab.Hide();
            this.Controls.Add(usercontrol);
        }

        private void btn_reservas_Click(object sender, EventArgs e){
            frmReserva frmreserva = new frmReserva();
            frmreserva.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrada = this.date_fechaEntrada.Value;
            DateTime fechaSalida = this.date_FechaSalida.Value;
            if (switch_habilitar.Value == false)
            {
                int id = Convert.ToInt32(combox_idHab.selectedValue);
                tabla_habitación.DataSource = Controlador.NHabitación.Disponibilidad_Habitación(id, fechaEntrada, fechaSalida);
            }
            else
            {
                tabla_habitación.DataSource = Controlador.NHabitación.Estado_Habitacion(fechaEntrada, fechaSalida);
            }
        }

        private void switch_habilitar_Click(object sender, EventArgs e)
        {
            if (switch_habilitar.Value == true)
            {
                combox_idHab.Enabled = false;
            }
            else
            {
                combox_idHab.Enabled = true;
            }
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {

        }

        private void combox_hab_onItemSelected(object sender, EventArgs e)
        {
            int i = combox_hab.selectedIndex;
            switch (i){
                case 1:{
                        this.image_hab.Image = global::SistemaHotel.Properties.Resources.habitación_básica;
                        break;}
                case 2:{
                        this.image_hab.Image = global::SistemaHotel.Properties.Resources.habitació_Ejecutiva;
                        break;}
                case 3:{
                        this.image_hab.Image = global::SistemaHotel.Properties.Resources.habitación_presidencial;
                        break;}
            }
        }

        private void btn_huesped_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.tab.Hide();

            frmHuesped usercontrol = new frmHuesped();
            int width = tab.Size.Width;
            int height = tab.Size.Height;
            int x = 201;
            int y = 41;
            usercontrol.SetBounds(x, y, width, height);
            this.tab.Hide();
            this.Controls.Add(usercontrol);
        }

        private void btn_servicio_Click(object sender, EventArgs e)
        {
           frmServicio servicio= new frmServicio();
            servicio.Show();
        }
    }
}
