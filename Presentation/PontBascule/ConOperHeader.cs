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
    public partial class ConOperHeader : Form
    {
        List<string> list_camion = new List<string>();
        List<string> list_chauffeur = new List<string>();

        BindingSource bs = new BindingSource();

        public ConOperHeader()
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

            cmd_oper.CommandText = "Select [Entry N°],[Type Operation] = CASE [SOMEPA$Pesage Header].[Type Opération] WHEN 1 THEN 'Entrée Stock' ELSE 'Sortie Stock' END,[Date Entrée], "          
            + " [N° Ticket],[Matricule Camion],[Nom Chauffeur],[Pesage1],[Pesage2],[Poids Net],[Poids Réception],[Ecart Poids], "
            + " [Date Sortie],[Destination],[Etat] from [SOMEPA$Pesage Header]  ";
            cmd_oper.Parameters.Add("@date_debut", SqlDbType.DateTime).Value = date_debut;
            cmd_oper.Parameters.Add("@date_fin", SqlDbType.DateTime).Value = date_fin;

            SqlDataAdapter sda = new SqlDataAdapter(cmd_oper);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Pesage");
            bs.DataSource = ds.Tables["Pesage"];
            STOCK_DGV.DataSource = bs;
            oSQLConn.Close();

        }

        // fonction filtrage datagridview
        public void filterDGV()
        {
            string date_debut, date_fin;
            date_debut = datedebut_dtp.Value.ToString("dd/MM/yyyy " + "00:00:00");
            date_fin = datefin_dtp.Value.ToString("dd/MM/yyyy " + "23:59:59");
            int min_ecart, max_ecart;
            min_ecart = int.Parse(ecartMin_tb.Text);
            max_ecart = int.Parse(ecartMax_tb.Text);
            bs.Filter = string.Format("[Type Operation] LIKE '%{0}%' " +
            " AND [Nom Chauffeur] LIKE '%{1}%'  " + 
            " AND [Matricule Camion] LIKE '%{2}%' AND [Ecart Poids] >= {3} AND [Ecart Poids] <= {4} " +
            " AND [Date Entrée] >= '{5}' AND [Date Entrée] <= '{6}'", type_oper_cb.Text, chauffeur_cb.Text, camion_cb.Text, min_ecart, max_ecart, date_debut, date_fin);
        }


        private void AfficherClick(object sender, EventArgs e)
        {
            getPesageList();
        }

        private void resetfilter_but_Click(object sender, EventArgs e)
        {
            type_oper_cb.Text = "";
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
                    int Entry_N = int.Parse(STOCK_DGV.CurrentRow.Cells["Entry N°"].Value.ToString());
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
            Datasets.Pesage_Header ds = new Datasets.Pesage_Header();
            DateTime date_debut, date_fin;
            string operation, chauffeur, camion;
            decimal ecart_min, ecart_max;
            date_debut = DateTime.Parse(datedebut_dtp.Text + " 00:00:00");
            date_fin = DateTime.Parse(datefin_dtp.Text + " 23:59:59");
            ecart_min = decimal.Parse(ecartMin_tb.Text);
            ecart_max = decimal.Parse(ecartMax_tb.Text);
            operation = type_oper_cb.Text;
            chauffeur = chauffeur_cb.Text;
            camion = camion_cb.Text;

            for (int i = 0; i < STOCK_DGV.RowCount - 1; i++)
            {
                ds.Tables["Pesage"].Rows.Add(STOCK_DGV.Rows[i].Cells[0].Value, STOCK_DGV.Rows[i].Cells[1].Value, STOCK_DGV.Rows[i].Cells[2].Value,
                    STOCK_DGV.Rows[i].Cells[3].Value, STOCK_DGV.Rows[i].Cells[4].Value, STOCK_DGV.Rows[i].Cells[5].Value, STOCK_DGV.Rows[i].Cells[6].Value,
                    STOCK_DGV.Rows[i].Cells[7].Value, STOCK_DGV.Rows[i].Cells[8].Value, STOCK_DGV.Rows[i].Cells[9].Value, STOCK_DGV.Rows[i].Cells[10].Value,
                    STOCK_DGV.Rows[i].Cells[11].Value, STOCK_DGV.Rows[i].Cells[12].Value, STOCK_DGV.Rows[i].Cells[13].Value);                   
            }

            ds.Tables["Divers"].Rows.Add(operation, date_debut, date_fin, chauffeur, camion, ecart_min, ecart_max);
            ImpressionPesage form_ = new ImpressionPesage(0, ds);
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
                entry_n = int.Parse(STOCK_DGV.CurrentRow.Cells["Entry N°"].Value.ToString());
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

        private void switchDBComp1_radioStateChanged(object sender, EventArgs e)
        {
            // Clear data
            camion_cb.Items.Clear();
            list_camion.Clear();

            chauffeur_cb.Items.Clear();
            list_chauffeur.Clear();
            // Reload data
            loadData();
        }

    }
}
