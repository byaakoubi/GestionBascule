using System ;
using System.Collections.Generic ;
using System.Linq ;
using System.Text ;
using System.Threading.Tasks;

namespace GestionBascule.Business.pesage
{
    public class PesageHeaderModel
    {
        public int entry_n { get; set; }
        public int type_oper { get; set; }
        public DateTime date_entree { get; set; }       
        public string n_ticket { get; set; }
        public string matricule_camion { get; set; }
        public string nom_chauffeur { get; set; }
        public double pesage_1 { get; set; }
        public double pesage_2 { get; set; }
        public double poids_net { get; set; }
        public double poids_reception { get; set; }
        public double ecart_poids { get; set; }
        public DateTime date_sortie { get; set; }
        public string destination { get; set; }
        public int etat { get; set; }

    }
}
