using SistemaHotel.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Controlador {
    class NUsuario {

        public static DataTable Validar_acceso(string usuario, string contraseña) {
            return new DUsuario().Validar_acceso(usuario, contraseña);
        }

        public static string Rol_Usuario(string usuario, string contraseña)
        {
            return new DUsuario().Rol_Usuario(usuario,contraseña);
        }

        public static int Mostrar(string usuario, string contraseña)
        {
           return new DUsuario().get_idEmpleado(usuario,contraseña);
        }

    }
}
