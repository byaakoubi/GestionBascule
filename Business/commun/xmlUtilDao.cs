using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GestionBascule.Business.commun
{
    class xmlUtilDao
    {

        // Parseur XML
        public static int getExtXMLConfig(string nom_fichier)
        {
            string path = @nom_fichier;
            string strFilename = path;
            XmlDocument docXML = new XmlDocument();
            if (File.Exists(strFilename))
            {
                // Open the XML file
                docXML.Load(strFilename);
                GlobVars.navisionDBCnx = docXML.DocumentElement.GetAttribute("Navision_DB_Cnx");
                GlobVars.automateDBCnx.Data_Source = docXML.DocumentElement.GetAttribute("Automate_Data_Source");
                GlobVars.automateDBCnx.PORT = docXML.DocumentElement.GetAttribute("Automate_DBPort");
                GlobVars.automateDBCnx.Network_Library = docXML.DocumentElement.GetAttribute("Automate_DBNetwork_Library");
                GlobVars.automateDBCnx.Initial_Catalog = docXML.DocumentElement.GetAttribute("Automate_DBInitial_Catalog");
                GlobVars.automateDBCnx.User_id = docXML.DocumentElement.GetAttribute("Automate_DBUserName");
                GlobVars.automateDBCnx.Password = docXML.DocumentElement.GetAttribute("Automate_DBPassword");
                GlobVars.portName = docXML.DocumentElement.GetAttribute("Balance_Port");
                GlobVars.maxEcartWeight = int.Parse(docXML.DocumentElement.GetAttribute("Max_Ecart_Weight"));
            }
            GlobVars.automateDBCnxString = "Data Source=" + GlobVars.automateDBCnx.Data_Source + "," + GlobVars.automateDBCnx.PORT;
            GlobVars.automateDBCnxString += ";Network Library=" + GlobVars.automateDBCnx.Network_Library;
            GlobVars.automateDBCnxString += ";Initial Catalog=" + GlobVars.automateDBCnx.Initial_Catalog;
            GlobVars.automateDBCnxString += ";User id=" + GlobVars.automateDBCnx.User_id;
            GlobVars.automateDBCnxString += ";Password=" + GlobVars.automateDBCnx.Password;

            return 0;
        }

        // SET XML SETTING
        public static void setExtConfigXMLCnx(string nom_fichier, configConnection _cfg_conn)
        {
            string path = @nom_fichier;
            string strFilename = path;
            XmlDocument docXML = new XmlDocument();
            if (File.Exists(strFilename))
            {
                // Open the XML file
                docXML.Load(strFilename);
                // Create an attribute and add it to the root element
                docXML.DocumentElement.SetAttribute("Data_Source", _cfg_conn.Data_Source);
                docXML.DocumentElement.SetAttribute("Port", _cfg_conn.PORT);
                docXML.DocumentElement.SetAttribute("Network_Library", _cfg_conn.Network_Library);
                docXML.DocumentElement.SetAttribute("Initial_Catalog", _cfg_conn.Initial_Catalog);
                docXML.DocumentElement.SetAttribute("User_id", _cfg_conn.User_id);
                docXML.DocumentElement.SetAttribute("Password", _cfg_conn.Password);
                docXML.Save(@nom_fichier);
            }

        }
    }
}
