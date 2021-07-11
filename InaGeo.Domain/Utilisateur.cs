using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InaGeo.Domain
{
    class Utilisateur
    {
        public Guid IdUtilisateurs { get; set; }
        public string Nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string adresse { get; set; }
        public string motPasse { get; set; }
    }
}
