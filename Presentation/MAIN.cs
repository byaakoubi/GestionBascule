using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using GestionBascule.Business;
using GestionBascule.Business.commun;
using WeifenLuo.WinFormsUI.Docking;


namespace GestionBascule
{
    public partial class MAIN : Form
    {
        PontBascule formPBascule;

        public MAIN()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            DockPanel dockPanel = new DockPanel();
            dockPanel.Height = 25;
            dockPanel.Parent = this;
            dockPanel.Dock = DockStyle.Bottom;
            Controls.Add(dockPanel);
            Status_Panel.Parent = dockPanel;
            dockPanel.Controls.Add(Status_Panel);
            dockPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg != 3)
            {
                base.WndProc(ref m);
            }
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            GlobVars.parentForm = this;
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch //InvalidCastException exc
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            formPBascule = new PontBascule();
            formPBascule.MdiParent = GlobVars.parentForm;
            formPBascule.WindowState = FormWindowState.Maximized;
            userName_lab.Text = Environment.UserName;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pontBasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PontBascule form_ = new PontBascule();
            form_.MdiParent = GlobVars.parentForm;
            form_.WindowState = FormWindowState.Maximized;
            form_.Show();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConOperHeader form_ = new ConOperHeader();
            form_.MdiParent = GlobVars.parentForm;
            form_.WindowState = FormWindowState.Maximized;
            form_.Show();
        }

        private void PontBastoolStripButton_Click(object sender, EventArgs e)
        {
            formPBascule.Show();
            formPBascule.BringToFront();
        }

        private void operationsStripButton_Click(object sender, EventArgs e)
        {
            ConsultationOper form_ = new ConsultationOper();
            form_.MdiParent = GlobVars.parentForm;
            form_.WindowState = FormWindowState.Maximized;
            form_.Show();
        }

        private void GesConsotoolStripButton_Click(object sender, EventArgs e)
        {
            /*GestionConso form_ = new GestionConso();
            form_.MdiParent = GlobVars.parentForm;
            form_.WindowState = FormWindowState.Maximized;
            form_.Show();*/
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationOper form_ = new ConsultationOper();
            form_.MdiParent = GlobVars.parentForm;
            form_.WindowState = FormWindowState.Maximized;
            form_.Show();
        } 
    }
}