using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBascule.Business.commun
{
    public class configConnection
    {
            public string Data_Source;
            public string PORT;
            public string Network_Library;
            public string Initial_Catalog;
            public string User_id;
            public string Password;
            public configConnection(string Data_Source_,
                string PORT_, string Network_Library_,
                string Initial_Catalog_,
                string User_id_,
                string Password_)
            {
                Data_Source = Data_Source_;
                PORT = PORT_;
                Network_Library = Network_Library_;
                Initial_Catalog = Initial_Catalog_;
                User_id = User_id_;
                Password = Password_;
            }
    }
}
