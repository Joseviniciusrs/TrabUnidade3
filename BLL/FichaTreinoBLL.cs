using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using MODEL;

namespace BLL
{
    public class FichaTreinoBLL
    {

        public static void Add(TbFichatr fichatr)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                DbContext.Add(fichatr);
                DbContext.SaveChanges();
            }
        }

        public static TbFichatr GetById(int id)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var fichatr = DbContext.TbFichatrs.Single(ft => ft.IdFichatr == id);
                return fichatr;

            }

        }

        public static List<TbFichatr> getAll()
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var ftr = DbContext.TbFichatrs.ToList();
                return ftr;

            }

        }

        public static void Remove(TbFichatr fic)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                var ftr = DbContext.TbFichatrs.Single(a => a.IdFichatr == fic.IdFichatr);
                DbContext.Remove(ftr);
                DbContext.SaveChanges();

            }
        }
    }
}
