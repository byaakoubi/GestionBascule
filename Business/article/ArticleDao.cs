using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBascule.Business.commun;

namespace GestionBascule.Business.article
{
    public class ArticleDao
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num_article"></param>
        /// <param name="stock"></param>
        /// <returns></returns>
        public static int setInitialStock(string num_article, int stock)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();

            SqlCommand cmd_stock = new SqlCommand();
            cmd_stock.CommandText = "IF EXISTS(SELECT * FROM [SOMEPA$Stock Initial] WHERE [N° Article] =@N_Article) " +
            " UPDATE [SOMEPA$Stock Initial] SET [Stock Initial]=@Stock WHERE  [N° Article] =@N_Article ELSE " +
            " INSERT INTO [SOMEPA$Stock Initial] ([N° Article], [Stock Initial]) VALUES (@N_Article, @Stock )";

            cmd_stock.Parameters.Add("@N_Article", SqlDbType.VarChar).Value = num_article;
            cmd_stock.Parameters.Add("@Stock", SqlDbType.Int).Value = stock;

            cmd_stock.Connection = oSQLConn;

            cmd_stock.Transaction = oSQLTransaction;

            try
            {
                cmd_stock.ExecuteNonQuery();
                oSQLTransaction.Commit();
                oSQLConn.Close();
                return 0;
            }
            catch (Exception exep)
            {
                System.Windows.Forms.MessageBox.Show(exep.Message);
                oSQLTransaction.Rollback();
                oSQLConn.Close();
                return 1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num_article"></param>
        /// <param name="ancienstock"></param>
        /// <param name="nouveaustock"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static int updateStock(string num_article, int ancienstock, int nouveaustock, string comment)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();

            SqlCommand cmd_stock = new SqlCommand();
            cmd_stock.CommandText = "INSERT INTO [SOMEPA$Stock Op] ([N° Article],[Ancien Stock],[Nouveau Stock],[Comment]) " + 
            "VALUES (@N_Article,@An_Stock,@Nv_Stock,@Comment )";

            cmd_stock.Parameters.Add("@N_Article", SqlDbType.VarChar).Value = num_article;
            cmd_stock.Parameters.Add("@An_Stock", SqlDbType.Int).Value = ancienstock;
            cmd_stock.Parameters.Add("@Nv_Stock", SqlDbType.Int).Value = nouveaustock;
            cmd_stock.Parameters.Add("@Comment", SqlDbType.VarChar).Value = comment;

            cmd_stock.Connection = oSQLConn;

            cmd_stock.Transaction = oSQLTransaction;

            try
            {
                cmd_stock.ExecuteNonQuery();
                oSQLTransaction.Commit();
                oSQLConn.Close();
                return 0;
            }
            catch (Exception exep)
            {
                System.Windows.Forms.MessageBox.Show(exep.Message);
                oSQLTransaction.Rollback();
                oSQLConn.Close();
                return 1;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entry_n"></param>
        /// <returns></returns>
        public static int deleteUpStock(int entry_n)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();

            SqlCommand cmd_stock = new SqlCommand();
            cmd_stock.CommandText = "DELETE FROM [SOMEPA$Stock Op] WHERE [Entry N°] = @entry_n";

            cmd_stock.Parameters.Add("@entry_n", SqlDbType.Int).Value = entry_n;

            cmd_stock.Connection = oSQLConn;

            cmd_stock.Transaction = oSQLTransaction;

            try
            {
                cmd_stock.ExecuteNonQuery();
                oSQLTransaction.Commit();
                oSQLConn.Close();
                return 0;
            }
            catch (Exception exep)
            {
                System.Windows.Forms.MessageBox.Show(exep.Message);
                oSQLTransaction.Rollback();
                oSQLConn.Close();
                return 1;
            }
        }
    }
}
