using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InaGeo.Domain
{
    public class Utilisateur
    {
        public Guid IdUtilisateurs { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string NumeroTel { get; set; }
        public string MotPasse { get; set; }
    }
}
