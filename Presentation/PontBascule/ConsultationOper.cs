using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
//sql library
using System.Data.SqlClient;
using System.Windows.Forms;
using GestionBascule.Business;
using GestionBascule.Business.commun;


namespace GestionBascule
{
    public partial class ConsultationOper : Form
    {
        List<string> list_camion = new List<string>();
        List<string> list_chauffeur = new List<string>();
        List<string> list_nom_frn = new List<string>();
        List<string> list_nom_client = new List<string>();
        List<string> list_desig_article = new List<string>();

        BindingSource bs = new BindingSource();

        public ConsultationOper()
        {
            InitializeComponent();
            datedebut_dtp.Value = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
        }
        //Enter keys instead of tab keys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((msg.WParam.ToInt32() == 13))
            {
                SendKeys.Send("{Tab}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void getPesageList()
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd_oper = new SqlCommand();

            cmd_oper.Connection = oSQLConn;

            DateTime date_debut, date_fin;
            date_debut = DateTime.Parse(datedebut_dtp.Text + " 00:00:00");
            date_fin = DateTime.Parse(datefin_dtp.Text + " 23:59:59");

            cmd_oper.CommandText = "Select [Header Entry N°],[Type Operation] = CASE [SOMEPA$Pesage Header].[Type Opération] WHEN 1 THEN 'Entrée Stock' ELSE 'Sortie Stock' END,[Date Entrée], "
            + " [N° Article 1],[Désignation Article 1],[Qte Article 1],[N° Article 2],[Désignation Article 2],[Qte Article 2],[N° Article 3],[Désignation Article 3],[Qte Article 3], "
            + " [N° Article 4],[Désignation Article 4],[Qte Article 4],[N° Article 5],[Désignation Article 5],[Qte Article 5], "
            + " [N° Réception],[N° Ticket], [N° Fournisseur],[N° Client],[Nom Frn] = CASE [Type Opération] WHEN 1 THEN Nom ELSE '' END, "
            + " [Nom Clt] = CASE [Type Opération] WHEN 1 THEN '' ELSE Nom END, [Matricule Camion],[Nom Chauffeur],[Pesage1],[Pesage2],[Poids Net],[Poids Réception],[Ecart Poids], "
            + " [Date Sortie],[Destination],[SOMEPA$Pesage Header].[Etat] from [SOMEPA$Pesage Line] INNER JOIN [SOMEPA$Pesage Header] ON [SOMEPA$Pesage Line].[Header Entry N°] = [SOMEPA$Pesage Header].[Entry N°] ";
            cmd_oper.Parameters.Add("@date_debut", SqlDbType.DateTime).Value = date_debut;
            cmd_oper.Parameters.Add("@date_fin", SqlDbType.DateTime).Value = date_fin;

            SqlDataAdapter sda = new SqlDataAdapter(cmd_oper);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Pesage");
            bs.DataSource = ds.Tables["Pesage"];
            STOCK_DGV.DataSource = bs;
            oSQLConn.Close();

        }

        // fonction filtrage datagridviex
        public void filterDGV()
        {
            string date_debut, date_fin;
            date_debut = datedebut_dtp.Value.ToString("dd/MM/yyyy " + "00:00:00");
            date_fin = datefin_dtp.Value.ToString("dd/MM/yyyy " + "23:59:59");
            int min_ecart, max_ecart;
            min_ecart = int.Parse(ecartMin_tb.Text);
            max_ecart = int.Parse(ecartMax_tb.Text);
            bs.Filter = string.Format("[Type Operation] LIKE '%{0}%' AND [Nom Frn] LIKE '%{1}%' AND [Nom Clt] LIKE '%{2}%' " +
            " AND ([Désignation Article 1] LIKE '%{3}%' OR [Désignation Article 2] LIKE '%{3}%' OR [Désignation Article 3] LIKE '%{3}%' " +
            " OR [Désignation Article 4] LIKE '%{3}%' OR [Désignation Article 5] LIKE '%{3}%' ) AND [Nom Chauffeur] LIKE '%{4}%'  " + 
            " AND [Matricule Camion] LIKE '%{5}%' AND [Ecart Poids] >= {6} AND [Ecart Poids] <= {7} " +
            " AND [Date Entrée] >= '{8}' AND [Date Entrée] <= '{9}'", type_oper_cb.Text, nom_frn_cb.Text, nom_clt_cb.Text, desig_article_cb.Text.TrimEnd(),
            chauffeur_cb.Text, camion_cb.Text, min_ecart, max_ecart, date_debut, date_fin);
        }


        private void AfficherClick(object sender, EventArgs e)
        {
            getPesageList();
        }

        private void resetfilter_but_Click(object sender, EventArgs e)
        {
            type_oper_cb.Text = "";
            desig_article_cb.Text = "";
            nom_frn_cb.Text = "";
            nom_clt_cb.Text = "";
            chauffeur_cb.Text = "";
            camion_cb.Text = "";
            datedebut_dtp.Value = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
            datefin_dtp.Value = DateTime.Now; 
            ecartMin_tb.Text = "-9999";
            ecartMax_tb.Text = "9999";
            filterDGV();

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    //Action si l'utilisateur est sûr
                    int Entry_N = int.Parse(STOCK_DGV.CurrentRow.Cells["Header Entry N°"].Value.ToString());
                    Business.PesageHeaderDao.deletePesageHeader(Entry_N);
                    getPesageList();
                }
                catch (Exception exep ) 
                {
                    System.Windows.Forms.MessageBox.Show(exep.Message);
                }
            }  
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            Datasets.Pesage ds = new Datasets.Pesage();
            DateTime date_debut, date_fin;
            string operation, desig_article, nom_frn, nom_clt, chauffeur, camion;
            decimal ecart_min, ecart_max;
            date_debut = DateTime.Parse(datedebut_dtp.Text + " 00:00:00");
            date_fin = DateTime.Parse(datefin_dtp.Text + " 23:59:59");
            ecart_min = decimal.Parse(ecartMin_tb.Text);
            ecart_max = decimal.Parse(ecartMax_tb.Text);
            operation = type_oper_cb.Text;
            desig_article = desig_article_cb.Text;
            nom_frn = nom_frn_cb.Text;
            nom_clt = nom_clt_cb.Text;
            chauffeur = chauffeur_cb.Text;
            camion = camion_cb.Text;

