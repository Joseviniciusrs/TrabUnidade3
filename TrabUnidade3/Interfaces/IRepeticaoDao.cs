using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Properties
{
    using System.Collections.Generic;

    public interface IRepeticaoDao
    {
        void Insert(Repeticao repeticao, Equipamento equipamento, FichaTreino fichaTreino);
        void Update(Repeticao repeticao, Equipamento equipamento, FichaTreino fichaTreino);
        void DeleteById(int id);
        Repeticao FindById(int id);
        List<Repeticao> FindAll();
    }

}
