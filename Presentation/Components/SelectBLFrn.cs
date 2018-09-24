using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionBascule.Business.commun;

namespace GestionBascule.Presentation.Components
{
    public partial class SelectBLFrn : UserControl
    {
        public BindingSource bs = new BindingSource();


        public SelectBLFrn()
        {
            InitializeComponent();
        }

        // Déclaration des délégués
        public delegate void EventDelegate(object sender, EventArgs e);

        // Déclaration des évènements qui utilisent ces délégués
        [Category("Configuration"), Browsable(true), Description("Evènement associé au radio states changed")]
        public event EventDelegate bLValidated;

        private void nrecep_tb_KeyUp(object sender, KeyEventArgs e)
        {
            filterData();
            this.Height = 223; 
        }

        public void filterData()
        {
            bs.Filter = string.Format("[No_] LIKE '%{0}%' ", nrecep_tb.Text);
        }

        private void SelectBLFrn_Leave(object sender, EventArgs e)
        {
            this.Height = 22;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nrecep_tb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Height = 22;
            if (bLValidated != null)
            {
                bLValidated(this, e);
            }
        }
    }
}
