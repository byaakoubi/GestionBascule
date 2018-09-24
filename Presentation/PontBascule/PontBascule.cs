using GestionBascule.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using GestionBascule.Business;
using GestionBascule.Business.commun;

namespace GestionBascule
{
	public partial class PontBascule : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((msg.WParam.ToInt32() == 13))
            {
                SendKeys.Send("{Tab}");
                return true;
            }
            if (keyData == Keys.F1)
            {
                pes_1_entre_b.PerformClick();
                return true;
            }
            else if (keyData == Keys.F2)
            {
                pes_1_sortie_b.PerformClick();
                return true;
            }
            else if (keyData == Keys.F3)
            {
                pes_2_b.PerformClick();
                return true;
            }
            else if (keyData == Keys.F4)
            {
                edit_b.PerformClick();
                return true;
            }
            else if (keyData == Keys.F5)
            {
                delete_b.PerformClick();
                return true;
            }
            else if (keyData == Keys.F6)
            {
                refresh_b.PerformClick();
                return true;
            }
            else if (keyData == Keys.F10)
            {
                preferences_b.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public PontBascule()
		{
			InitializeComponent();
		}

        public void getPesageTransList()
        {
            SqlConnection oSQLConn = new SqlConnection(GlobVars.navisionDBCnx);
            oSQLConn.Open();
            SqlCommand cmd_p1 = new SqlCommand();

            cmd_p1.Connection = oSQLConn;

            cmd_p1.CommandText = "Select [Type Opération],[Entry N°],'Type Operation' = CASE [Type Opération] WHEN 1 THEN 'Entrée Stock' ELSE 'Sortie Stock' END," + 
            "[Date Entrée],[N° Ticket],[Matricule Camion],[Nom Chauffeur],Pesage1 " + 
            "from [SOMEPA$Pesage Header] WHERE Etat=0";


            SqlDataAdapter sda_p1 = new SqlDataAdapter(cmd_p1);

            DataSet ds_p1 = new DataSet();

            sda_p1.Fill(ds_p1, "Pesage_Header");

            Camion_Trans_DGV.DataSource = ds_p1.Tables["Pesage_Header"];

            Camion_Trans_DGV.Columns["Type Opération"].Visible = false;

            oSQLConn.Close();
        }


        private void dashboardPesage_Load(object sender, EventArgs e)
        {

            SerialPort1.StopBits = StopBits.One;
            SerialPort2.StopBits = StopBits.One;
            // Ouverture port
            SerialPort1.PortName = GlobVars.portName;
            try
            {
                SerialPort1.Close();
                SerialPort1.Open();
                status_bas_pb.Image = Resources.ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            getPesageTransList();

        }

		// This delegate enables asynchronous calls for setting
		// the text property on a TextBox control.
		delegate void SetTextCallback(string text);


		private void Connect_Click(object sender, EventArgs e)
		{
			try
			{
				SerialPort1.Close();
				SerialPort1.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.ToString () );
				return;
			}
			MessageBox.Show( "COM port opened and successfully.");

        }

		private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
            System.Threading.Thread.Sleep(100);
			SetText(SerialPort1.ReadExisting());
		}

