using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBascule.Business.commun;
using GestionBascule.Business.pesage;

namespace GestionBascule.Business
{
    public class PesageLineDao
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_p"></param>
        /// <returns></returns>
        public static int savePesageLine(PesageLineModel _p)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();

            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO [SOMEPA$Pesage Line] "
            + " ([Header Entry N°],[N° Réception],[N° Fournisseur],[N° Client],[Nom],"
            + " [N° Article 1],[Désignation Article 1],[Qte Article 1],[N° Article 2],[Désignation Article 2],[Qte Article 2],[N° Article 3] ,[Désignation Article 3],[Qte Article 3],"
            + " [N° Article 4] ,[Désignation Article 4],[Qte Article 4],[N° Article 5],[Désignation Article 5],[Qte Article 5], [Etat])"
            + " VALUES (@Header_entry_n,@N_Reception,@N_Fournisseur,@N_Client,@Nom, "
            + " @N_Article_1,@Desig_Article_1,@qte_Article_1,@N_Article_2,@Desig_Article_2,@qte_Article_2,@N_Article_3,@Desig_Article_3,@qte_Article_3, "
            + " @N_Article_4,@Desig_Article_4,@qte_Article_4,@N_Article_5,@Desig_Article_5,@qte_Article_5,0)";


            cmd.Parameters.Add("@Header_entry_n", SqlDbType.Int).Value = _p.header_entry_n;
            cmd.Parameters.Add("@N_Reception", SqlDbType.VarChar).Value = _p.n_reception;
            cmd.Parameters.Add("@N_Fournisseur", SqlDbType.VarChar).Value = _p.n_fournisseur;
            cmd.Parameters.Add("@N_Client", SqlDbType.VarChar).Value = _p.n_client;
            cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = _p.nom;

            cmd.Parameters.Add("@n_Article_1", SqlDbType.VarChar).Value = _p.num_article_1;
            cmd.Parameters.Add("@desig_article_1", SqlDbType.VarChar).Value = _p.desig_article_1;
            cmd.Parameters.Add("@qte_article_1", SqlDbType.Decimal).Value = _p.qte_article_1;

            cmd.Parameters.Add("@n_Article_2", SqlDbType.VarChar).Value = _p.num_article_2;
            cmd.Parameters.Add("@desig_article_2", SqlDbType.VarChar).Value = _p.desig_article_2;
            cmd.Parameters.Add("@qte_article_2", SqlDbType.Decimal).Value = _p.qte_article_2;

            cmd.Parameters.Add("@n_Article_3", SqlDbType.VarChar).Value = _p.num_article_3;
            cmd.Parameters.Add("@desig_article_3", SqlDbType.VarChar).Value = _p.desig_article_3;
            cmd.Parameters.Add("@qte_article_3", SqlDbType.Decimal).Value = _p.qte_article_3;

            cmd.Parameters.Add("@n_Article_4", SqlDbType.VarChar).Value = _p.num_article_4;
            cmd.Parameters.Add("@desig_article_4", SqlDbType.VarChar).Value = _p.desig_article_4;
            cmd.Parameters.Add("@qte_article_4", SqlDbType.Decimal).Value = _p.qte_article_4;

            cmd.Parameters.Add("@n_Article_5", SqlDbType.VarChar).Value = _p.num_article_5;
            cmd.Parameters.Add("@desig_article_5", SqlDbType.VarChar).Value = _p.desig_article_5;
            cmd.Parameters.Add("@qte_article_5", SqlDbType.Decimal).Value = _p.qte_article_5;

            cmd.Connection = oSQLConn;

            cmd.Transaction = oSQLTransaction;