            DataGridViewRow row_;
            for (int i = 0; i < STOCK_DGV.RowCount - 1; i++)
            {
                row_ = STOCK_DGV.Rows[i];
                string detailarticle = "";
                // article 1
                if (double.Parse(row_.Cells[5].Value.ToString()) > 0)
                    detailarticle += row_.Cells[4].Value.ToString() + " : " + string.Format("{0:0.##}",row_.Cells[5].Value);
                // article 2
                if (double.Parse(row_.Cells[8].Value.ToString()) > 0)
                    detailarticle += "\n" + row_.Cells[7].Value.ToString() + " : " +string.Format("{0:0.##}", row_.Cells[8].Value);
                // article 3
                if (double.Parse(row_.Cells[11].Value.ToString()) > 0)
                    detailarticle += "\n" + row_.Cells[10].Value.ToString() + " : " + string.Format("{0:0.##}",row_.Cells[11].Value);
                // article 4
                if (double.Parse(row_.Cells[14].Value.ToString()) > 0)
                    detailarticle += "\n" + row_.Cells[13].Value.ToString() + " : " + string.Format("{0:0.##}",row_.Cells[14].Value);
                // article 5
                if (double.Parse(row_.Cells[17].Value.ToString()) > 0)
                    detailarticle += "\n" + row_.Cells[16].Value.ToString() + " : " + string.Format("{0:0.##}",row_.Cells[17].Value);

                ds.Tables["Pesage"].Rows.Add(row_.Cells[0].Value, row_.Cells[1].Value, row_.Cells[2].Value, " ",
                    detailarticle, row_.Cells[18].Value, row_.Cells[19].Value, row_.Cells[20].Value, row_.Cells[21].Value,
                    row_.Cells[22].Value, row_.Cells[23].Value, row_.Cells[24].Value, row_.Cells[25].Value, row_.Cells[26].Value,
                    row_.Cells[27].Value, row_.Cells[28].Value, row_.Cells[29].Value, row_.Cells[30].Value, row_.Cells[31].Value,
                    row_.Cells[32].Value, row_.Cells[33].Value);
            }
            ds.Tables["Divers"].Rows.Add(operation, date_debut, date_fin, desig_article, nom_frn, nom_clt, chauffeur, camion, ecart_min, ecart_max);
            ImpressionPesage form_ = new ImpressionPesage(1, ds);
            form_.ShowDialog();
        }

