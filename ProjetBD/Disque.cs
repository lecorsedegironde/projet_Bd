//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace ProjetBD
{
    public partial class Disque
    {
        public Disque()
        {
            this.Composition_Disque = new HashSet<Composition_Disque>();
        }
    
        public int Code_Disque { get; set; }
        public Nullable<int> Code_Album { get; set; }
        public string Référence_Album { get; set; }
        public string Référence_Disque { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual ICollection<Composition_Disque> Composition_Disque { get; set; }
    }
}
