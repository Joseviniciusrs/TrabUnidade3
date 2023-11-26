using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBContext;
using MODEL;


namespace BLL
{
    class EquipamentoBLL
    {

        public static void Add(TbEquipamento equip)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {
                DbContext.Add(equip);
                DbContext.SaveChanges();
            }
        }

        public static TbEquipamento GetById(int id)
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var eq = DbContext.TbEquipamentos.Single(e => e.IdEquipamento == id);
                return eq;

            }

        }

        public static List<TbEquipamento> getAll()
        {
            using (var DbContext = new CUSERSIAGOADOCUMENTSGITHUBTRABUNIDADE3DALDATABASEDATABASE1MDFContext())
            {

                var eq = DbContext.TbEquipamentos.ToList<TbEquipamento>();
                return eq;

            }

        }

    }
}
