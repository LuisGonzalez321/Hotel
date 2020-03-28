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
    public class DReserva
    {

        private int idReserva;
        private int idCliente;
        private int idEmpleado;
        private DateTime fechaReserva;
        private string formadePago;
        private string divisa;
        private string stat;

        public DReserva(){}

        public DReserva(int idReserva, int idCliente, int idEmpleado, DateTime fechaReserva, string formadePago, string divisa, string stat)
        {
            this.idReserva = idReserva;
            this.idCliente = idCliente;
            this.idEmpleado = idEmpleado;
            this.fechaReserva = fechaReserva;
            this.formadePago = formadePago;
            this.divisa = divisa;
            this.stat = stat;
        }

        public int IdReserva{ get;set; }

        public int IdCliente
        {
            get;set;
        }

        public int IdEmpleado
        {
            get;set;
        }

        public DateTime FechaReserva
        {
            get;set;
        }

        public string FormadePago
        {
            get;set;
        }

        public string Divisa
        {
            get;set;
        }

        public string Stat
        {
            get;set;
        }

        public  bool insertarReserva(int idCliente, int idEmpleado, String formaPago, String divisa, String estado)
        {

            bool insercionSatifactoria = true;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter id = new SqlParameter();
                id.ParameterName = "@id_cliente";
                id.SqlDbType = SqlDbType.Int;
                id.Value = idCliente;
                SqlCmd.Parameters.Add(id);

                SqlParameter id2 = new SqlParameter();
                id2.ParameterName = "@id_empleado";
                id2.SqlDbType = SqlDbType.Int;
                id2.Value = idEmpleado;
                SqlCmd.Parameters.Add(id2);

                SqlParameter FormaPago = new SqlParameter();
                FormaPago.ParameterName = "@forma_pago";
                FormaPago.SqlDbType = SqlDbType.VarChar;
                FormaPago.Size = 15;
                FormaPago.Value = formaPago;
                SqlCmd.Parameters.Add(FormaPago);

                SqlParameter Divisa = new SqlParameter();
                Divisa.ParameterName = "@divisa";
                Divisa.SqlDbType = SqlDbType.VarChar;
                Divisa.Size = 8;
                Divisa.Value = divisa;
                SqlCmd.Parameters.Add(Divisa);

                SqlParameter Estado = new SqlParameter();
                Estado.ParameterName = "@estado";
                Estado.SqlDbType = SqlDbType.VarChar;
                Estado.Size = 15;
                Estado.Value = estado;
                SqlCmd.Parameters.Add(Estado);

                SqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                insercionSatifactoria = false;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return insercionSatifactoria;

        }

        public bool Insertar_habitaciónReserva(int no_habitación,int id_reserva,DateTime fecha_entrada,DateTime fecha_salida)
        {
            bool insercionSatifactoria = true;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_habitaciónReserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter id = new SqlParameter();
                id.ParameterName = "@no_habitación";
                id.SqlDbType = SqlDbType.Int;
                id.Value = no_habitación;
                SqlCmd.Parameters.Add(id);

                SqlParameter id2 = new SqlParameter();
                id2.ParameterName = "@id_reserva";
                id2.SqlDbType = SqlDbType.Int;
                id2.Value = id_reserva;
                SqlCmd.Parameters.Add(id2);

                SqlParameter fechaentrada = new SqlParameter();
                fechaentrada.ParameterName = "@fecha_entrada";
                fechaentrada.SqlDbType = SqlDbType.Date;
                //fechaentrada.Size = 15;
                fechaentrada.Value = fecha_entrada;
                SqlCmd.Parameters.Add(fechaentrada);

                SqlParameter fechasalida = new SqlParameter();
                fechasalida.ParameterName = "@fecha_salida";
                fechasalida.SqlDbType = SqlDbType.Date;
                // Divisa.Size = 8;
                fechasalida.Value = fecha_salida;
                SqlCmd.Parameters.Add(fechasalida);

                SqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                insercionSatifactoria = false;
            }
            finally
            {
                if (SqlCon.State ==  ConnectionState.Open) SqlCon.Close();
            }
            return insercionSatifactoria;
        }

        public int get_idReserva()
        {
            DataTable DtResultado = new DataTable("reserva");
            SqlConnection SqlCon = new SqlConnection();
            DataRow dr;
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "get_idReserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                if (DtResultado.Rows.Count > 0)
                {
                    dr = DtResultado.Rows[0];
                    return Convert.ToInt32(dr["id_reserva"].ToString());
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }


        public DataTable Mostrar_Huesped_Reservado(int idReserva)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Huesped_Reservado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlCmd.Parameters.Add(new SqlParameter("@IdReserva",idReserva));

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

        public  DataTable Busca_Reserva_Por_Fecha_Reserva(DateTime date)
        {
            DataTable DtResultado = new DataTable("Reserva");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busca_Reserva_Por_Fecha_de_Reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@fecha";
                fecha.SqlDbType = SqlDbType.Date;
                fecha.Value = date;
                SqlCmd.Parameters.Add(fecha);

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

        public  DataTable Busca_Reserva_Por_Fecha_Entrada(DateTime date)
        {
            DataTable DtResultado = new DataTable("Reserva");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busca_Reserva_Por_Fecha_de_Entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@fecha";
                fecha.SqlDbType = SqlDbType.Date;
                fecha.Value = date;
                SqlCmd.Parameters.Add(fecha);

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

        public DataTable buscaPorCliente(String nombre, string apellido)
        {
            DataTable DtResultado = new DataTable("Reserva");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busca_Reserva_Por_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter c = new SqlParameter();
                c.ParameterName = "@nombre";
                c.SqlDbType = SqlDbType.VarChar;
                c.Size = 15;
                c.Value = nombre;

                SqlParameter c2 = new SqlParameter();
                c2.ParameterName = "@apellido";
                c2.SqlDbType = SqlDbType.VarChar;
                c2.Size = 15;
                c2.Value = apellido;

                SqlCmd.Parameters.Add(c);
                SqlCmd.Parameters.Add(c2);

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


        public DataTable MostrarReservas ()
        {
            DataTable DtResultado = new DataTable("Reserva");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarReservas";
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

        public DataTable MostrarReservasCliente (int IdCliente)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                new SqlDataAdapter(new SqlCommand("MostrarReservasCliente " + IdCliente, SqlCon)).Fill(DtResultado);
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
