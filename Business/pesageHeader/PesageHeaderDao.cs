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
    public class PesageHeaderDao
    { 
        /// <summary>
        /// Save new pesage 1 operation
        /// </summary>
        /// <param name="_p"></param>
        /// <returns> id of inserted row </returns>
        public static int savePesageHeader(PesageHeaderModel _p)
        {
            int ret = 0;
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();

            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO [SOMEPA$Pesage Header] "
            + " ([Type Opération],[Date Entrée],[N° Ticket],[Matricule Camion],[Nom Chauffeur],[Pesage1],[Pesage2],[Poids Net],[Poids Réception],[Ecart Poids] ,[Date Sortie],[Destination],[Etat]) "
            + " OUTPUT INSERTED.[Entry N°] " // to get id of inserted rowin database
            + " VALUES (@Type_Op,@Date_Enree,@N_Ticket,@Mat_Camion,@Nom_Chauf,@Pesage1,0,0,0,0,@Date_Sortie,@Destination,0) ";
            


            cmd.Parameters.Add("@Type_Op", SqlDbType.Int).Value = _p.type_oper;

            cmd.Parameters.Add("@Date_Enree", SqlDbType.DateTime).Value = _p.date_entree;

            cmd.Parameters.Add("@N_Ticket", SqlDbType.VarChar).Value = _p.n_ticket;
            cmd.Parameters.Add("@Mat_Camion", SqlDbType.VarChar).Value = _p.matricule_camion;
            cmd.Parameters.Add("@Nom_Chauf", SqlDbType.VarChar).Value = _p.nom_chauffeur;
            cmd.Parameters.Add("@Pesage1", SqlDbType.Decimal).Value = _p.pesage_1;
            cmd.Parameters.Add("@Date_Sortie", SqlDbType.DateTime).Value = _p.date_entree;
            cmd.Parameters.Add("@Destination", SqlDbType.VarChar).Value = _p.destination;

            cmd.Connection = oSQLConn;

            cmd.Transaction = oSQLTransaction;

            try
            {
                ret = Convert.ToInt32(cmd.ExecuteScalar());
                oSQLTransaction.Commit();
                oSQLConn.Close();
                return ret;
            }
            catch (Exception exep)
            {
                System.Windows.Forms.MessageBox.Show(exep.Message);
                oSQLTransaction.Rollback();
                oSQLConn.Close();
                return -1;
            }

        }

        /// <summary>
        /// Save pesage 2 new operation
        /// </summary>
        /// <param name="_p"></param>
        /// <returns></returns>
        public static int closurePesageHeader(PesageHeaderModel _p)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();

            SqlCommand cmd_op = new SqlCommand();
            cmd_op.CommandText = "UPDATE [SOMEPA$Pesage Header] SET Pesage2=@Pesage2, [Poids Net]=@Poids_Net,[Ecart Poids]=@Ecart_p, [Date Sortie]=@Date_Sortie, Etat=2 WHERE  [Entry N°] = @entry_n";
            cmd_op.Parameters.Add("@Date_Sortie", SqlDbType.DateTime).Value = _p.date_sortie;
            cmd_op.Parameters.Add("@entry_n", SqlDbType.Int).Value = _p.entry_n;
            cmd_op.Parameters.Add("@Pesage2", SqlDbType.Int).Value = _p.pesage_2;
            cmd_op.Parameters.Add("@Poids_Net", SqlDbType.Int).Value = _p.poids_net;
            cmd_op.Parameters.Add("@Ecart_p", SqlDbType.Int).Value = _p.ecart_poids;

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
        /// Get pesage operation
        /// </summary>
        /// <param name="entry_n"></param>
        /// <returns></returns>
        public static PesageHeaderModel getPesageHeader(int entry_n)
        {
            PesageHeaderModel _p = new PesageHeaderModel();
            _p.entry_n = entry_n;
            SqlCommand cmd_op = new SqlCommand();
            cmd_op.CommandText = "SELECT * from  [SOMEPA$Pesage Header]  WHERE  [Entry N°] = @entry_n ";
            cmd_op.Parameters.Add("@entry_n", SqlDbType.Int).Value = entry_n;
            /// Connexion a la base 
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            cmd_op.Connection = oSQLConn;
            SqlDataReader reader = cmd_op.ExecuteReader();
            if (reader.Read())
            {
                _p.n_ticket = reader["N° Ticket"].ToString();
                _p.type_oper = int.Parse(reader["Type Opération"].ToString());
                _p.date_entree = DateTime.Parse(reader["Date Entrée"].ToString());
                _p.date_sortie = DateTime.Parse(reader["Date Sortie"].ToString());
                _p.matricule_camion = reader["Matricule Camion"].ToString();
                _p.nom_chauffeur = reader["Nom Chauffeur"].ToString(); ;
                _p.destination = reader["Destination"].ToString();
                _p.poids_reception = double.Parse(reader["Poids Réception"].ToString());
              
                _p.pesage_1 = double.Parse(reader["Pesage1"].ToString());
                _p.pesage_2 = double.Parse(reader["Pesage2"].ToString());
                _p.poids_net = double.Parse(reader["Poids Net"].ToString());
                _p.ecart_poids = double.Parse(reader["Ecart Poids"].ToString());
            }
            reader.Close();
            return _p;
        }

        /// <summary>
        /// update pesage operation
        /// </summary>
        /// <param name="_p"></param>
        /// <returns></returns>
        public static int updatePesageHeader(PesageHeaderModel _p)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();

            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "UPDATE [SOMEPA$Pesage Header] SET [Date Entrée]=@Date_Entree,[N° Ticket]=@N_Ticket,[Matricule Camion]=@Mat_Camion,[Nom Chauffeur]=@Nom_Chauf, " 
            + " Pesage1=@Pesage1,Destination=@Destination,Pesage2=@Pesage2,[Poids Net]=@Poids_Net,[Ecart Poids]=@Ecart_p,[Date Sortie]=@Date_Sortie WHERE [Entry N°] = @Entry_n ";
            
            // P1
            cmd.Parameters.Add("@Entry_n", SqlDbType.Int).Value = _p.entry_n;
            cmd.Parameters.Add("@Date_Entree", SqlDbType.DateTime).Value = _p.date_entree;
            cmd.Parameters.Add("@N_Ticket", SqlDbType.VarChar).Value = _p.n_ticket;
            cmd.Parameters.Add("@Mat_Camion", SqlDbType.VarChar).Value = _p.matricule_camion;
            cmd.Parameters.Add("@Nom_Chauf", SqlDbType.VarChar).Value = _p.nom_chauffeur;
            cmd.Parameters.Add("@Pesage1", SqlDbType.Decimal).Value = _p.pesage_1;
            //cmd.Parameters.Add("@Poids_Reception", SqlDbType.Decimal).Value = _p.poids_reception;
            // P2
            cmd.Parameters.Add("@Date_Sortie", SqlDbType.DateTime).Value = _p.date_sortie;
            cmd.Parameters.Add("@Pesage2", SqlDbType.Decimal).Value = _p.pesage_2;
            cmd.Parameters.Add("@Poids_Net", SqlDbType.Decimal).Value = _p.poids_net;
            cmd.Parameters.Add("@Ecart_p", SqlDbType.Decimal).Value = _p.ecart_poids;
            cmd.Parameters.Add("@Destination", SqlDbType.VarChar).Value = _p.destination;

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
        /// delete pesage 2 operation
        /// </summary>
        /// <param name="entry_n"></param>
        /// <returns></returns>
        public static int deleteCloPesageHeader(int entry_n)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlTransaction oSQLTransaction = oSQLConn.BeginTransaction();

            SqlCommand cmd_op = new SqlCommand();
            cmd_op.CommandText = "UPDATE [SOMEPA$Pesage Header] SET Pesage2=0, [Poids Net]=0,[Ecart Poids]=0,  Etat=0 WHERE  [Entry N°] = @entry_n";
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
        /// delete pesage operation (with all attached BLs)
        /// </summary>
        /// <param name="NBL"></param>
        public static void deletePesageHeader(int Entry_N)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd_header = new SqlCommand();
            SqlCommand cmd_line = new SqlCommand();
            cmd_header.CommandText = "DELETE from  [SOMEPA$Pesage Header]  WHERE  [Entry N°] = @Entry_N";
            cmd_line.CommandText = "DELETE from  [SOMEPA$Pesage Line]  WHERE  [Header Entry N°] = @Entry_N";

            cmd_header.Parameters.Add("@Entry_N", SqlDbType.Int).Value = Entry_N;
            cmd_line.Parameters.Add("@Entry_N", SqlDbType.Int).Value = Entry_N;

            cmd_header.Connection = oSQLConn;
            cmd_line.Connection = oSQLConn;

            try
            {
                cmd_header.ExecuteNonQuery();
                cmd_line.ExecuteNonQuery();
            }
            catch (Exception exep) { System.Windows.Forms.MessageBox.Show(exep.Message); }
            oSQLConn.Close();
        }

        /// <summary>
        /// update reception weight (to have been called after any BLs operation)
        /// </summary>
        /// <param name="Entry_N"></param>
        public static double updateWeightPesageHeader(int Entry_N)
        {
            double weight = 0;
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = "UPDATE  [SOMEPA$Pesage Header] SET  [Poids Réception] = (SELECT ISNULL(SUM ([Qte Total]),0) FROM [SOMEPA$Pesage Line] WHERE [Header Entry N°] = @Entry_N)  OUTPUT INSERTED.[Poids Réception]  WHERE [Entry N°] = @Entry_N";
            cmd.Parameters.Add("@Entry_N", SqlDbType.Int).Value = Entry_N;
            cmd.Connection = oSQLConn;
            try
            {
                weight = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch (Exception exep) { System.Windows.Forms.MessageBox.Show(exep.Message); }
            oSQLConn.Close();
            return weight;
        }

    }
}
