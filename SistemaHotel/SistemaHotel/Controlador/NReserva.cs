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
    class NReserva
    {
        public static DataTable MostrarReservas(){
            return new DReserva().MostrarReservas();
        }


        public static bool insertarReserva(int idCliente, int idEmpleado, string formaPago, string divisa, string estado)
        {
          return new DReserva().insertarReserva(idCliente,idEmpleado,formaPago,divisa,estado);
        }

        public static int Insertar_habitaciónReserva(int no_habitación, int id_reserva, DateTime fecha_entrada, DateTime fecha_salida)
        {
            return new DReserva().Insertar_habitaciónReserva(no_habitación,id_reserva,fecha_entrada,fecha_salida);
        }

        public static int get_idReserva()
        {
            return new DReserva().get_idReserva();
        }

        public static List<string> Mostrar_Huesped_Reservado (int idReserva)
        {
            return new DReserva().Mostrar_Huesped_Reservado(idReserva);
        }

        //---------------------------------------------------------------//

        public static DataTable reservaPorFechaDeReserva(DateTime date)
        {
            return new DReserva().Busca_Reserva_Por_Fecha_Reserva(date);
        }

        public static DataTable reservaPorFechaDeEntrada(DateTime date)
        {
            return new DReserva().Busca_Reserva_Por_Fecha_Entrada(date);
        }

        public static DataTable reservaPorCliente(String nombre, string apellido)
        {
            return new DReserva().buscaPorCliente(nombre, apellido);
        }

        public static DataTable MostrarReservasCliente (int IdCliente)
        {
            return new DReserva().MostrarReservasCliente(IdCliente);
        }

    }
}
