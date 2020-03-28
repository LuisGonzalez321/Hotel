using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Modelo {
    class DHabitación
    {
        private int no_habitacion;
        private int cod_tipo;
        private string descripción;
        private int capacidad;
        private string estado;
        private string nom_tipo;
        private float precio;

        public DHabitación(int no_habitación)
        {
            this.no_habitacion = no_habitación;
        }

        public DHabitación(int no_habitacion, int cod_tipo, string descripción, int capacidad, string estado, string nom_tipo, float precio) {
            this.no_habitacion = no_habitacion;
            this.cod_tipo = cod_tipo;
            this.descripción = descripción;
            this.capacidad = capacidad;
            this.estado = estado;
            this.nom_tipo = nom_tipo;
            this.precio = precio;
        }

        public DHabitación(){}

        public int No_habitacion
        {
            get;set;
        }
        public int Cod_tipo
        {
            get;set;
        }
        public string Descripción
        {
            get;set;
        }
        public int Cap
        {
            get;set;
        }

        public string Estado
        {
            get;set;
        }
        public string Nom_tipo
        {
            get;set;
        }

        public float Precio
        {
            get;set;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                new SqlDataAdapter(new SqlCommand("Mostrar_Habitaciones", SqlCon)).Fill(DtResultado);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        public DataTable mostrar_idHabitacion()
        {
            //conectar con la base de datos para extraer el hater segun el manufacturing order que le corresponda
            SqlConnection SqlCon = new SqlConnection();
            DataTable dt = new DataTable();
            try {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_idHabitacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);

                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return dt;
            }
            
        }

      
        public DataTable Disponibilidad_Habitación(int IdHabitacion,DateTime fechaEntrada,DateTime fechaSalida) {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Disponibilidad_Habitación";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@IdHabitación";
                ParPrimerNombre.SqlDbType = SqlDbType.Int;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = IdHabitacion;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@Fechaentrada";
                ParSegundoNombre.SqlDbType = SqlDbType.Date;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = fechaEntrada;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@Fechasalida";
                ParPrimerApellido.SqlDbType = SqlDbType.Date;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = fechaSalida;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable Estado_Habitacion(DateTime fechaEntrada, DateTime fechaSalida) {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Estado_Habitacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@Fechaentrada";
                ParSegundoNombre.SqlDbType = SqlDbType.Date;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = fechaEntrada;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@Fechasalida";
                ParPrimerApellido.SqlDbType = SqlDbType.Date;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = fechaSalida;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }
            return DtResultado;
        }


    }
}
