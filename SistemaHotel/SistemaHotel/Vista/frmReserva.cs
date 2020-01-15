using SistemaHotel.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Vista
{
    public partial class frmReserva : Form
    {
        public int id_empleado;
        public int no_habitación;
        public int id_cliente;
        public DateTime fechaEntrada;
        public DateTime fechaSalida;

        public frmReserva(int id_cliente, int id_empleado,int no_habitación, DateTime fechaEntrada,DateTime fechaSalida){
            InitializeComponent();
            this.id_cliente = id_cliente;
            this.id_empleado = id_empleado;
            this.no_habitación = no_habitación;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
           // MessageBox.Show("-" + fechaEntrada+"-"+fechaSalida+"-"+id_cliente+"-"+id_empleado+"-"+no_habitación);
        }


        public frmReserva(){
            InitializeComponent();
        }

        private void ejemplo_Load(object sender, EventArgs e)
        {
            data_cliente.DataSource = NCliente.Mostrar();
            data_reserva.DataSource = NReserva.MostrarReservas();
            this.lista_huesped.DataSource = getData();
        }

        public void Activar(){
            this.btn_addhuesped.Enabled = true;
            this.lista_huesped.Enabled = true;
            this.btn_editar.Enabled = true;
            this.data_reserva.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-" + fechaEntrada + "-" + fechaSalida + "-" + id_cliente + "-" + id_empleado + "-" + no_habitación);
            bool flag = NReserva.insertarReserva(id_cliente, id_empleado, combox_pago.selectedValue, combox_divisa.selectedValue,combox_estado.selectedValue);
            bool flag2 = NReserva.Insertar_habitaciónReserva(no_habitación,NReserva.get_idReserva(),fechaEntrada,fechaSalida);
            if (flag && flag2){
                data_reserva.DataSource = NReserva.MostrarReservas();
                MessageBox.Show("Exito");
                this.Activar();
                
            }else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(id_empleado);
            menu.tab.Visible = true;
            this.Hide();
        }

        private void data_cliente_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FORMHuesped huesped = new FORMHuesped();
            huesped.Show();
           this.lista_huesped.Items.AddRange(new object[] { "1" });


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            FORMHuesped fm = new FORMHuesped();
            fm.Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        public DataTable getData() {
            DataTable dtclientes = new DataTable();
            string Cn = Modelo.Conexión.Cn;
            using (SqlConnection con = new SqlConnection(Cn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("Mostrar_Huesped_Reservado", con))
                {

                    con.Open();
                    adapter.Fill(dtclientes);   
                }
            }
            return dtclientes;
        }

    }
}
