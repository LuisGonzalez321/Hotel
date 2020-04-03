using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Modelo {
    public class DUsuario {

        private string usuario;
        private string contraseña;
        private string rol;
        public int idEmpleado;

        public int IdEmpleado
        {
            get;set;
        }

        public string Usuario
        {
            get;set;
        }

        public string Contraseña
        {
            get;set;
        }

        public string Rol
        {
            get;set;
        }

        public DUsuario(){}

        public DUsuario(string usuario, string contraseña, string rol,int idEmpleado ){
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.rol = rol;
            this.idEmpleado = idEmpleado;
        }

        public DataTable Validar_acceso(string usuario, string contraseña) {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand("Validar_Acceso '"+usuario + "', '"+contraseña+"'", SqlCon);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            } catch (Exception ex) {
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

        public string Rol_Usuario (string usuario, string contraseña)
        {

            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            DataRow dr;
            try {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand("Rol_Usuario '"+usuario+"','"+contraseña+"'", SqlCon);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                if (DtResultado.Rows.Count > 0){
                    dr = DtResultado.Rows[0];
                    return dr["rol"].ToString();
                }
                return null;
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }

        public int get_idEmpleado(string usuario, string contraseña)
        {

            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            DataRow dr;
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand("Validar_Acceso '" + usuario + "', '" + contraseña + "'", SqlCon);

                //SqlParameter ParUsuario = new SqlParameter();
                //ParUsuario.ParameterName = "@primernombre";
                //ParUsuario.SqlDbType = SqlDbType.VarChar;
                //ParUsuario.Size = 60;
                //ParUsuario.Value = usuario;
                //SqlCmd.Parameters.Add(ParUsuario);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if (DtResultado.Rows.Count > 0)
                {
                    dr = DtResultado.Rows[0];
                    return Convert.ToInt32(dr["IdEmpleado"].ToString());
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
