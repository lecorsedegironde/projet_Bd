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
    
    public partial class Composer
    {
        public int Code_Composer { get; set; }
        public Nullable<int> Code_Musicien { get; set; }
        public Nullable<int> Code_Oeuvre { get; set; }
        public Nullable<int> Code { get; set; }
    
        public virtual Musicien Musicien { get; set; }
        public virtual Oeuvre Oeuvre { get; set; }
    }
}
