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
    
    public partial class Album
    {
        public Album()
        {
            this.Disque = new HashSet<Disque>();
            this.Emprunter = new HashSet<Emprunter>();
        }
    
        public int Code_Album { get; set; }
        public string Titre_Album { get; set; }
        public Nullable<int> Année_Album { get; set; }
        public Nullable<int> Code_Genre { get; set; }
        public Nullable<int> Code_Editeur { get; set; }
        public byte[] Pochette { get; set; }
        public Nullable<double> Prix { get; set; }
    
        public virtual Editeur Editeur { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ICollection<Disque> Disque { get; set; }
        public virtual ICollection<Emprunter> Emprunter { get; set; }
    }
}