		private void SetText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
            if (AfficheurBascule_lab.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				Invoke(d, new object[] { text });
			}
			else
			{
                AfficheurBascule_lab.Text = "";
                int index = text.IndexOf("kg");
                AfficheurBascule_lab.Text += text.Substring(0, index + 2);
			}
		}

		private void sendReadWeight_Click(object sender, EventArgs e)
		{
            try
            {
                byte[] bytesToSend = new byte[3] { 0x58, 0x6E, 0x0D };
                SerialPort1.Write(bytesToSend, 0, 3);
            }
            catch
            {
                INFO_MSG form_ = new INFO_MSG("Problème communication");
                form_.ShowDialog();
            }
		}

		
		private void butSendRandom_Click(object sender, EventArgs e)
		{
			this.TimerReadWeight.Start();
		}

        private void EnumerateComPorts_Click(object sender, EventArgs e)
		{

			MessageBox.Show(String.Join(",", System.IO.Ports.SerialPort.GetPortNames() ) + " are found on your machine."  );

		}

        private void timerReadWeight_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] bytesToSend = new byte[3] { 0x58, 0x6E, 0x0D };
                SerialPort1.Write(bytesToSend, 0, 3);
            }
            catch
            {
            }
        }

        private void pesage_1_Entre_handler(object sender, EventArgs e)
        {
            double poids = 0;
            try
            {
                int index = AfficheurBascule_lab.Text.IndexOf("kg");
                poids = double.Parse(AfficheurBascule_lab.Text.Substring(0, index));
            }
            catch {}

            EntreeStock form_ = new EntreeStock(poids);
            form_.ShowDialog();
            this.getPesageTransList();

        }

        private void pesage_1_Sortie_handler(object sender, EventArgs e)
        {
            double poids = 0;
            try
            {
                int index = AfficheurBascule_lab.Text.IndexOf("kg");
                poids = double.Parse(AfficheurBascule_lab.Text.Substring(0, index));
            }
            catch { }
            SortieStock form_ = new SortieStock(poids);
            form_.ShowDialog();
            getPesageTransList();
        }

        private void delete_pes_1_handler(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Action si l'utilisateur est sûr
                int Entry_N = int.Parse(Camion_Trans_DGV.CurrentRow.Cells["Entry N°"].Value.ToString());
                Business.PesageHeaderDao.deletePesageHeader(Entry_N);
                getPesageTransList();
            }     
        }

        private void pesage_2_handler(object sender, EventArgs e)
        {
            pesage_2();
        }

        private void listTransit_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pesage_2();
        }

        private void pesage_2()
        {
            int operation = 0, index = 0;
            double poids = 0;
            int entry_n = 0;
            try
            {
                operation = int.Parse(Camion_Trans_DGV.CurrentRow.Cells[0].Value.ToString());
                entry_n = int.Parse(Camion_Trans_DGV.CurrentRow.Cells["Entry N°"].Value.ToString());
                index = AfficheurBascule_lab.Text.IndexOf("kg");
                poids = double.Parse(AfficheurBascule_lab.Text.Substring(0, index));
            }
            catch {}

            switch (operation)
            {
                case 1:
                    EntreeStock form_1 = new EntreeStock(entry_n, poids);
                    form_1.ShowDialog();
                    getPesageTransList();
                    break;
                case 2:
                    SortieStock form_2 = new SortieStock(entry_n, poids);
                    form_2.ShowDialog();
                    getPesageTransList();
                    break;
                default:
                    break;
            }
        }

        private void read_weight(object sender, EventArgs e)
        {
            try
            {
                byte[] bytesToSend = new byte[3] { 0x58, 0x6E, 0x0D };
                SerialPort1.Write(bytesToSend, 0, 3);
            }
            catch
            {
                INFO_MSG form_ = new INFO_MSG("Problème communication");
                form_.ShowDialog();
            }
        }

        private void preferences_b_Click(object sender, EventArgs e)
        {
            ConfigBascule form_ = new ConfigBascule(this);
            form_.Show();
        }

        private void DashboardPesage_Leave(object sender, EventArgs e)
        {
            SerialPort1.Close();
            SerialPort2.Close();
        }

        private void edit_b_Click(object sender, EventArgs e)
        {
            int entry_n, typ_op;
            try
            {
                entry_n = int.Parse(Camion_Trans_DGV.CurrentRow.Cells["Entry N°"].Value.ToString());
                typ_op = int.Parse(Camion_Trans_DGV.CurrentRow.Cells["Type Opération"].Value.ToString());
                switch (typ_op)
                {
                    case 1:
                        EntreeStock form_s = new EntreeStock(entry_n);
                        form_s.ShowDialog();
                        getPesageTransList();
                        break;
                    case 2:
                        SortieStock form_e = new SortieStock(entry_n);
                        form_e.ShowDialog();
                        getPesageTransList();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
            }
        }

        private void PontBascule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }

        }

        private void quit_b_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rafraichir_but_Click(object sender, EventArgs e)
        {
            getPesageTransList();
        }
	}
}