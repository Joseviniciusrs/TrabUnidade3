using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using MODEL;

namespace BLL
{
    class AlunoBLL
    {

        public static void Add(TbAluno aln)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                DbContext.Add(aln);
                DbContext.SaveChanges();
            }
        }

        public static TbAluno GetById(int id)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var aln = DbContext.TbAlunos.Single(p => p.Idaluno == id);
                return aln;

            }

        }

        public static List<TbAluno> getAll()
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var aln = DbContext.TbAlunos.ToList<TbProfessor>();
                return aln;

            }

        }

    }
}
