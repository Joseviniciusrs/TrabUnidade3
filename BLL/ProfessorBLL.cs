using DAL.DBContext;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProfessorBLL
    {
        public static TbProfessor Add(TbProfessor prof)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                DbContext.Add(prof);
                DbContext.SaveChanges();
                return prof;
            }
        }

        public static TbProfessor GetById(int id)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var prof = DbContext.TbProfessors.Single(p => p.IdProf == id);
                return prof;

            }

        }

        public static List<TbProfessor> getAll()
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var prof = DbContext.TbProfessors.ToList();
                return prof;

            }
            
        }

        public static void Remove(TbProfessor prof)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                var pro = DbContext.TbProfessors.Single(a => a.IdProf == prof.IdProf);
                DbContext.Remove(pro);
                DbContext.SaveChanges();

            }
        }
    }
}
