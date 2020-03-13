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
    class DServicio
    {
        public DataTable getServicios()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ListaServicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable getListaHRServicio()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CONSULTAR_LISTA_HR_SERVICIO";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                DtResultado = null;
            }
            return DtResultado;
        }

        public void setCargoServicio(int ids, int idhr, double precio)
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busca_Reserva_Por_Fecha_Reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter();
                p1.ParameterName = "@IDHR";
                p1.SqlDbType = SqlDbType.Int;
                p1.Value = idhr;
                SqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter();
                p2.ParameterName = "@IDS";
                p2.SqlDbType = SqlDbType.Int;
                p2.Value = ids;
                SqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter();
                p3.ParameterName = "@PRECIO";
                p3.SqlDbType = SqlDbType.Money;
                p3.Value = precio;
                SqlCmd.Parameters.Add(p3);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);

                MessageBox.Show("Ingresado Correctamente");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

    }
}
