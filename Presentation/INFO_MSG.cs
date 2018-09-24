using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionBascule
{
    public partial class INFO_MSG : Form
    {
        string MSG;
        public INFO_MSG(string MSG_)
        {
            InitializeComponent();
            MSG = MSG_;
        }
        
        private void Resultat_authentification_Load(object sender, EventArgs e)
        {
            label.Text = MSG;        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void INFO_MSG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
