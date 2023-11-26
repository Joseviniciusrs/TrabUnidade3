using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using MODEL;

namespace BLL
{
    public class AlunoBLL
    {

        public static TbAluno Add(TbAluno aln)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                DbContext.Add(aln);
                DbContext.SaveChanges();
                return aln;
            }
        }

        public static TbAluno GetById(int id)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var aln = DbContext.TbAlunos.Single(a => a.IdAluno == id);
                return aln;

            }

        }

        public static List<TbAluno> getAll()
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                var aln = DbContext.TbAlunos.ToList();
                return aln;
                
            }

        }

        public static void Remove(TbAluno aln)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                var alun = DbContext.TbAlunos.Single(a => a.IdAluno == aln.IdAluno);
                DbContext.Remove(alun);
                DbContext.SaveChanges();
               
            }
        }

    }
}
