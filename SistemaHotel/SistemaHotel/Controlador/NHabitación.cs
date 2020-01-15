using SistemaHotel.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Controlador {
    class NHabitación {

        public static DataTable Mostrar() {
            return new DHabitación().Mostrar();
        }

        public static DataTable mostrar_idHabitacion() {
            return new DHabitación().mostrar_idHabitacion();
        }

        public static DataTable Disponibilidad_Habitación(int IdHabitacion, DateTime fechaEntrada, DateTime fechaSalida) {
            return new DHabitación().Disponibilidad_Habitación(IdHabitacion,fechaEntrada,fechaSalida);
        }

        public static DataTable Estado_Habitacion(DateTime fechaEntrada, DateTime fechaSalida) {
            return new DHabitación().Estado_Habitacion(fechaEntrada,fechaSalida);
        }
    }
}
