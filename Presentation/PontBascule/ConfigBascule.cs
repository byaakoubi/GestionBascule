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

namespace GestionBascule
{
	public partial class ConfigBascule : Form
    {
        private PontBascule owner;
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

        public ConfigBascule(PontBascule _owner)
		{
			InitializeComponent();
            owner = _owner;

            propertyGrid1.SelectedObject = owner.SerialPort1;
            propertyGrid2.SelectedObject = owner.SerialPort2;
		}

		// This delegate enables asynchronous calls for setting
		// the text property on a TextBox control.
		delegate void SetTextCallback(string text);


		private void Connect_Click(object sender, EventArgs e)
		{
			try
			{
                owner.SerialPort1.Close();
                owner.SerialPort1.Open();
                owner.status_bas_pb.Image = Resources.ok;
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.ToString () );
				return;
			}
			MessageBox.Show( "COM port opened and successfully.");

		}

        private void EnumerateComPorts_Click(object sender, EventArgs e)
		{

			MessageBox.Show(String.Join(",", System.IO.Ports.SerialPort.GetPortNames() ) + " are found on your machine."  );

		}

        private void Connect_Vir_Com_handler(object sender, EventArgs e)
        {
            try
            {
                owner.SerialPort2.Close();
                owner.SerialPort2.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            MessageBox.Show("COM port opened and successfully.");
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Poids_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytesToSend = Encoding.ASCII.GetBytes("1028kg");

                owner.SerialPort2.Write(bytesToSend, 0, 6);
            }
            catch
            {
                INFO_MSG form_ = new INFO_MSG("Problème communication");
                form_.ShowDialog();
            }
        }
	}
}