        private void loadData()
        {
             // chargement des donnees de la base donnees
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader ;
            // fournisseurs
            cmd.CommandText = "Select [No_],[Name]  from " + GlobVars.dbtables.fournisseurTab;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nom_frn_cb.Items.Add(reader["Name"].ToString());
                list_nom_frn.Add(reader["Name"].ToString());
            }
            reader.Close();
            // client
            cmd.CommandText = "Select [No_],[Name]  from " + GlobVars.dbtables.clientTab;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nom_clt_cb.Items.Add(reader["Name"].ToString());
                list_nom_client.Add(reader["Name"].ToString());
            }
            reader.Close();
            // fournisseurs
            cmd.CommandText = "Select [No_],[Description] from " + GlobVars.dbtables.articleTab;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                desig_article_cb.Items.Add(reader["Description"].ToString());
                list_desig_article.Add(reader["Description"].ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT [Code] FROM " + GlobVars.dbtables.automobileTab;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                camion_cb.Items.Add(reader["Code"].ToString());
                list_camion.Add(reader["Code"].ToString());
            }
            reader.Close();
            cmd.CommandText = "Select Code,Name from " + GlobVars.dbtables.chauffeurTab;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chauffeur_cb.Items.Add(reader["Name"].ToString());
                list_chauffeur.Add(reader["Name"].ToString());
            }
            reader.Close();
            oSQLConn.Close();
        }

        private void ConsultationOpe_Load(object sender, EventArgs e)
        {
            loadData();
            switchDBComp1.switchSomepaDB_rb.Checked = GlobVars.dbtables.isSomepaDB;
            switchDBComp1.switchNewDB_rb.Checked = GlobVars.dbtables.isNewDB;
            switchDBComp1.activateEvents = true;
        }

        private void transit_but_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    //Action si l'utilisateur est sûr
                    int Entry_N = int.Parse(STOCK_DGV.CurrentRow.Cells["Entry N°"].Value.ToString());
                    PesageHeaderDao.deleteCloPesageHeader(Entry_N);
                    getPesageList();
                }
                catch (Exception exep)
                {
                    System.Windows.Forms.MessageBox.Show(exep.Message);
                }
            }  
        }

        private void desig_produit_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            filterDGV();
        }

        private void nom_frn_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            filterDGV();
        }

        private void nom_clt_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDGV();
        }

        private void type_oper_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDGV();
        }

        private void type_oper_cb_KeyUp(object sender, KeyEventArgs e)
        {
            filterDGV();
        }

        private void chauffeur_tb_KeyUp(object sender, KeyEventArgs e)
        {
            filterDGV();
        }

        private void camion_tb_KeyUp(object sender, KeyEventArgs e)
        {
            filterDGV();
        }

        private void ecartMin_tb_KeyUp(object sender, KeyEventArgs e)
        {
            filterDGV();
        }

        private void ecartMax_tb_KeyUp(object sender, KeyEventArgs e)
        {
            filterDGV();
        }

        private void datedebut_dtp_ValueChanged(object sender, EventArgs e)
        {
            filterDGV();
        }

        private void datefin_dtp_ValueChanged(object sender, EventArgs e)
        {
            filterDGV();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STOCK_DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editer_but_Click(sender, e);
        }

        private void editer_but_Click(object sender, EventArgs e)
        {
            int entry_n;
            string operation;
            try
            {
                operation = STOCK_DGV.CurrentRow.Cells["Type Operation"].Value.ToString();
                entry_n = int.Parse(STOCK_DGV.CurrentRow.Cells["Header Entry N°"].Value.ToString());
            }
            catch { return; }

            switch (operation)
            {
                case "Entrée Stock":
                    EntreeStock form_1 = new EntreeStock(entry_n);
                    form_1.ShowDialog();
                    getPesageList();
                    break;
                case "Sortie Stock":
                    SortieStock form_2 = new SortieStock(entry_n);
                    form_2.ShowDialog();
                    getPesageList();
                    break;
                default:
                    break;
            }
        }

        private void camion_cb_KeyUp(object sender, KeyEventArgs e)
        {
            camion_cb.Items.Clear();
            string code = camion_cb.Text;
            foreach (string element in list_camion)
            {
                if (element.ToUpper().Contains(code.ToUpper()))
                    camion_cb.Items.Add(element);
            }
            camion_cb.SelectionStart = camion_cb.Text.Length;
            camion_cb.SelectionLength = 0;

            // filter dgv
            filterDGV();
        }

        private void chauffeur_cb_KeyUp(object sender, KeyEventArgs e)
        {
            chauffeur_cb.Items.Clear();
            string code = chauffeur_cb.Text;
            foreach (string element in list_chauffeur)
            {
                if (element.ToUpper().Contains(code.ToUpper()))
                    chauffeur_cb.Items.Add(element);
            }
            chauffeur_cb.SelectionStart = chauffeur_cb.Text.Length;
            chauffeur_cb.SelectionLength = 0;

            // filter dgv
            filterDGV();
        }

        private void nom_clt_cb_KeyUp(object sender, KeyEventArgs e)
        {
            nom_clt_cb.Items.Clear();
            string nom = nom_clt_cb.Text;
            foreach (string element in list_nom_client)
            {
                if (element.ToUpper().Contains(nom.ToUpper()))
                    nom_clt_cb.Items.Add(element);
            }
            nom_clt_cb.SelectionStart = nom_clt_cb.Text.Length;
            nom_clt_cb.SelectionLength = 0;

            // filter dgv
            filterDGV();
        }

        private void nom_frn_cb_KeyUp(object sender, KeyEventArgs e)
        {
            nom_frn_cb.Items.Clear();
            string nom = nom_frn_cb.Text;
            foreach (string element in list_nom_frn)
            {
                if (element.ToUpper().Contains(nom.ToUpper()))
                    nom_frn_cb.Items.Add(element);
            }
            nom_frn_cb.SelectionStart = nom_frn_cb.Text.Length;
            nom_frn_cb.SelectionLength = 0;

            // filter dgv
            filterDGV();
        }

        private void desig_produit_cb_KeyUp(object sender, KeyEventArgs e)
        {
            desig_article_cb.Items.Clear();
            string desig = desig_article_cb.Text;
            foreach (string element in list_desig_article)
            {
                if (element.ToUpper().Contains(desig.ToUpper()))
                    desig_article_cb.Items.Add(element);
            }
            desig_article_cb.SelectionStart = desig_article_cb.Text.Length;
            desig_article_cb.SelectionLength = 0;

            // filter dgv
            filterDGV();
        }

        private void switchDBComp1_radioStateChanged(object sender, EventArgs e)
        {
            // Clear filters ans lists
            nom_frn_cb.Items.Clear();
            list_nom_frn.Clear();

            nom_clt_cb.Items.Clear();
            list_nom_client.Clear();

            desig_article_cb.Items.Clear();
            list_desig_article.Clear();

            camion_cb.Items.Clear();
            list_camion.Clear();

            chauffeur_cb.Items.Clear();
            list_chauffeur.Clear();

            // Reload data
            loadData();
        }

    }
}
