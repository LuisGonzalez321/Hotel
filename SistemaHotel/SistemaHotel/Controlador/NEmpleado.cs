using SistemaHotel.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Controlador
{
    class NEmpleado
    {
        public static bool Insertar(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.P_nombre = p_nombre;
            Obj.S_nombre = s_nombre;
            Obj.P_apellido = p_apellido;
            Obj.S_apellido = s_apellido;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            return Obj.Insertar(Obj);
        }
        //Método Editar que llama al método Editar de la clase DEmpleado
        //de la CapaDatos
        public static bool Editar(int idempleado, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Id_empleado = idempleado;
            Obj.P_nombre = p_nombre;
            Obj.S_nombre = s_nombre;
            Obj.P_apellido = p_apellido;
            Obj.S_apellido = s_apellido;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            return Obj.Editar(Obj);
        }

        public static DataTable BuscarAsegurado(string dato)
        {
            return new DEmpleado().BuscarAsegurado(dato);
        }

        public static DataTable Mostrar_Empleados()
        {
            return new DEmpleado().Mostrar_empleados();
        }

    }
}
