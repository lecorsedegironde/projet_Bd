//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pays
    {
        public Pays()
        {
            this.Abonné = new HashSet<Abonné>();
            this.Editeur = new HashSet<Editeur>();
            this.Musicien = new HashSet<Musicien>();
        }
    
        public int Code_Pays { get; set; }
        public string Nom_Pays { get; set; }
    
        public virtual ICollection<Abonné> Abonné { get; set; }
        public virtual ICollection<Editeur> Editeur { get; set; }
        public virtual ICollection<Musicien> Musicien { get; set; }
    }
}
