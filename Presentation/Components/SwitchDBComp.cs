using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBascule.Business.commun;

namespace GestionBascule.Presentation.Components
{
    public partial class SwitchDBComp : UserControl
    {
        public bool activateEvents = false;

        public SwitchDBComp()
        {
            InitializeComponent();
        }

        // Déclaration des délégués
        public delegate void RadioStateChanged(object sender, EventArgs e);

        // Déclaration des évènements qui utilisent ces délégués
        [Category("Configuration"), Browsable(true), Description("Evènement associé au radio states changed")]
        public event RadioStateChanged radioStateChanged;

        protected virtual void OnRadioStateChanged(EventArgs e)
        {
            if (radioStateChanged != null)
            {
                radioStateChanged(this, e);
            }
        }

        private void switchSomepaDB_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (activateEvents)
                if (switchSomepaDB_rb.Checked)
                {
                    // Switch DB
                    GlobVars.switchSomepaDB();
                    // call event function               
                    OnRadioStateChanged(e);
                }
        }

        private void switchNewDB_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (activateEvents)
                if (switchNewDB_rb.Checked)
                {
                    // Switch DB
                    GlobVars.switchNewDB();
                    // call event function
                    OnRadioStateChanged(e);
                }
        }
    }
}
