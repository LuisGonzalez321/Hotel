using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Modelo {
    class DCliente
    {
        // Variables de Clase
        private string p_nombre;
        private string s_nombre;
        private string p_apellido;
        private string s_apellido;
        private string direccion;
        private string telefono;
        private string correo;
        private string estado;

        public string P_nombre
        {
            get;set;
        }
        public string P_estado
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
        public string Telefono{
            get;set;
        }
        public string Correo
        {
            get;set;
        }
        public int Id_cliente
        {
            get;set;
        }
        public DCliente(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo, string estado)
        {
            this.p_nombre = p_nombre;
            this.s_nombre = s_nombre;
            this.p_apellido = p_apellido;
            this.s_apellido = s_apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.estado = estado;
        }
        public DCliente() { }

        public bool Insertar(DCliente cliente)
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
                SqlCmd.CommandText = "Insertar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primernombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 15;
                ParPrimerNombre.Value = cliente.P_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundonombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 15;
                ParSegundoNombre.Value = cliente.S_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerapellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 15;
                ParPrimerApellido.Value = cliente.P_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoapellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 15;
                ParSegundoApellido.Value = cliente.S_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 70;
                ParDirección.Value = cliente.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 25;
                ParCorreo.Value = cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                //Ejecutamos nuestro comando
                SqlCmd.ExecuteNonQuery();// == 1 ? "OK" : "NO se Ingreso el Registro";

                state = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                state= false;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return state;
        }

        //Método Editar
        public bool Editar(DCliente Cliente)
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
                SqlCmd.CommandText = "Editar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;//Se Puede ingredar una tabla una lista no solamente un procedimiento almacenado

                SqlParameter ParidCliente = new SqlParameter();
                ParidCliente.ParameterName = "@idcliente";
                ParidCliente.SqlDbType = SqlDbType.Int;
                //  ParidCliente.Size = 60;
                ParidCliente.Value = Cliente.Id_cliente;
                SqlCmd.Parameters.Add(ParidCliente);

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primernombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = Cliente.P_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundonombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = Cliente.S_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerapellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = Cliente.P_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoapellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = Cliente.S_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = Cliente.telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 60;
                ParCorreo.Value = Cliente.Correo;
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


        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                new SqlDataAdapter(new SqlCommand("Mostrar_Clientes", SqlCon)).Fill(DtResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;

        }
        public DataTable BuscarAsegurado(string dato)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Registro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 20;
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
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;

        }


        public bool habilitar (int Id_cliente)
        {
            bool stat;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand("habilitado " + Id_cliente , SqlCon);

                //Ejecutamos nuestro comando
                SqlCmd.ExecuteNonQuery();
                stat = true;
            }
            catch (Exception on)
            {
                stat = false;
                MessageBox.Show(on.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return stat;
        }

        public int get_idCliente()
        {

            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            DataRow dr;
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand("get_idCliente", SqlCon);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                if (DtResultado.Rows.Count > 0)
                {
                    dr = DtResultado.Rows [0];
                    return Convert.ToInt32(dr ["id_cliente"].ToString());
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


        public DataTable MostrarClientesParaReservas ()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                new SqlDataAdapter(new SqlCommand("MostrarClientesReservas", SqlCon)).Fill(DtResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return DtResultado;
        }


    }
}
