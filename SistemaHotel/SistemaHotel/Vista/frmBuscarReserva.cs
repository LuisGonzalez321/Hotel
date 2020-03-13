using SistemaHotel.Controlador;
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

namespace SistemaHotel.Vista
{
    public partial class FrmBuscarReserva : Form
    {
        private int tipo_fecha_buscar = 0;

        public FrmBuscarReserva()
        {
            InitializeComponent();
            this.dateTimePicker2.Enabled = false;
            this.groupBox2.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //BUSCAR POR FECHA
        private void button1_Click(object sender, EventArgs e)
        {
            if (tipo_fecha_buscar == 0)
            {
                //se busca por fecha de reserva
                DateTime d1 = dateTimePicker1.Value;
                this.dataGridView1.DataSource = NReserva.reservaPorFechaDeReserva(d1);
            }
            else
            {
                //se busca por fecha de llegada o entrada
                DateTime d2 = dateTimePicker2.Value;
                this.dataGridView1.DataSource = NReserva.reservaPorFechaDeEntrada(d2);
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = false;
                this.tipo_fecha_buscar = 0;
            }
            else
            {
                this.dateTimePicker1.Enabled = false;
                this.dateTimePicker2.Enabled = true;
                this.tipo_fecha_buscar = 1;

            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.groupBox1.Enabled = true;
                this.groupBox2.Enabled = false;
            }
            else
            {
                this.groupBox1.Enabled = false;
                this.groupBox2.Enabled = true;

            }
        }

        //BUSCAR POR NOMBRE DE CLIENTE
        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = this.textBox1.Text;
            string apellido = this.textBox2.Text;
            this.dataGridView1.DataSource = NReserva.reservaPorCliente(nombre, apellido);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    int c = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                    //new frmHuesped(c).Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }

            }
        }
    }
}
