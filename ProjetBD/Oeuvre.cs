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
    
    public partial class Oeuvre
    {
        public Oeuvre()
        {
            this.Composer = new HashSet<Composer>();
            this.Composition_Oeuvre = new HashSet<Composition_Oeuvre>();
        }
    
        public int Code_Oeuvre { get; set; }
        public string Titre_Oeuvre { get; set; }
        public string Sous_Titre { get; set; }
        public string Tonalité { get; set; }
        public Nullable<int> Code_Type { get; set; }
        public Nullable<int> Année { get; set; }
        public string Opus { get; set; }
        public Nullable<int> Numéro_Opus { get; set; }
    
        public virtual ICollection<Composer> Composer { get; set; }
        public virtual ICollection<Composition_Oeuvre> Composition_Oeuvre { get; set; }
        public virtual Type_Morceaux Type_Morceaux { get; set; }
    }
}
