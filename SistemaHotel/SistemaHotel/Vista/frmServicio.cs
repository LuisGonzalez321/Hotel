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
    public partial class FrmServicio : Form
    {
        private int idhr;


        public FrmServicio()
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
            if (this.textBox1.Text.Length > 0)
            {
                int ids = this.comboBox1.SelectedIndex;
                double precio = Convert.ToDouble(this.textBox1.Text);

                NServicio.setCargoServicio(ids, idhr, precio);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Revise los datos de entrada","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void textBox1_KeyPress (object sender, KeyPressEventArgs e)
        {
            Tools.soloNumsDecimal(e);
        }

        private void btn_cancelar_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar?", "Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
