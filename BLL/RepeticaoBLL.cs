using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using MODEL;

namespace BLL
{
    public class RepeticaoBLL
    {

        public static TbRepeticao Add(TbRepeticao rep)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                DbContext.Add(rep);
                DbContext.SaveChanges();
                return rep;
            }
        }

        public static TbRepeticao GetById(int id)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var rep = DbContext.TbRepeticaos.Single(r => r.IdRepeticao == id);
                return rep;

            }

        }

        public static List<TbRepeticao> getAll()
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var rep = DbContext.TbRepeticaos.ToList();
                return rep;

            }

        }

        public static void Remove(TbRepeticao rep)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                var rpt = DbContext.TbRepeticaos.Single(a => a.IdRepeticao == rep.IdRepeticao);
                DbContext.Remove(rpt);
                DbContext.SaveChanges();

            }
        }
    }
}
