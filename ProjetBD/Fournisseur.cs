using System.Collections.Generic;
using System.Linq;

namespace ProjetBD
{
    class Fournisseur
    {
        public List<Musicien> GetMusiciens()
        {
            ClassiqueEntities context = new ClassiqueEntities();
            var mus = (from m in context.Musicien
                       where m.Composer.Count != 0
                       orderby m.Nom_Musicien
                       select m);

            return mus.ToList();
        }

        public List<Pays> GetPays()
        {
            ClassiqueEntities context = new ClassiqueEntities();
            var pays = (from p in context.Pays
                        orderby p.Nom_Pays
                        select p);

            return pays.ToList();
        }

        public List<Instrument> GetInstruments()
        {
            ClassiqueEntities context = new ClassiqueEntities();
            var instr = (from i in context.Instrument
                         orderby i.Nom_Instrument
                         select i);

            return instr.ToList();
        }

        public List<Album> GetAlbums()
        {
            return null;
        }

        public List<Album> GetAlbums(int codeMusicien)
        {
            ClassiqueEntities context = new ClassiqueEntities();
            var albums = context.Composer.Where(c => c.Code_Musicien == codeMusicien)
                .SelectMany(c => context.Oeuvre.Where(o => o.Code_Oeuvre == c.Code_Oeuvre))
                .SelectMany(c => context.Composition_Oeuvre.Where(o => o.Code_Oeuvre == c.Code_Oeuvre))
                .SelectMany(c => context.Composition.Where(o => c.Code_Composition == o.Code_Composition))
                .SelectMany(c => context.Enregistrement.Where(o => o.Code_Composition == c.Code_Composition))
                .SelectMany(c => context.Composition_Disque.Where(o => o.Code_Enregistrement == c.Code_Enregistrement))
                .SelectMany(c => context.Disque.Where(o => o.Code_Disque == c.Code_Disque))
                .SelectMany(c => context.Album.Where(o => o.Code_Album == c.Code_Album)).Distinct();
            return albums.ToList();
        }

        public List<Abonné> GetAbonnés()
        {
            ClassiqueEntities context = new ClassiqueEntities();
            var abonné = (from a in context.Abonné
                orderby a.Nom_Abonné
                select a);
            return abonné.ToList();
        }

    }
}
