using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Modelo
{
    class DEmpleado
    {

        private int id_empleado;
        private String p_nombre;
        private String s_nombre;
        private String p_apellido;
        private String s_apellido;
        private String direccion;
        private String telefono;
        private String correo;
        private String estado;



        public string P_nombre
        {
            get;set;
        }
        public string S_nombre
        {
            get;set;
        }
        public string P_apellido
        {
            get;set;
        }
        public string S_apellido
        {
            get;set;
        }
        public string Direccion
        {
            get;set;
        }
        public string Telefono
        {
            get;set;
        }
        public string Correo{
            get;set;
        }

        public string Estado
        {
            get;set;
        }

        public int Id_empleado
        {
            get;set;
        }

        public DEmpleado(int id_empleado, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo, string estado)
        {
            this.id_empleado = id_empleado;
            this.P_nombre = p_nombre;
            this.S_nombre = s_nombre;
            this.P_apellido = p_apellido;
            this.S_apellido = s_apellido;
            this.Direccion = direccion;
            this.telefono = telefono;
            this.Correo = correo;
            this.Estado = estado;
        }

        public DEmpleado() { }

        public System.Data.DataTable Mostrar_empleados()
        {
            DataTable DtResultado = new DataTable();
            System.Data.SqlClient.SqlConnection SqlCon = new System.Data.SqlClient.SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();

                new SqlDataAdapter(new SqlCommand("Mostrar_Empleado", SqlCon)).Fill(DtResultado);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return DtResultado;
        }

        public bool Insertar(DEmpleado empleado)
        {
            bool state;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primernombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = empleado.P_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundonombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = empleado.S_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerapellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = empleado.P_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoapellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = empleado.S_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = empleado.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 60;
                ParCorreo.Value = empleado.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                //Ejecutamos nuestro comando
                SqlCmd.ExecuteNonQuery();// == 1 ? "OK" : "NO se Ingreso el Registro";

                state = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                state = false;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return state;
        }

        //Método Editar
        public bool Editar(DEmpleado empleado)
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Editar_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;//Se Puede ingredar una tabla una lista no solamente un procedimiento almacenado

                SqlParameter ParidCliente = new SqlParameter();
                ParidCliente.ParameterName = "@idcliente";
                ParidCliente.SqlDbType = SqlDbType.Int;
                //  ParidCliente.Size = 60;
                ParidCliente.Value = empleado.id_empleado;
                SqlCmd.Parameters.Add(ParidCliente);

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primernombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = empleado.P_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundonombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = empleado.S_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerapellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = empleado.P_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoapellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = empleado.S_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = empleado.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 60;
                ParCorreo.Value = empleado.Correo;
                SqlCmd.Parameters.Add(ParCorreo);
                //    //Ejecutamos nuestro comando
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable BuscarAsegurado(string dato)
        {
            DataTable DtResultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = dato;
                SqlCmd.Parameters.Add(ParDato);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }
            return DtResultado;

        }


    }
}