            try
            {
                cmd.ExecuteNonQuery();
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
        public static PesageLineModel getPesageLine(int entry_n)
        {
            PesageLineModel _p = new PesageLineModel();
            _p.entry_n = entry_n;
            SqlCommand cmd_op = new SqlCommand();
            cmd_op.CommandText = "SELECT * from  [SOMEPA$Pesage Line]  WHERE  [Entry N°] = @entry_n ";
            cmd_op.Parameters.Add("@entry_n", SqlDbType.Int).Value = entry_n;
            /// Connexion a la base 
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            cmd_op.Connection = oSQLConn;
            SqlDataReader reader = cmd_op.ExecuteReader();
            if (reader.Read())
            {
                _p.n_reception = reader["N° Réception"].ToString();
                _p.header_entry_n = int.Parse(reader["Header Entry N°"].ToString());
                _p.n_fournisseur = reader["N° Fournisseur"].ToString();
                _p.n_client = reader["N° Client"].ToString();
                _p.nom = reader["Nom"].ToString();

                _p.num_article_1 = reader["N° Article 1"].ToString();
                _p.desig_article_1 = reader["Désignation Article 1"].ToString();
                _p.qte_article_1 = double.Parse(reader["Qte Article 1"].ToString());

                _p.num_article_2 = reader["N° Article 2"].ToString();
                _p.desig_article_2 = reader["Désignation Article 2"].ToString();
                _p.qte_article_2 = double.Parse(reader["Qte Article 2"].ToString());

                _p.num_article_3 = reader["N° Article 3"].ToString();
                _p.desig_article_3 = reader["Désignation Article 3"].ToString();
                _p.qte_article_3 = double.Parse(reader["Qte Article 3"].ToString());

                _p.num_article_4 = reader["N° Article 4"].ToString();
                _p.desig_article_4 = reader["Désignation Article 4"].ToString();
                _p.qte_article_4 = double.Parse(reader["Qte Article 4"].ToString());

                _p.num_article_5 = reader["N° Article 5"].ToString();
                _p.desig_article_5 = reader["Désignation Article 5"].ToString();
                _p.qte_article_5 = double.Parse(reader["Qte Article 5"].ToString());
                _p.etat = int.Parse(reader["Etat"].ToString());
            }
            reader.Close();
            return _p;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_p"></param>
        /// <returns></returns>
        public static int updatePesageLine(PesageLineModel _p)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();

            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "UPDATE [SOMEPA$Pesage Line] SET [Header Entry N°]=@Header_entry_n, [N° Réception]=@N_Reception,[N° Fournisseur]=@N_Fournisseur,[N° Client]=@N_Client,Nom=@Nom,"
                + "[N° Article 1]=@N_Article_1,[Désignation Article 1]=@Desig_Article_1,[Qte Article 1]=@qte_article_1,"
                + "[N° Article 2]=@N_Article_2,[Désignation Article 2]=@Desig_Article_2,[Qte Article 2]=@qte_article_2,"
                + "[N° Article 3]=@N_Article_3,[Désignation Article 3]=@Desig_Article_3,[Qte Article 3]=@qte_article_3,"
                + "[N° Article 4]=@N_Article_4,[Désignation Article 4]=@Desig_Article_4,[Qte Article 4]=@qte_article_4,"
                + "[N° Article 5]=@N_Article_5,[Désignation Article 5]=@Desig_Article_5,[Qte Article 5]=@qte_article_5"
                + " WHERE [Entry N°] = @Entry_n ";

            cmd.Parameters.Add("@Entry_n", SqlDbType.Int).Value = _p.entry_n;
            cmd.Parameters.Add("@Header_entry_n", SqlDbType.Int).Value = _p.header_entry_n;
            cmd.Parameters.Add("@N_Reception", SqlDbType.VarChar).Value = _p.n_reception;
            cmd.Parameters.Add("@N_Fournisseur", SqlDbType.VarChar).Value = _p.n_fournisseur;
            cmd.Parameters.Add("@N_Client", SqlDbType.VarChar).Value = _p.n_client;
            cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = _p.nom;

            cmd.Parameters.Add("@n_Article_1", SqlDbType.VarChar).Value = _p.num_article_1;
            cmd.Parameters.Add("@desig_article_1", SqlDbType.VarChar).Value = _p.desig_article_1;
            cmd.Parameters.Add("@qte_article_1", SqlDbType.Decimal).Value = _p.qte_article_1;

            cmd.Parameters.Add("@n_Article_2", SqlDbType.VarChar).Value = _p.num_article_2;
            cmd.Parameters.Add("@desig_article_2", SqlDbType.VarChar).Value = _p.desig_article_2;
            cmd.Parameters.Add("@qte_article_2", SqlDbType.Decimal).Value = _p.qte_article_2;

            cmd.Parameters.Add("@n_Article_3", SqlDbType.VarChar).Value = _p.num_article_3;
            cmd.Parameters.Add("@desig_article_3", SqlDbType.VarChar).Value = _p.desig_article_3;
            cmd.Parameters.Add("@qte_article_3", SqlDbType.Decimal).Value = _p.qte_article_3;

            cmd.Parameters.Add("@n_Article_4", SqlDbType.VarChar).Value = _p.num_article_4;
            cmd.Parameters.Add("@desig_article_4", SqlDbType.VarChar).Value = _p.desig_article_4;
            cmd.Parameters.Add("@qte_article_4", SqlDbType.Decimal).Value = _p.qte_article_4;

            cmd.Parameters.Add("@n_Article_5", SqlDbType.VarChar).Value = _p.num_article_5;
            cmd.Parameters.Add("@desig_article_5", SqlDbType.VarChar).Value = _p.desig_article_5;
            cmd.Parameters.Add("@qte_article_5", SqlDbType.Decimal).Value = _p.qte_article_5;

            cmd.Connection = oSQLConn;

            cmd.Transaction = oSQLTransaction;

            try
            {
                cmd.ExecuteNonQuery();
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
        public static int deletePesageLine(int entry_n)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();

            SqlCommand cmd_op = new SqlCommand();
            cmd_op.CommandText = "DELETE FROM [SOMEPA$Pesage Line] WHERE  [Entry N°] = @entry_n";
            cmd_op.Parameters.Add("@Entry_n", SqlDbType.Int).Value = entry_n;

            cmd_op.Connection = oSQLConn;

            cmd_op.Transaction = oSQLTransaction;

            try
            {
                cmd_op.ExecuteNonQuery();
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
        /// <param name="Entry_N"></param>
        /// <returns></returns>
        public static double getReceptionWeight(int Entry_N)
        {
            double poids_reception = 0;   
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT SUM ([Qte Total]) FROM [SOMEPA$Pesage Line] WHERE [Header Entry N°] = @Entry_N";
            cmd.Parameters.Add("@Entry_N", SqlDbType.Int).Value = Entry_N;
            cmd.Connection = oSQLConn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                poids_reception = double.Parse(reader[0].ToString());
            }
            reader.Close();
            oSQLConn.Close();
            return poids_reception;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entry_n"></param>
        /// <returns></returns>
        public static bool getBLClientFromNav(string n_reception, PesageLineModel _p)
        {
            bool blExist = false;
            SqlCommand cmd_header = new SqlCommand();
            SqlCommand cmd_line = new SqlCommand();

            cmd_header.CommandText = "SELECT [Bill-to Customer No_],[Bill-to Name],[Shipment Date] from " + GlobVars.dbtables.cltblheaderTab + " WHERE  [No_] = @n_reception ";
            cmd_header.Parameters.Add("@n_reception", SqlDbType.VarChar).Value = n_reception;

            cmd_line.CommandText = "SELECT [No_],[Description],[Quantity],[Unit of Measure] from " + GlobVars.dbtables.cltbllineTab + " WHERE [Document No_] = @n_reception ";
            cmd_line.Parameters.Add("@n_reception", SqlDbType.VarChar).Value = n_reception;
            /// Connexion a la base 
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            cmd_header.Connection = oSQLConn;
            cmd_line.Connection = oSQLConn;
            SqlDataReader reader = cmd_header.ExecuteReader();
            if (reader.Read())
            {
                _p.n_fournisseur = "";
                _p.n_client = reader["Bill-to Customer No_"].ToString();
                _p.nom = reader["Bill-to Name"].ToString();
                blExist = true;
            }
            reader.Close();
            if (blExist)
            {
                reader = cmd_line.ExecuteReader();
                if (reader.Read())
                    if (reader["No_"].ToString() != "4367800000")
                    {

                        _p.num_article_1 = reader["No_"].ToString();
                        _p.desig_article_1 = reader["Description"].ToString();
                        _p.qte_article_1 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                    }
                if (reader.Read())
                    if (reader["No_"].ToString() != "4367800000")
                    {
                        _p.num_article_2 = reader["No_"].ToString();
                        _p.desig_article_2 = reader["Description"].ToString();
                        _p.qte_article_2 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                    }
                if (reader.Read())
                    if (reader["No_"].ToString() != "4367800000")
                    {
                        _p.num_article_3 = reader["No_"].ToString();
                        _p.desig_article_3 = reader["Description"].ToString();
                        _p.qte_article_3 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                    }
                if (reader.Read())
                    if (reader["No_"].ToString() != "4367800000")
                    {
                        _p.num_article_4 = reader["No_"].ToString();
                        _p.desig_article_4 = reader["Description"].ToString();
                        _p.qte_article_4 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                    }
                if (reader.Read())
                    if (reader["No_"].ToString() != "4367800000")
                    {
                        _p.num_article_5 = reader["No_"].ToString();
                        _p.desig_article_5 = reader["Description"].ToString();
                        _p.qte_article_5 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                    }

                reader.Close();
            }

            return blExist;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entry_n"></param>
        /// <returns></returns>
        public static bool getBLFrnFromNav(string n_reception, PesageLineModel _p)
        {
            bool blExist = false;
            SqlCommand cmd_header = new SqlCommand();
            SqlCommand cmd_line = new SqlCommand();

            cmd_header.CommandText = "SELECT [Pay-to Vendor No_],[Pay-to Name] from " + GlobVars.dbtables.frnblheaderTab + " WHERE  [No_] = @n_reception ";
            cmd_header.Parameters.Add("@n_reception", SqlDbType.VarChar).Value = n_reception;

            cmd_line.CommandText = "SELECT [No_],[Description],[Quantity],[Unit of Measure] from " + GlobVars.dbtables.frnbllineTab + " WHERE  [Document No_] = @n_reception ";
            cmd_line.Parameters.Add("@n_reception", SqlDbType.VarChar).Value = n_reception;
            /// Connexion a la base 
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            cmd_header.Connection = oSQLConn;
            cmd_line.Connection = oSQLConn;
            SqlDataReader reader = cmd_header.ExecuteReader();
            if (reader.Read())
            {
                _p.n_fournisseur = reader["Pay-to Vendor No_"].ToString();
                //_p.n_client ="";
                //_p.nom = reader["Pay-to Name"].ToString();
                blExist = true;
            }
            reader.Close();
            if (blExist)
            {
                reader = cmd_line.ExecuteReader();
                if (reader.Read())
                {

                    _p.num_article_1 = reader["No_"].ToString();
                    //_p.desig_article_1 = reader["Description"].ToString();
                    _p.qte_article_1 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                }
                if (reader.Read())
                {
                    _p.num_article_2 = reader["No_"].ToString();
                    //_p.desig_article_2 = reader["Description"].ToString();
                    _p.qte_article_2 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                }
                if (reader.Read())
                {
                    _p.num_article_3 = reader["No_"].ToString();
                    //_p.desig_article_3 = reader["Description"].ToString();
                    _p.qte_article_3 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                }
                if (reader.Read())
                {
                    _p.num_article_4 = reader["No_"].ToString();
                    //_p.desig_article_4 = reader["Description"].ToString();
                    _p.qte_article_4 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                }
                if (reader.Read())
                {
                    _p.num_article_5 = reader["No_"].ToString();
                    //_p.desig_article_5 = reader["Description"].ToString();
                    _p.qte_article_5 = GlobVars.pesDictionary[reader["Unit of Measure"].ToString()] * double.Parse(reader["Quantity"].ToString());
                }

                reader.Close();
            }

            return blExist;
        }

    }

        
}
