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
    public partial class FrmMenu : Form {

        public int id_empleado;
        public DateTime FechEntrada;
        public DateTime FechaSalida;


        public FrmMenu(int id_empleado) {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw,true);
            this.id_empleado = id_empleado;
        }

        private void FormMenu_Load(object sender, EventArgs e){
            if (id_empleado>0)
            {
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
        
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            bool flag = this.panel_menu.Visible;
            if (flag)
            {
                this.btn_salir.SetBounds(945,0,37,36);
                this.panel_menu.Visible = false;
            }
            else
            {
                this.panel_menu.Visible = true;
                this.btn_salir.SetBounds(745, 0, 37, 36);
            }
        }
        private void btn_home_Click(object sender, EventArgs e){
            this.Controls.Clear();
            this.InitializeComponent();
        }
      
        private void btn_cliente_Click(object sender, EventArgs e){

            this.Controls.Clear();
            this.InitializeComponent();
            FrmCliente usercontrol = new FrmCliente();
            this.Controls.Add(usercontrol);
        }

        private void btn_reservas_Click(object sender, EventArgs e){
            FrmReserva frmreserva = new FrmReserva();
            frmreserva.Show();
        }

        private void btn_servicio_Click(object sender, EventArgs e)
        {
           FrmServicio servicio= new FrmServicio();
           servicio.Show();
        }
    }
}
