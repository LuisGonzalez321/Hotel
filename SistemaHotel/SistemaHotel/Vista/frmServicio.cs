using SistemaHotel.Controlador;
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
    public partial class frmServicio : Form
    {
        private int idhr;


        public frmServicio()
        {
            InitializeComponent();
            cargarCombo();
            cargarDataGrid();
        }

        private void cargarCombo()
        {
            for (int i = 0; i < NServicio.listaServicios().Rows.Count; i++)
            {
                this.comboBox1.Items.Add(NServicio.listaServicios().Rows[i][0]);
            }
        }

        private void cargarDataGrid()
        {
            this.dataGridView1.DataSource = NServicio.listaHR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ids = this.comboBox1.SelectedIndex;
            double precio = Convert.ToDouble(this.textBox1.Text);

            NServicio.setCargoServicio(ids, idhr, precio);
            this.Hide();
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
                    idhr = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                    
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}
