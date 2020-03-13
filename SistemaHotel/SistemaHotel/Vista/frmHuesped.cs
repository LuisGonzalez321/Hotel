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
using SistemaHotel.Modelo;

namespace SistemaHotel.Vista {
    public partial class FrmHuesped : UserControl {
        public FrmHuesped() {

            InitializeComponent();
        }

        private void frmHuesped_Load(object sender, EventArgs e) {
            this.tabla_huesped.DataSource = Controlador.NHuesped.Mostrar();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool flag = NHuesped.Insertar_Huesped(txt_PrimerNombre.Text,txt_SegundoNombre.Text,txt_PrimerApellido.Text,txt_SegundoApellido.Text, txt_Dirección.Text,"90909090", txt_nacionalidad.Text, txt_Correo.Text);
            if (flag){
                MessageBox.Show("Ingresado exitosa mente");
                this.Hide();
            }
            else {
                MessageBox.Show("Error");
            }
        }
    }
}
