using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Vista
{
    public partial class FrmReserva: UserControl
    {
        public int IdEmpleado;
        public int IdCliente;
        public int no_habitacion;

        public int No_habitacion
        {
            get;set;
        }


        public FrmReserva (int IdEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado = IdEmpleado;
            this.tabla_cliente.DataSource = Controlador.NCliente.MostrarClientesParaReservas();
        }

        private void tabla_cliente_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            IdCliente = int.Parse(tabla_cliente.Rows [i].Cells [0].Value.ToString());
            tabla_reservas.DataSource = Controlador.NReserva.MostrarReservasCliente(IdCliente);
            MessageBox.Show("" + IdCliente);
        }

        private void btn_reservar_Click (object sender, EventArgs e)
        {
            string forma_pago = comboxFormaPago.SelectedItem.ToString();
            string divisa = comboxDivisa.SelectedItem.ToString();
            string estado = comboxEstado.SelectedItem.ToString();
            MessageBox.Show("" + forma_pago);
            Controlador.NReserva.insertarReserva(IdCliente, 1, forma_pago, divisa, estado);
            
        }
    }
}
