//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace ProjetBD
{
    public partial class Orchestres
    {
        public Orchestres()
        {
            this.Direction = new HashSet<Direction>();
        }
    
        public int Code_Orchestre { get; set; }
        public string Nom_Orchestre { get; set; }
    
        public virtual ICollection<Direction> Direction { get; set; }
    }
}
