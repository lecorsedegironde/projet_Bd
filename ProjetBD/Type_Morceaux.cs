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
    
    public partial class Type_Morceaux
    {
        public Type_Morceaux()
        {
            this.Oeuvre = new HashSet<Oeuvre>();
        }
    
        public int Code_Type { get; set; }
        public string Libellé_Type { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Oeuvre> Oeuvre { get; set; }
    }
}
