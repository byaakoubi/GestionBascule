using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionBascule.Business.commun
{
    class GlobVars
    {
        /// <summary>
        /// Static value.
        /// </summary>
        public static string companyName;

        /// <summary>
        /// Static value.
        /// </summary>
        public static string portName;

        /// <summary>
        /// Static value.
        /// </summary>
        public static int maxEcartWeight;


        /// <summary>
        /// String connexion to Navision DB.
        /// </summary>
        public static string navisionDBCnx;

        /// <summary>
        /// Connexion class to Automate DB.
        /// </summary>
        public static configConnection automateDBCnx;
        public static string automateDBCnxString;


        /// <summary>
        /// Principal Form.
        /// </summary>
        public static Form parentForm;


        /// <summary>
        /// error dictionary 
        /// </summary>
        static public IDictionary<int, string> errorDictionary = new Dictionary<int, string>()
                                            {
                                                {1,"N° Ticket"},
                                                {2,"Camion"},
                                                {3,"Chauffeur"},
                                                {4,"Poids reception"},
                                                {5,"Poids Pesage 1"},
                                                {6,"Poids Pesage 2"},
                                                {7,"N° BL"},
                                                {8,"Code client"},
                                                {9,"Nom client"},
                                                {10,"Code fournisseur"},
                                                {11,"Nom fournisseur"},
                                                {12,"Code article"},
                                                {13,"Desig article"},
                                                {14,"Poids article"},
                                            };

        /// <summary>
        /// Pesage dictinary
        /// </summary>
        static public IDictionary<string, int> pesDictionary = new Dictionary<string, int>()
                                            {
                                                {"UNITE",1},
                                                {"Kilo",1},
                                                {"",1},
                                                //{null,1},
                                                {"SAC 10 KG ",10},
                                                {"SAC 20 KG ",20},
                                                {"SAC 30 KG ",30},
                                                {"SAC 40 KG ",40},
                                                {"SAC 50 KG ",50},
                                                {"SAC 60 KG ",60},
                                                {"SAC 70 KG ",70},
                                                {"SAC 80 KG ",80},
                                                {"SAC 90 KG ",90},
                                                {"SAC 100 KG ",100},
                                                {"TONNE",1000}
                                            };
        /// <summary>
        /// DB tables
        /// </summary>
        /// 
        public class DBTableClass
        {
            public bool isSomepaDB;
            public bool isNewDB;
            public string fournisseurTab;
            public string clientTab;
            public string articleTab;
            public string automobileTab;
            public string chauffeurTab;
            public string frnblheaderTab;
            public string frnbllineTab;
            public string cltblheaderTab;
            public string cltbllineTab;

            // constructor
            public DBTableClass()
            {
                isSomepaDB = true;
                isNewDB = false;
                fournisseurTab = "[SOMEPA$Vendor]";
                clientTab = "[SOMEPA$Customer]";
                articleTab = "[SOMEPA$Item]";
                automobileTab = "[SOMEPA$Automobile]";
                chauffeurTab = "[SOMEPA$Shipping Agent]";
                frnblheaderTab = "[SOMEPA$Purchase Header]";
                frnbllineTab = "[SOMEPA$Purchase Line]";
                cltblheaderTab = "[SOMEPA$Sales Shipment Header]";
                cltbllineTab = "[SOMEPA$Sales Shipment Line]";
            }
        }


        public static DBTableClass dbtables;

        public static void switchNewDB()
        {
            dbtables.isSomepaDB = false;
            dbtables.isNewDB = true;
            dbtables.fournisseurTab = "[NEW$Vendor]";
            dbtables.clientTab = "[NEW$Customer]";
            dbtables.articleTab = "[NEW$Item]";
            dbtables.automobileTab = "[NEW$Automobile]";
            dbtables.chauffeurTab = "[NEW$Shipping Agent]";
            dbtables.frnblheaderTab = "[NEW$Purchase Header]";
            dbtables.frnbllineTab = "[NEW$Purchase Line]";
            dbtables.cltblheaderTab = "[NEW$Sales Shipment Header]";
            dbtables.cltbllineTab = "[NEW$Sales Shipment Line]";
        }

        public static void switchSomepaDB()
        {
            dbtables.isSomepaDB = true;
            dbtables.isNewDB = false;
            dbtables.fournisseurTab = "[SOMEPA$Vendor]";
            dbtables.clientTab = "[SOMEPA$Customer]";
            dbtables.articleTab = "[SOMEPA$Item]";
            dbtables.automobileTab = "[SOMEPA$Automobile]";
            dbtables.chauffeurTab = "[SOMEPA$Shipping Agent]";
            dbtables.frnblheaderTab = "[SOMEPA$Purchase Header]";
            dbtables.frnbllineTab = "[SOMEPA$Purchase Line]";
            dbtables.cltblheaderTab = "[SOMEPA$Sales Shipment Header]";
            dbtables.cltbllineTab = "[SOMEPA$Sales Shipment Line]";
        }
    }
}
