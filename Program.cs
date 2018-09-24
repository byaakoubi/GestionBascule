using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.Collections;
using System.Windows.Documents;
using System.Data.SqlClient;
using GestionBascule.Business;
using GestionBascule.Business.commun;

namespace GestionBascule
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // vérification de la licence
            /*
             ManagementObjectSearcher searcher = new ManagementObjectSearcher ("SELECT * FROM Win32_DiskDrive");
             List<HardDrive> hdCollection = new List<HardDrive>();
             foreach (ManagementObject wmi_HD in searcher.Get())
             {
                 HardDrive hd = new HardDrive();
                 hd.Model = wmi_HD["Model"].ToString();
                 hd.Type = wmi_HD["InterfaceType"].ToString();
                 hd.SerialNo = wmi_HD["SerialNumber"].ToString(); 
                 hdCollection.Add(hd);
             }
             // SIMM HD  Serial :2020202057202d44435732435745345832333635
             // PC BILEL 2020202020202020585731393941413334373837
             if (hdCollection[0].SerialNo == "")
             {
                 INFO_MSG form_ = new INFO_MSG("License invalide");
                 form_.ShowDialog();
                 return;
             }

            */
            GlobVars.companyName = "Somepa";
            GlobVars.navisionDBCnx = "";
            GlobVars.automateDBCnx = new configConnection("", "", "", "", "", "");
            GlobVars.dbtables = new GlobVars.DBTableClass();
            // read XML FILE
            int RET = xmlUtilDao.getExtXMLConfig(@"config-app.xml");
            
            //GlobVars.Connexion_String = "Server=192.168.1.4\\QUALIPRO;Database=GESTION_CAMION;User=mohamed;Password=mohamed";
            //GlobVars.Connexion_String = "Server=localhost;Database=DATA_BASE_COMMERCIAL_SIMM; Trusted_Connection=Yes";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN());
        }
    }
}
