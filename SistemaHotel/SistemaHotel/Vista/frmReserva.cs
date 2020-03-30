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
        public  int IdEmpleado;
        public  int IdCliente;
        private int IdReserva;
        public  int no_habitacion;
        public  int Idhabitacion_reserva;
        public  FrmMenu padre;
        public  DateTime FechaEntrada;
        public  DateTime FechaSalida;

        public FrmReserva (int IdEmpleado, int no_habitacion, DateTime FechaEntrada, DateTime FechaSalida)
        {
            this.IdEmpleado = IdEmpleado;
            this.no_habitacion = no_habitacion;
            this.FechaEntrada = FechaEntrada;
            this.FechaSalida = FechaSalida;
            InitializeComponent();
        }

        private void FrmReserva_Load (object sender, EventArgs e)
        {
            this.tabla_cliente.DataSource = Controlador.NCliente.MostrarClientesParaReservas();
            CargarDescripcionLabel();
        }

        private void tabla_cliente_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            lista_huesped.Items.Clear();
            IdCliente = int.Parse(tabla_cliente.Rows [i].Cells [0].Value.ToString());
            tabla_reservas.DataSource = Controlador.NReserva.MostrarReservasCliente(IdCliente);
            CargarDescripcionLabel();
        }

        private void btn_reservar_Click (object sender, EventArgs e)
        {
            string forma_pago = comboxFormaPago.SelectedItem.ToString();
            string divisa = comboxDivisa.SelectedItem.ToString();
            string estado = comboxEstado.SelectedItem.ToString();
            Controlador.NReserva.insertarReserva(IdCliente, 1, forma_pago, divisa, estado);
        }

        private void btn_editar_Click (object sender, EventArgs e)
        {
            string name = "" + no_habitacion;
            string fecha1 = "" + FechaEntrada;
            string fecha2 = "" + FechaSalida;
            Idhabitacion_reserva = Controlador.NReserva.Insertar_habitaciónReserva(no_habitacion, IdReserva, FechaEntrada, FechaSalida);

            MessageBox.Show(name + "," + fecha1 + "," + fecha2 + "\n" + "IDDD");
        }

        private void btn_huesped_Click (object sender, EventArgs e)
        {
            Idhabitacion_reserva = Controlador.NReserva.Insertar_habitaciónReserva(no_habitacion, IdReserva, FechaEntrada, FechaSalida);
            padre.Idhabitacion_reserva = Idhabitacion_reserva;
            padre.btn_huesped_Click(sender, e);
        }

        private void tabla_reservas_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            lista_huesped.Items.Clear();
            IdReserva = Convert.ToInt32(tabla_reservas.CurrentRow.Cells ["id_reserva"].Value.ToString());
            foreach (string i in Controlador.NReserva.Mostrar_Huesped_Reservado(IdReserva))
            {
                lista_huesped.Items.Add(i);
            }
            CargarDescripcionLabel();
        }


        public void CargarDescripcionLabel ()
        {
            string value = "1 - Cliente: " + IdCliente + " \n" +
                           "2 - No habitacion : " + no_habitacion + "\n" +
                           "3 - Fecha de entrada :" + FechaEntrada + "\n" +
                           "4 - Fecha de salida :" + FechaSalida + "\n" +
                           "5 - No Reserva :" + IdReserva; 
            lbl_descripcion.Text = value;
        }

    }
}
