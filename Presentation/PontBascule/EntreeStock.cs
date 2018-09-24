using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GestionBascule.Business.commun;
using GestionBascule.Business.pesage;
using GestionBascule.Business;

namespace GestionBascule
{
    public partial class EntreeStock : Form
    {
        PesageHeaderModel _p = new PesageHeaderModel();

        /// <summary>
        /// operation = 0 --> new entry p1
        /// operation = 1 --> new entry p2
        /// operation = 1 --> update old entry
        /// </summary>
        int operation;
        
        List<string> list_camion = new List<string>();
        List<string> list_chauffeur = new List<string>();

        /// <summary>
        /// constructor for new entry pesage 1
        /// </summary>
        /// <param name="poids_bascule_"></param>
        /// <param name="owner_"></param>
        public EntreeStock(double poids_bascule_)
        {
            InitializeComponent();
            this.Text = "Entrée Stock : Pesage 1";
            pesage1_tb.Text = poids_bascule_.ToString();
            operation = 0;
            _p.type_oper = 2;

            // controls status
            bls_tp.Enabled = false;
            date_sortie_dtp.Enabled = false;
            pesage2_tb.Enabled = false;
            poids_net_tb.Enabled = false;
        }

        /// <summary>
        /// constructor for new entry pesage 2
        /// </summary>
        /// <param name="poids_bascule_"></param>
        /// <param name="owner_"></param>
        public EntreeStock(int entry_n, double poids_bascule_)
        {
            InitializeComponent();
            this.Text = "Entrée Stock : Pesage 2";
            operation = 1;
            _p = PesageHeaderDao.getPesageHeader(entry_n);

            nticket_tb.Text = _p.n_ticket;
            date_entree_dtp.Value = _p.date_entree;

            camion_cb.Text = _p.matricule_camion;
            chauffeur_cb.Text = _p.nom_chauffeur;

            poids_recep_tb.Text = _p.poids_reception.ToString();
            //date_sortie_dtp.Value = _p.date_sortie; --> 
            pesage1_tb.Text = _p.pesage_1.ToString();
            pesage2_tb.Text = poids_bascule_.ToString();
            poids_net_tb.Text = Math.Abs((double.Parse(pesage1_tb.Text) - double.Parse(pesage2_tb.Text))).ToString("0.000");

            // controls status
            nticket_tb.Enabled = false;
            date_entree_dtp.Enabled = false;
            camion_cb.Enabled = false;
            chauffeur_cb.Enabled = false;
            pesage1_tb.Enabled = false;
        }

