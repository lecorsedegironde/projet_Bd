using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
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
                       where  m.Composer.Count != 0
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


    }
}
