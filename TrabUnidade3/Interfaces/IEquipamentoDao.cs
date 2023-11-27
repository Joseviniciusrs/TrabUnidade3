using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Properties
{
    using System.Collections.Generic;

    public interface IEquipamentoDao
    {
        void Insert(Equipamento obj);
        void Update(Equipamento obj);
        void DeleteById(int id);
        Equipamento FindById(int id);
        List<Equipamento> FindAll();
    }

}
