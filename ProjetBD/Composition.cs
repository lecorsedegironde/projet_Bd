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
    
    public partial class Composition
    {
        public Composition()
        {
            this.Composition_Oeuvre = new HashSet<Composition_Oeuvre>();
            this.Enregistrement = new HashSet<Enregistrement>();
        }
    
        public int Code_Composition { get; set; }
        public string Titre_Composition { get; set; }
        public string Composante_Composition { get; set; }
    
        public virtual ICollection<Composition_Oeuvre> Composition_Oeuvre { get; set; }
        public virtual ICollection<Enregistrement> Enregistrement { get; set; }
    }
}