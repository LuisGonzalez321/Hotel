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

    public partial class FrmMenu: Form
    {

        public int IdEmpleado;
        public DateTime FechEntrada;
        public DateTime FechaSalida;

        public FrmMenu (int IdEmpleado)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.IdEmpleado = IdEmpleado;
        }

        private void FormMenu_Load (object sender, EventArgs e)
        {
            if (IdEmpleado > 0) btn_empleado.Visible = false;
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc (ref Message m) {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr) 2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) {
                    m.Result = (IntPtr) 17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_menu_Click (object sender, EventArgs e)
        {
            bool flag = this.panel_menu.Visible;
            if (flag)
            {
                this.panel_menu.Visible = false;
                this.lbl_menu.Location = new System.Drawing.Point(64, 15);
                this.btn_menu.Location = new System.Drawing.Point(16, 1);
            }
            else
            {
                this.panel_menu.Visible = true;
                this.lbl_menu.Location = new System.Drawing.Point(255, 15);
                this.btn_menu.Location = new System.Drawing.Point(207, 1);
            }
        }
        private void btn_home_Click (object sender, EventArgs e) {
            panel_bottom.Controls.Clear();
        }

        private void btn_cliente_Click (object sender, EventArgs e)
        {
            panel_bottom.Controls.Clear();
            FrmCliente cliente = new FrmCliente();
            cliente.Dock = DockStyle.Fill;
            panel_bottom.Controls.Add(cliente);
        }

        public void btn_reservas_Click (object sender, EventArgs e)
        {
            panel_bottom.Controls.Clear();
            FrmReserva reserva = new FrmReserva(IdEmpleado);
            reserva.Dock = DockStyle.Fill;
            panel_bottom.Controls.Add(reserva);
        }

        private void btn_servicio_Click(object sender, EventArgs e)
        {
           new FrmServicio().Show();
        }

        private void btn_Habitación_Click (object sender, EventArgs e)
        {
            panel_bottom.Controls.Clear();
            FrmHabitación habitacion = new FrmHabitación(IdEmpleado);
            habitacion.padre = this;
            habitacion.Dock = DockStyle.Fill;
            panel_bottom.Controls.Add(habitacion);
        }

        private void btn_huesped_Click (object sender, EventArgs e)
        {
            panel_bottom.Controls.Clear();
            FrmHuesped huesped = new FrmHuesped();
            huesped.Dock = DockStyle.Fill;
            panel_bottom.Controls.Add(huesped);
        }

        private void btn_empleado_Click (object sender, EventArgs e)
        {
            panel_bottom.Controls.Clear();
            FrmEmpleado empleado = new FrmEmpleado();
            empleado.Dock = DockStyle.Fill;
            panel_bottom.Controls.Add(empleado);
        }
    }
}