        /// <summary>
        /// constructor for update old entry
        /// </summary>
        /// <param name="poids_bascule_"></param>
        /// <param name="owner_"></param>
        /// <param name="entry_n"></param>
        public EntreeStock(int entry_n)
        {
            InitializeComponent();
            this.Text = "Entrée Stock : Modification Pesage";
            operation = 2;
            _p = PesageHeaderDao.getPesageHeader(entry_n);

            // P1
            nticket_tb.Text = _p.n_ticket;
            date_entree_dtp.Value = _p.date_entree;

            camion_cb.Text = _p.matricule_camion;
            chauffeur_cb.Text = _p.nom_chauffeur;            

            pesage1_tb.Text = _p.pesage_1.ToString();

            //P2
            poids_recep_tb.Text = _p.poids_reception.ToString();
            date_sortie_dtp.Value = _p.date_sortie;
            pesage1_tb.Text = _p.pesage_1.ToString();
            pesage2_tb.Text = _p.pesage_2.ToString();
            poids_net_tb.Text = _p.poids_net.ToString();
        }

        
        /// <summary>
        /// Enter keys instead of tab keys
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((msg.WParam.ToInt32() == 13))
            {
                SendKeys.Send("{Tab}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Error manager
        /// </summary>
        /// <returns></returns>
        private int WithErrors()
        {
            if (nticket_tb.Text.Trim() == String.Empty)
                return 1;
            else if (camion_cb.Text.Trim() == String.Empty)
                return 2;
            else if (chauffeur_cb.Text.Trim() == String.Empty)
                return 3;
            else if (pesage1_tb.Text == "0")
                return 5;
            else
                return 0;
        }

        /// <summary>
        /// reset form data 
        /// </summary>
        private void loadData()
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader ;

            //camion
            cmd.CommandText = "SELECT [Code] FROM " + GlobVars.dbtables.automobileTab;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                camion_cb.Items.Add(reader["Code"].ToString());
                list_camion.Add(reader["Code"].ToString());
            }
            reader.Close();            
            // chauffeur
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

        /// <summary>
        /// load list BLs
        /// </summary>
        /// <param name="entry_n"></param>
        public void getBLs(int entry_n)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd_bls = new SqlCommand();

            cmd_bls.Connection = oSQLConn;

            cmd_bls.CommandText = "Select * from [SOMEPA$Pesage Line] WHERE  [Header Entry N°] = @entry_n";
            cmd_bls.Parameters.Add("@Entry_n", SqlDbType.Int).Value = entry_n;


            SqlDataAdapter sda_p1 = new SqlDataAdapter(cmd_bls);

            DataSet ds_p1 = new DataSet();

            sda_p1.Fill(ds_p1, "BLs");

            BLs_DGV.DataSource = ds_p1.Tables["BLs"];

            oSQLConn.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pesage1Sortie_Load(object sender, EventArgs e)
        {
            loadData();
            switchDBComp1.switchSomepaDB_rb.Checked = GlobVars.dbtables.isSomepaDB;
            switchDBComp1.switchNewDB_rb.Checked = GlobVars.dbtables.isNewDB;
            switchDBComp1.activateEvents = true;

            getBLs(_p.entry_n);
        }

        /// <summary>
        /// Controls events handlers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            int verifData = WithErrors();
            if (verifData != 0)
            {
                INFO_MSG form = new INFO_MSG("Compléter la saisie : \n" + GlobVars.errorDictionary[verifData]);
                form.ShowDialog();
                return;
            }

            //P1
            _p.type_oper = 1;

            _p.n_ticket = nticket_tb.Text;
            _p.date_entree = date_entree_dtp.Value;

            _p.matricule_camion = camion_cb.Text;
            _p.nom_chauffeur = chauffeur_cb.Text;

            _p.pesage_1 = int.Parse(pesage1_tb.Text);

            _p.destination = "";

            //P2
            _p.date_sortie = date_sortie_dtp.Value;
            _p.pesage_2 = int.Parse(pesage2_tb.Text);
            _p.poids_net = int.Parse(poids_net_tb.Text);
            _p.ecart_poids = _p.poids_net - _p.poids_reception;

            int ret = new int();

            switch (operation)
            {
                // P1 new entry
                case 0:
                    ret = PesageHeaderDao.savePesageHeader(_p);
                    if (ret != -1)
                    {
                        _p.entry_n = ret;
                        bls_tp.Enabled = true;
                        prTabControl.SelectTab(1);
                        operation = 2;
                    }
                    break;
                case 1:
                    if (Math.Abs(_p.ecart_poids) > GlobVars.maxEcartWeight)
                    {
                        MessageBox.Show("Ecart poids > " + GlobVars.maxEcartWeight, "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    ret = PesageHeaderDao.closurePesageHeader(_p);
                    break;
                case 2:
                    ret = PesageHeaderDao.updatePesageHeader(_p);
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
            //Agriculteur_cb.DataSource = list_agriculteur_;
            camion_cb.SelectionStart = camion_cb.Text.Length;
            camion_cb.SelectionLength = 0;
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
        }

        private void pesage2_tb_KeyUp(object sender, KeyEventArgs e)
        {
            int pesage1, pesage2, poids_net;
            pesage2 = int.Parse(pesage2_tb.Text);
            pesage1 = int.Parse(pesage1_tb.Text);
            poids_net = Math.Abs(pesage2 - pesage1);
            poids_net_tb.Text = poids_net.ToString();
        }

        private void ajouter_bl_Click(object sender, EventArgs e)
        {
            LineFournisseur _form = new LineFournisseur(_p.entry_n);
            if (_form.ShowDialog() == DialogResult.OK)
            {
                poids_recep_tb.Text = PesageHeaderDao.updateWeightPesageHeader(_p.entry_n).ToString();
                getBLs(_p.entry_n);
            }
        }

        private void supprimer_bl_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int entry_n = int.Parse(BLs_DGV.CurrentRow.Cells["Entry N°"].Value.ToString());
                    PesageLineDao.deletePesageLine(entry_n);
                    poids_recep_tb.Text = PesageHeaderDao.updateWeightPesageHeader(_p.entry_n).ToString();
                    getBLs(_p.entry_n);
                }
            }
            catch { }
        }

        private void editer_b_Click(object sender, EventArgs e)
        {
            try
            {
                int entry_n = int.Parse(BLs_DGV.CurrentRow.Cells["Entry N°"].Value.ToString());
                LineFournisseur _form = new LineFournisseur(_p.entry_n, entry_n);
                if (_form.ShowDialog() == DialogResult.OK)
                {
                    poids_recep_tb.Text = PesageHeaderDao.updateWeightPesageHeader(_p.entry_n).ToString();
                    getBLs(_p.entry_n);
                }
            }
            catch { }
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchDBComp1_radioStateChanged(object sender, EventArgs e)
        {
            // Clear filters ans lists
            camion_cb.Items.Clear();
            list_camion.Clear();

            chauffeur_cb.Items.Clear();
            list_chauffeur.Clear();

            // Reload data
            loadData();
        }
    }
}
