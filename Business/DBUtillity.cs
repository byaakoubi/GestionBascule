using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GestionBascule.Business.commun;

namespace GestionBascule.Business
{
    class DBUtillity
    {
       
       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public static void delete_entreCMV(int id)
        {
            // Connexion a la base 
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "DELETE from  ENTREESTOCKCMV  WHERE  id = @id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Connection = oSQLConn;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exep) { System.Windows.Forms.MessageBox.Show(exep.Message); }
            oSQLConn.Close();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int last_lot()
        {
            // Connexion a la base 
            int lastlot = 0;
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "Select max (nlot) as nlot FROM CONSOMMATION";
            cmd.Connection = oSQLConn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    lastlot = int.Parse(reader["nlot"].ToString());
                }
                catch { }
            }

            oSQLConn.Close();
            return lastlot;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int last_lot_cmv()
        {
            // Connexion a la base 
            int lastlot = 0;
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "Select max (nlot) as nlot FROM CONSOMMATIONCMV";
            cmd.Connection = oSQLConn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    lastlot = int.Parse(reader["nlot"].ToString());
                }
                catch { }
            }

            oSQLConn.Close();
            return lastlot;
        }




    }
}
