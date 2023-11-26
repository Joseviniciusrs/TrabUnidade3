using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using MODEL;

namespace BLL
{
    class RepeticaoBLL
    {

        public static void Add(TbRepeticao rep)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                DbContext.Add(rep);
                DbContext.SaveChanges();
            }
        }

        public static TbRepeticao GetById(int id)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var rep = DbContext.TbRepeticaos.Single(r => r.IdRep == id);
                return rep;

            }

        }

        public static List<TbRepeticao> getAll()
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var rep = DbContext.TbRepeticaos.ToList<TbRepeticao>();
                return rep;

            }

        }

    }
}
