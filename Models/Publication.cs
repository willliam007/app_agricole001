using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGriUniv.Models
{
    public class Publication
    {
        public int Id { get; set; } // Identifiant unique de la publication
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public string Image { get; set; } // URL ou chemin d'accès à l'image
        public Utilisateur Auteur { get; set; }
        public DateTime DatePublication { get; set; }

        // Vous pouvez ajouter d'autres propriétés si nécessaire, comme le nombre de likes, de commentaires, etc.
    }

}
