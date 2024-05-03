using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGriUniv.Models
{
    public class Utilisateur
    {
        public int Id { get; set; } // Identifiant unique de l'utilisateur
        public string Nom { get; set; }
        public string Prenom { get; set; } // Facultatif
        public string Email { get; set; }
        public string Image { get; set; } // URL ou chemin d'accès à l'image de profil
                                          // Vous pouvez ajouter d'autres propriétés si nécessaire, comme la biographie, etc.
    }

}
