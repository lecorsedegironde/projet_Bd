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
    public partial class Musicien
    {
        public Musicien()
        {
            this.Composer = new HashSet<Composer>();
            this.Direction = new HashSet<Direction>();
            this.Interpréter = new HashSet<Interpréter>();
        }
    
        public int Code_Musicien { get; set; }
        public string Nom_Musicien { get; set; }
        public string Prénom_Musicien { get; set; }
        public Nullable<int> Année_Naissance { get; set; }
        public Nullable<int> Année_Mort { get; set; }
        public Nullable<int> Code_Pays { get; set; }
        public Nullable<int> Code_Instrument { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual ICollection<Composer> Composer { get; set; }
        public virtual ICollection<Direction> Direction { get; set; }
        public virtual Instrument Instrument { get; set; }
        public virtual ICollection<Interpréter> Interpréter { get; set; }
        public virtual Pays Pays { get; set; }
    }
}
