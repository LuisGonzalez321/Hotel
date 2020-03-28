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
    public partial class FrmHabitación: UserControl
    {

        int id_empleado;
        public FrmMenu padre;

        public FrmMenu Padre
        {
            get;set;
        }

        public FrmHabitación (int id_empleado)
        {
            InitializeComponent();
            this.id_empleado = id_empleado;
            this.tabla_habitación.DataSource = Controlador.NHabitación.Mostrar();
        }

        private void combox_hab_onItemSelected (object sender, EventArgs e)
        {
            int i = combox_hab.selectedIndex;
            switch (i)
            {
                case 1:
                    {
                        this.image_hab.Image = global::SistemaHotel.Properties.Resources.habitación_básica;
                        break;
                    }
                case 2:
                    {
                        this.image_hab.Image = global::SistemaHotel.Properties.Resources.habitació_Ejecutiva;
                        break;
                    }
                case 3:
                    {
                        this.image_hab.Image = global::SistemaHotel.Properties.Resources.habitación_presidencial;
                        break;
                    }
            }
        }

        private void btn_huesped_Click (object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void switch_habilitar_Click (object sender, EventArgs e)
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

        private void btn_reservar_Click (object sender, EventArgs e)
        {
            padre.btn_reservas_Click(sender, e);
            //int no_habitacion = int.Parse( combox_hab.selectedValue );
        }

        private void btn_buscar_Click (object sender, EventArgs e)
        {
            DateTime fechaEntrada = this.date_fechaEntrada.Value;
            DateTime fechaSalida = this.date_FechaSalida.Value;
            if (switch_habilitar.Value == true)
            {
                int id = Convert.ToInt32(combox_idHab.selectedValue);
                tabla_habitación.DataSource = Controlador.NHabitación.Disponibilidad_Habitación(id, fechaEntrada, fechaSalida);
            }
            else
            {
                tabla_habitación.DataSource = Controlador.NHabitación.Estado_Habitacion(fechaEntrada, fechaSalida);
            }
         }
    }
}
