using DAL.DBContext;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class ProfessorBLL
    {
        public static void Add(TbProfessor prof)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                DbContext.Add(prof);
                DbContext.SaveChanges();
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

                var prof = DbContext.TbProfessors.ToList<TbProfessor>();
                return prof;

            }
            
        }
    }
}
