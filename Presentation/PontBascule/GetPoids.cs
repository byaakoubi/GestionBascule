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
    public partial class GetPoids : Form
    {
        public string Value
        {
            get { return poids_tb.Text; }
        }

        public GetPoids()
        {
            InitializeComponent();
            valider_but.DialogResult = DialogResult.OK;
            annuler_but.DialogResult = DialogResult.Cancel;
        }

        public int calculerPoids()
        {
            int poids = 0;
            switch (unite_cb.Text)
            {
                case "Sac 10 Kg":
                    poids = 10 * int.Parse(qte_tb.Text);
                    break;
                case "Sac 20 Kg":
                    poids = 20 * int.Parse(qte_tb.Text);
                    break;
                case "Sac 30 Kg":
                    poids = 30 * int.Parse(qte_tb.Text);
                    break;
                case "Sac 40 Kg":
                    poids = 40 * int.Parse(qte_tb.Text);
                    break;
                case "Sac 50 Kg":
                    poids = 50 * int.Parse(qte_tb.Text);
                    break;
                case "Sac 100 Kg":
                    poids = 100 * int.Parse(qte_tb.Text);
                    break;
                case "Tonne 1000 Kg":
                    poids = 1000 * int.Parse(qte_tb.Text);
                    break;
                default:
                    poids = 0;
                    break;
            }

            return poids;
        }

        private void unite_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            poids_tb.Text = calculerPoids().ToString();
        }

        private void qte_tb_KeyUp(object sender, KeyEventArgs e)
        {
            poids_tb.Text = calculerPoids().ToString();
        }

        private void valider_but_Click(object sender, EventArgs e)
        {

        }
    }
}
