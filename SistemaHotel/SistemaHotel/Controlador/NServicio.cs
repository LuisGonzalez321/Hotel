using SistemaHotel.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Controlador
{
    class NServicio
    {

        public static DataTable listaServicios()
        {
            return new DServicio().getServicios();
        }

        public static DataTable listaHR()
        {
            return new DServicio().getListaHRServicio();
        }

        public static void setCargoServicio(int ids, int idhr, double precio)
        {
            new DServicio().setCargoServicio(ids, idhr, precio);
        }
    }
}
