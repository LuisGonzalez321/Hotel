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
    public class DHuesped
    {
        public int id_huesped;
        private string p_nom;
        private string s_nom;
        private string p_apell;
        private string s_apell;
        private string direccion;
        private string telefono;
        private string nacionalidad;
        private string correo;

        public int Id_huesped
        {
            get { return id_huesped; }
            set { id_huesped = value; }
        }

        public string P_nom
        {
            get { return p_nom; }
            set { p_nom = value; }
        }

        public string S_nom
        {
            get
            {
                return s_nom;
            }

            set
            {
                s_nom = value;
            }
        }

        public string P_apell
        {
            get
            {
                return p_apell;
            }

            set
            {
                p_apell = value;
            }
        }

        public string S_apell
        {
            get
            {
                return s_apell;
            }

            set
            {
                s_apell = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                nacionalidad = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public DHuesped(int id_huesped, string p_nom, string s_nom, string p_apell, string s_apell, string direccion, string telefono, string nacionalidad, string correo)
        {
            this.id_huesped = id_huesped;
            this.p_nom = p_nom;
            this.s_nom = s_nom;
            this.p_apell = p_apell;
            this.s_apell = s_apell;
            this.direccion = direccion;
            this.telefono = telefono;
            this.nacionalidad = nacionalidad;
            this.correo = correo;
        }



        public DHuesped() { }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("huesped");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Huespedes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

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

        public DataTable MáximoHuespedPorHabitación(int id)
        {
            DataTable DtResultado = new DataTable("huesped");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Máximos_Huesped_Por_Habitación";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ide = new SqlParameter();
                ide.ParameterName = "@idHabReserva";
                ide.SqlDbType = SqlDbType.Int;
                ide.Value = id;
                SqlCmd.Parameters.Add(ide);

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

        public bool Insertar_Huesped(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string nacionalidad, string correo, int IdHabitacionReserva)
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
                SqlCmd.CommandText = "Insertar_Huesped";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@PrimerNombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 50;
                ParPrimerNombre.Value =p_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@SegundoNombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 50;
                ParSegundoNombre.Value =s_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@PrimerApellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 50;
                ParPrimerApellido.Value = p_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@SegundoApellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 50;
                ParSegundoApellido.Value =s_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@Dirección";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = direccion;
                SqlCmd.Parameters.Add(ParDirección);


                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = telefono ;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParNacionalidad= new SqlParameter();
                ParNacionalidad.ParameterName = "@Nacionalidad";
                ParNacionalidad.SqlDbType = SqlDbType.VarChar;
                ParNacionalidad.Size = 50;
                ParNacionalidad.Value = nacionalidad;
                SqlCmd.Parameters.Add(ParNacionalidad) ;

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 100;
                ParCorreo.Value = correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParHabReserva = new SqlParameter();
                ParHabReserva.ParameterName = "@Idhabitacion_reserva";
                ParHabReserva.SqlDbType = SqlDbType.Int;
                ParHabReserva.Value = IdHabitacionReserva;
                SqlCmd.Parameters.Add(ParHabReserva);

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


        public int get_idHuesped()
        {

            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataRow dr;
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "select top(1) id_huesped from huesped order by id_huesped desc";
                SqlCmd.CommandType = CommandType.Text;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                if (DtResultado.Rows.Count > 0){
                    dr = DtResultado.Rows[0];
                    int resultado = Convert.ToInt32(dr["id_cliente"].ToString()) + 1;
                    return resultado;
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

    }
}