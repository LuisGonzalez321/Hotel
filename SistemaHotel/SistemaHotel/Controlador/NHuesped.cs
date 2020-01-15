using SistemaHotel.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Controlador
{
    class NHuesped
    {

        public static DataTable Mostrar()
        {
            return new DHuesped().Mostrar();
        }

        public static DataTable MáximoHuespedPorHabitaciones(int id)
        {
            return new DHuesped().MáximoHuespedPorHabitación(id);
        }

        public static bool Insertar_Huesped(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string nacionalidad ,string correo)
        {
            return new DHuesped().Insertar_Huesped(p_nombre,s_nombre,p_apellido,s_apellido,direccion,telefono,nacionalidad,correo);
        }
    }
}
