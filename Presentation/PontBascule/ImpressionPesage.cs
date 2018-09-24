using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBascule
{
    public partial class ImpressionPesage : Form
    {
        public DataSet ds;
        /// <summary>
        /// 0 --> Header
        /// 1 --> Line
        /// </summary>
        public int operation;
        public ImpressionPesage(int _oper, DataSet ds_)
        {
            InitializeComponent();
            operation = _oper;
            ds = ds_;
        }

        private void EtatConsommation_Load(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 0:
                    ReportsCR.pesageHeaderReport objRptHeader = new ReportsCR.pesageHeaderReport();
                    objRptHeader.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = objRptHeader;
                    crystalReportViewer1.Refresh();
                    break;
                case 1:
                    ReportsCR.pesageLineReport objRptLine = new ReportsCR.pesageLineReport();
                    objRptLine.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = objRptLine;
                    crystalReportViewer1.Refresh();
                    break;
                default:
                    break;
            }
        }
    }
}
