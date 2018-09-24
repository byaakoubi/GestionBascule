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
    public partial class LineClient : Form
    {
        PesageLineModel _p = new PesageLineModel();

        /// <summary>
        /// operation = 0 --> new entry
        /// operation = 1 --> update old
        /// </summary>
        int operation;
        
        List<string> list_code_clt = new List<string>();
        List<string> list_nom_clt = new List<string>();
        List<string> list_num_article = new List<string>();
        List<string> list_desig_article = new List<string>();

        /// <summary>
        /// constructor for new entry
        /// </summary>
        /// <param name="poids_bascule_"></param>
        /// <param name="owner_"></param>
        public LineClient(int header_entry_n)
        {
            InitializeComponent();
            _p.header_entry_n = header_entry_n;
            operation = 0;
        }

        /// <summary>
        /// constructor for update old entry
        /// </summary>
        /// <param name="poids_bascule_"></param>
        /// <param name="owner_"></param>
        /// <param name="entry_n"></param>
        public LineClient(int header_entry_n, int entry_n)
        {
            InitializeComponent();
            operation = 1;
            _p = PesageLineDao.getPesageLine(entry_n);

            selectBLClient1.nrecep_tb.Text = _p.n_reception;

            code_clt_cb.Text = _p.n_client;
            nom_clt_cb.Text = _p.nom;

            num_article_1_cb.Text = _p.num_article_1;
            desig_article_1_cb.Text = _p.desig_article_1;
            qte_article_1_tb.Text = _p.qte_article_1.ToString();

            num_article_2_cb.Text = _p.num_article_2;
            desig_article_2_cb.Text = _p.desig_article_2;
            qte_article_2_tb.Text = _p.qte_article_2.ToString();

            num_article_3_cb.Text = _p.num_article_3;
            desig_article_3_cb.Text = _p.desig_article_3;
            qte_article_3_tb.Text = _p.qte_article_3.ToString();

            num_article_4_cb.Text = _p.num_article_4;
            desig_article_4_cb.Text = _p.desig_article_4;
            qte_article_4_tb.Text = _p.qte_article_4.ToString();

            num_article_5_cb.Text = _p.num_article_5;
            desig_article_5_cb.Text = _p.desig_article_5;
            qte_article_5_tb.Text = _p.qte_article_5.ToString();


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

        private int WithErrors()
        {
            if (selectBLClient1.nrecep_tb.Text.Trim() == String.Empty)
                return 7;
            else if (code_clt_cb.Text.Trim() == String.Empty)
                return 8;
            else if (nom_clt_cb.Text.Trim() == String.Empty)
                return 9;
            else if (num_article_1_cb.Text.Trim() == String.Empty)
                return 12;
            else if (desig_article_1_cb.Text.Trim() == String.Empty)
                return 13;
            else
                return 0;
        }

        private void ClearForm()
        {
            code_clt_cb.Text = "";
            nom_clt_cb.Text = "";

            num_article_1_cb.Text = "";
            desig_article_1_cb.Text = "";
            qte_article_1_tb.Text = "0";

            num_article_2_cb.Text = "";
            desig_article_2_cb.Text = "";
            qte_article_2_tb.Text = "0";

            num_article_3_cb.Text = "";
            desig_article_3_cb.Text = "";
            qte_article_3_tb.Text = "0";

            num_article_4_cb.Text = "";
            desig_article_4_cb.Text = "";
            qte_article_4_tb.Text = "0";

            num_article_5_cb.Text = "";
            desig_article_5_cb.Text = "";
            qte_article_5_tb.Text = "0";
        }

        private void loadData()
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmdBLs = new SqlCommand();

            cmd.Connection = oSQLConn;
            cmdBLs.Connection = oSQLConn;

            SqlDataReader reader ;

            // client
            cmd.CommandText = "Select [No_],[Name]  from" + GlobVars.dbtables.clientTab;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                code_clt_cb.Items.Add(reader["No_"].ToString());
                list_code_clt.Add(reader["No_"].ToString());
                nom_clt_cb.Items.Add(reader["Name"].ToString());
                list_nom_clt.Add(reader["Name"].ToString());
            }
            reader.Close();
            // article
            cmd.CommandText = "Select [No_],[Description] from" + GlobVars.dbtables.articleTab;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string no_, description;
                no_ = reader["No_"].ToString();
                description = reader["Description"].ToString();

                num_article_1_cb.Items.Add(no_);
                num_article_2_cb.Items.Add(no_);
                num_article_3_cb.Items.Add(no_);
                num_article_4_cb.Items.Add(no_);
                num_article_5_cb.Items.Add(no_);
                list_num_article.Add(no_);
                desig_article_1_cb.Items.Add(description);
                desig_article_2_cb.Items.Add(description);
                desig_article_3_cb.Items.Add(description);
                desig_article_4_cb.Items.Add(description);
                desig_article_5_cb.Items.Add(description);
                list_desig_article.Add(description);
            }
            reader.Close();

            cmdBLs.CommandText = "SELECT distinct [No_] from " + GlobVars.dbtables.cltblheaderTab;

            SqlDataAdapter sda = new SqlDataAdapter(cmdBLs);
            DataSet ds = new DataSet();
            sda.Fill(ds, "No_");
            selectBLClient1.bs.DataSource = ds.Tables["No_"];
            selectBLClient1.dataGridView1.DataSource = selectBLClient1.bs;

            oSQLConn.Close();

        }

        private void Pesage1Sortie_Load(object sender, EventArgs e)
        {
            loadData();
            switchDBComp1.switchSomepaDB_rb.Checked = GlobVars.dbtables.isSomepaDB;
            switchDBComp1.switchNewDB_rb.Checked = GlobVars.dbtables.isNewDB;
            switchDBComp1.activateEvents = true;
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            int verifData = WithErrors();
            if (verifData != 0)
            {
                INFO_MSG form = new INFO_MSG("Compléter la saisie : \n" + GlobVars.errorDictionary[verifData]);
                form.ShowDialog();
                return;
            }

            _p.n_reception = selectBLClient1.nrecep_tb.Text;

            _p.n_client = code_clt_cb.Text;
            _p.n_fournisseur = "";
            _p.nom = nom_clt_cb.Text;

            _p.num_article_1 = num_article_1_cb.Text;
            _p.desig_article_1 = desig_article_1_cb.Text;
            _p.qte_article_1 = double.Parse(qte_article_1_tb.Text);

            _p.num_article_2 = num_article_2_cb.Text;
            _p.desig_article_2 = desig_article_2_cb.Text;
            _p.qte_article_2 = double.Parse(qte_article_2_tb.Text);

            _p.num_article_3 = num_article_3_cb.Text;
            _p.desig_article_3 = desig_article_3_cb.Text;
            _p.qte_article_3 = double.Parse(qte_article_3_tb.Text);

            _p.num_article_4 = num_article_4_cb.Text;
            _p.desig_article_4 = desig_article_4_cb.Text;
            _p.qte_article_4 = double.Parse(qte_article_4_tb.Text);

            _p.num_article_5 = num_article_5_cb.Text;
            _p.desig_article_5 = desig_article_5_cb.Text;
            _p.qte_article_5 = double.Parse(qte_article_5_tb.Text);

            int ret = new int();

            switch (operation)
            {
                case 0:
                    ret = PesageLineDao.savePesageLine(_p);
                    break;
                case 1:
                    ret = PesageLineDao.updatePesageLine(_p);
                    break;
                default:
                    break;
            }

            if (ret == 0)
            {
                this.DialogResult = DialogResult.OK;
            }


        }

        private void num_article_1_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [Description] from " + GlobVars.dbtables.articleTab + " where [No_]=@num_article";
            cmd.Parameters.Add("@num_article", SqlDbType.VarChar).Value = num_article_1_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                desig_article_1_cb.Text = reader["Description"].ToString();
            }
            reader.Close();
            
        }

        private void desig_article_1_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [No_] from " + GlobVars.dbtables.articleTab + " where [Description]=@desig_article";
            cmd.Parameters.Add("@desig_article", SqlDbType.VarChar).Value = desig_article_1_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                num_article_1_cb.Text = reader["No_"].ToString();
            }
            reader.Close();

        }

        private void num_article_2_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [Description] from " + GlobVars.dbtables.articleTab + " where [No_]=@num_article";
            cmd.Parameters.Add("@num_article", SqlDbType.VarChar).Value = num_article_2_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                desig_article_2_cb.Text = reader["Description"].ToString();
            }
            reader.Close();

        }

        private void desig_article_2_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [No_] from " + GlobVars.dbtables.articleTab + " where [Description]=@desig_article";
            cmd.Parameters.Add("@desig_article", SqlDbType.VarChar).Value = desig_article_2_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                num_article_2_cb.Text = reader["No_"].ToString();
            }
            reader.Close();

        }

        private void num_article_3_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [Description] from " + GlobVars.dbtables.articleTab + " where [No_]=@num_article";
            cmd.Parameters.Add("@num_article", SqlDbType.VarChar).Value = num_article_3_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                desig_article_3_cb.Text = reader["Description"].ToString();
            }
            reader.Close();

        }

        private void desig_article_3_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [No_] from " + GlobVars.dbtables.articleTab + " where [Description]=@desig_article";
            cmd.Parameters.Add("@desig_article", SqlDbType.VarChar).Value = desig_article_3_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                num_article_3_cb.Text = reader["No_"].ToString();
            }
            reader.Close();

        }

        private void num_article_4_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [Description] from " + GlobVars.dbtables.articleTab + " where [No_]=@num_article";
            cmd.Parameters.Add("@num_article", SqlDbType.VarChar).Value = num_article_4_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                desig_article_4_cb.Text = reader["Description"].ToString();
            }
            reader.Close();

        }

        private void desig_article_4_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [No_] from " + GlobVars.dbtables.articleTab + " where [Description]=@desig_article";
            cmd.Parameters.Add("@desig_article", SqlDbType.VarChar).Value = desig_article_4_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                num_article_4_cb.Text = reader["No_"].ToString();
            }
            reader.Close();

        }

        private void num_article_5_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [Description] from " + GlobVars.dbtables.articleTab + " where [No_]=@num_article";
            cmd.Parameters.Add("@num_article", SqlDbType.VarChar).Value = num_article_5_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                desig_article_5_cb.Text = reader["Description"].ToString();
            }
            reader.Close();

        }

        private void desig_article_5_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [No_] from " + GlobVars.dbtables.articleTab + " where [Description]=@desig_article";
            cmd.Parameters.Add("@desig_article", SqlDbType.VarChar).Value = desig_article_5_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                num_article_5_cb.Text = reader["No_"].ToString();
            }
            reader.Close();

        }

        private void code_clt_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [Name]  from " + GlobVars.dbtables.clientTab + " where [No_]=@code_clt";
            cmd.Parameters.Add("@code_clt", SqlDbType.VarChar).Value = code_clt_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nom_clt_cb.Text = reader["Name"].ToString();
            }
            reader.Close();
        }

        private void nom_clt_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            SqlDataReader reader;
            cmd.CommandText = "Select [No_]  from " + GlobVars.dbtables.clientTab + " where [Name]=@nom_clt";
            cmd.Parameters.Add("@nom_clt", SqlDbType.VarChar).Value = nom_clt_cb.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                code_clt_cb.Text = reader["No_"].ToString();
            }
            reader.Close();
        }
        private void code_clt_cb_KeyUp(object sender, KeyEventArgs e)
        {
            code_clt_cb.Items.Clear();
            string code = code_clt_cb.Text;
            foreach (string element in list_code_clt)
            {
                if (element.ToUpper().Contains(code.ToUpper()))
                    code_clt_cb.Items.Add(element);
            }
            code_clt_cb.SelectionStart = code_clt_cb.Text.Length;
            code_clt_cb.SelectionLength = 0;

        }

        private void nom_clt_cb_KeyUp(object sender, KeyEventArgs e)
        {
            nom_clt_cb.Items.Clear();
            string nom = nom_clt_cb.Text;
            foreach (string element in list_nom_clt)
            {
                if (element.ToUpper().Contains(nom.ToUpper()))
                    nom_clt_cb.Items.Add(element);
            }
            nom_clt_cb.SelectionStart = nom_clt_cb.Text.Length;
            nom_clt_cb.SelectionLength = 0;
        }

        private void num_article_1_cb_KeyUp(object sender, KeyEventArgs e)
        {
            num_article_1_cb.Items.Clear();
            string num = num_article_1_cb.Text;
            foreach (string element in list_num_article)
            {
                if (element.ToUpper().Contains(num.ToUpper()))
                    num_article_1_cb.Items.Add(element);
            }
            num_article_1_cb.SelectionStart = num_article_1_cb.Text.Length;
            num_article_1_cb.SelectionLength = 0;
        }

        private void desig_article_1_cb_KeyUp(object sender, KeyEventArgs e)
        {
            desig_article_1_cb.Items.Clear();
            string desig = desig_article_1_cb.Text;
            foreach (string element in list_desig_article)
            {
                if (element.ToUpper().Contains(desig.ToUpper()))
                    desig_article_1_cb.Items.Add(element);
            }
            desig_article_1_cb.SelectionStart = desig_article_1_cb.Text.Length;
            desig_article_1_cb.SelectionLength = 0;
        }

        private void num_article_2_cb_KeyUp(object sender, KeyEventArgs e)
        {
            num_article_2_cb.Items.Clear();
            string num = num_article_2_cb.Text;
            foreach (string element in list_num_article)
            {
                if (element.ToUpper().Contains(num.ToUpper()))
                    num_article_2_cb.Items.Add(element);
            }
            num_article_2_cb.SelectionStart = num_article_2_cb.Text.Length;
            num_article_2_cb.SelectionLength = 0;
        }

        private void desig_article_2_cb_KeyUp(object sender, KeyEventArgs e)
        {
            desig_article_2_cb.Items.Clear();
            string desig = desig_article_2_cb.Text;
            foreach (string element in list_desig_article)
            {
                if (element.ToUpper().Contains(desig.ToUpper()))
                    desig_article_2_cb.Items.Add(element);
            }
            desig_article_2_cb.SelectionStart = desig_article_2_cb.Text.Length;
            desig_article_2_cb.SelectionLength = 0;
        }

        private void num_article_3_cb_KeyUp(object sender, KeyEventArgs e)
        {
            num_article_3_cb.Items.Clear();
            string num = num_article_3_cb.Text;
            foreach (string element in list_num_article)
            {
                if (element.ToUpper().Contains(num.ToUpper()))
                    num_article_3_cb.Items.Add(element);
            }
            num_article_3_cb.SelectionStart = num_article_3_cb.Text.Length;
            num_article_3_cb.SelectionLength = 0;
        }

        private void desig_article_3_cb_KeyUp(object sender, KeyEventArgs e)
        {
            desig_article_3_cb.Items.Clear();
            string desig = desig_article_3_cb.Text;
            foreach (string element in list_desig_article)
            {
                if (element.ToUpper().Contains(desig.ToUpper()))
                    desig_article_3_cb.Items.Add(element);
            }
            desig_article_3_cb.SelectionStart = desig_article_3_cb.Text.Length;
            desig_article_3_cb.SelectionLength = 0;
        }

        private void num_article_4_cb_KeyUp(object sender, KeyEventArgs e)
        {
            num_article_4_cb.Items.Clear();
            string num = num_article_4_cb.Text;
            foreach (string element in list_num_article)
            {
                if (element.ToUpper().Contains(num.ToUpper()))
                    num_article_4_cb.Items.Add(element);
            }
            num_article_4_cb.SelectionStart = num_article_4_cb.Text.Length;
            num_article_4_cb.SelectionLength = 0;
        }

        private void desig_article_4_cb_KeyUp(object sender, KeyEventArgs e)
        {
            desig_article_4_cb.Items.Clear();
            string desig = desig_article_4_cb.Text;
            foreach (string element in list_desig_article)
            {
                if (element.ToUpper().Contains(desig.ToUpper()))
                    desig_article_4_cb.Items.Add(element);
            }
            desig_article_4_cb.SelectionStart = desig_article_4_cb.Text.Length;
            desig_article_4_cb.SelectionLength = 0;
        }

        private void num_article_5_cb_KeyUp(object sender, KeyEventArgs e)
        {
            num_article_5_cb.Items.Clear();
            string num = num_article_5_cb.Text;
            foreach (string element in list_num_article)
            {
                if (element.ToUpper().Contains(num.ToUpper()))
                    num_article_5_cb.Items.Add(element);
            }
            num_article_5_cb.SelectionStart = num_article_5_cb.Text.Length;
            num_article_5_cb.SelectionLength = 0;
        }

        private void desig_article_5_cb_KeyUp(object sender, KeyEventArgs e)
        {
            desig_article_5_cb.Items.Clear();
            string desig = desig_article_5_cb.Text;
            foreach (string element in list_desig_article)
            {
                if (element.ToUpper().Contains(desig.ToUpper()))
                    desig_article_5_cb.Items.Add(element);
            }
            desig_article_5_cb.SelectionStart = desig_article_5_cb.Text.Length;
            desig_article_5_cb.SelectionLength = 0;
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculerPoids_1_Click(object sender, EventArgs e)
        {
            GetPoids _form = new GetPoids();
            _form.ShowDialog();
            qte_article_1_tb.Text = _form.Value;
        }

        private void calculerPoids_2_Click(object sender, EventArgs e)
        {
            GetPoids _form = new GetPoids();
            _form.ShowDialog();
            qte_article_2_tb.Text = _form.Value;
        }

        private void calculerPoids_3_Click(object sender, EventArgs e)
        {
            GetPoids _form = new GetPoids();
            _form.ShowDialog();
            qte_article_3_tb.Text = _form.Value;
        }

        private void calculerPoids_4_Click(object sender, EventArgs e)
        {
            GetPoids _form = new GetPoids();
            _form.ShowDialog();
            qte_article_4_tb.Text = _form.Value;
        }

        private void calculerPoids_5_Click(object sender, EventArgs e)
        {
            GetPoids _form = new GetPoids();
            _form.ShowDialog();
            qte_article_5_tb.Text = _form.Value;
        }

        private void getBLClt()
        {
            ClearForm();
            PesageLineModel _p2 = new PesageLineModel();
            if (PesageLineDao.getBLClientFromNav(selectBLClient1.nrecep_tb.Text, _p2))
            {
                code_clt_cb.Text = _p2.n_client;
                code_clt_cb_SelectedIndexChanged(code_clt_cb, new EventArgs());

                num_article_1_cb.Text = _p2.num_article_1;
                num_article_1_cb_SelectedIndexChanged(num_article_1_cb, new EventArgs());
                qte_article_1_tb.Text = _p2.qte_article_1.ToString();

                num_article_2_cb.Text = _p2.num_article_2;
                num_article_2_cb_SelectedIndexChanged(num_article_2_cb, new EventArgs());
                qte_article_2_tb.Text = _p2.qte_article_2.ToString();

                num_article_3_cb.Text = _p2.num_article_3;
                num_article_3_cb_SelectedIndexChanged(num_article_3_cb, new EventArgs());
                qte_article_3_tb.Text = _p2.qte_article_3.ToString();

                num_article_4_cb.Text = _p2.num_article_4;
                num_article_4_cb_SelectedIndexChanged(num_article_4_cb, new EventArgs());
                qte_article_4_tb.Text = _p2.qte_article_4.ToString();

                num_article_5_cb.Text = _p2.num_article_5;
                num_article_5_cb_SelectedIndexChanged(num_article_5_cb, new EventArgs());
                qte_article_5_tb.Text = _p2.qte_article_5.ToString();
            }
        }


        private void switchDBComp1_radioStateChanged(object sender, EventArgs e)
        {
            // Clear filters ans lists
            code_clt_cb.Items.Clear();
            list_code_clt.Clear();

            nom_clt_cb.Items.Clear();
            list_nom_clt.Clear();

            num_article_1_cb.Items.Clear();
            num_article_2_cb.Items.Clear();
            num_article_3_cb.Items.Clear();
            num_article_4_cb.Items.Clear();
            num_article_5_cb.Items.Clear();
            list_num_article.Clear();

            desig_article_1_cb.Items.Clear();
            desig_article_2_cb.Items.Clear();
            desig_article_3_cb.Items.Clear();
            desig_article_4_cb.Items.Clear();
            desig_article_5_cb.Items.Clear();
            list_desig_article.Clear();

            // Reload data
            loadData();
        }

        private void selectBLClient1_bLValidated(object sender, EventArgs e)
        {
            getBLClt();
        }
        /*

        private void nrecep_tb_KeyUp(object sender, KeyEventArgs e)
        {
            filterData();
            panel1.Visible = true;
        }

        private void nrecep_tb_Leave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nrecep_uc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            panel1.Visible = false;
            getBLClt();
        }

        public void filterData()
        {
            bs.Filter = string.Format("[No_] LIKE '%{0}%' ", nrecep_uc.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nrecep_uc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            panel1.Visible = false;
            getBLClt();
        }*/
    }
}
