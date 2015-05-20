using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBD
{
    class Fournisseur
    {
        public List<Musicien> GetMusiciens()
        {
            ClassiqueEntities context = new ClassiqueEntities();
            var mus = (from m in context.Musicien
                       orderby m.Nom_Musicien
                       select m);

            return mus.ToList();
        }
    }
}
