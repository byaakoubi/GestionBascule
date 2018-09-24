using System;
using System.Configuration;
using System.Data;
//sql library
using System.Data.SqlClient;
using System.Windows.Forms;
using GestionBascule.Business;
using GestionBascule.Business.commun;


namespace GestionBascule
{
    public partial class Historiques : Form
    {
        public Historiques()
        {
            InitializeComponent();
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

        BindingSource bs = new BindingSource();
        public void resetForm()
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oSQLConn;
            cmd.CommandText = "Select Date,Operation,NBL,Matricule_camion,Nom_chauffeur,Nom_founisseur,Destination,Nom_produit,Poids_fournisseur,Poids_entre,Poids_sortie,Poids_net,Stock_avant,Stock_apres from PESER_2";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "STOCK");
            bs.DataSource = ds.Tables["STOCK"];
            STOCK_DGV.DataSource = bs;
            oSQLConn.Close();
        }

        // fonction filtrage datagridviex
        public void filterDGV()
        {
            DateTime currentdate = DateTime.Now;
            DateTime datetest = DateTime.Parse(date_cb.Text);
            /*Dp 1 jour
            Dp 1 semaine
            Dp 1 mois
            Dp 1 ans*/
            switch (date_cb.Text)
            {
                case "Dp 1 jour": datetest = DateTime.Now.AddDays(-1);
                    break;
                case "Dp 1 semaine": datetest = DateTime.Now.AddDays(-7);
                    break;
                case "Dp 1 mois": datetest = DateTime.Now.AddMonths(-1);
                    break;
                case "Dp 1 ans": datetest = DateTime.Now.AddYears(-1);
                    break;
                default: datetest = DateTime.Parse("01/01/2010 00:00:00");
                    break;
            }
            /*switch (Operateur_cb.Text)
            {                
                case ">": bs.Filter = string.Format("reference LIKE '%{0}%' AND designation LIKE '%{1}%' AND qte > '{2}'", operation_tb.Text, NBL_tb.Text,qte);
                    break;
                case "<": bs.Filter = string.Format("reference LIKE '%{0}%' AND designation LIKE '%{1}%' AND qte < '{2}'", operation_tb.Text, NBL_tb.Text, qte);
                    break;
                case "=": bs.Filter = string.Format("reference LIKE '%{0}%' AND designation LIKE '%{1}%' AND qte = '{2}'", operation_tb.Text, NBL_tb.Text, qte);
                    break;
                default: bs.Filter = string.Format("reference LIKE '%{0}%' AND designation LIKE '%{1}%' ", operation_tb.Text, NBL_tb.Text);
                    break;            
            */
            bs.Filter = string.Format("date > '{0}' AND nom_produit LIKE '%{1}%'", datetest, produit_cb.Text);
        }

        private void Suivie_Stock_Load(object sender, EventArgs e)
        {
            resetForm();
        }

        private void date_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDGV();
        }

        private void produit_cb_KeyUp(object sender, KeyEventArgs e)
        {
            filterDGV();
        }

        private void Suivie_Stock_Activated(object sender, EventArgs e)
        {
            resetForm();
        }

        private void date_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            filterDGV();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                //Action si l'utilisateur est sûr
                int NBL = int.Parse(STOCK_DGV.CurrentRow.Cells["NBL"].Value.ToString());
                //DLLs.DBUtillity.delete_peser2(NBL);
                INFO_MSG INFO_MSG__ = new INFO_MSG("Traitement OK");
                INFO_MSG__.ShowDialog();
                }
                catch (Exception ) {  }
            }  
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
