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
    
    public partial class Abonné
    {
        public Abonné()
        {
            this.Emprunter = new HashSet<Emprunter>();
            this.Acheter = new HashSet<Acheter>();
        }
    
        public int Code_Abonné { get; set; }
        public string Nom_Abonné { get; set; }
        public string Prénom_Abonné { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> Code_Pays { get; set; }
    
        public virtual ICollection<Emprunter> Emprunter { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual ICollection<Acheter> Acheter { get; set; }
    }
}
