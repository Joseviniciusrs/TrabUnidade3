using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Properties
{
    using System.Collections.Generic;

    public interface IProfessorDao
    {
        void Insert(Professor obj);
        void Update(Professor obj);
        void DeleteById(int id);
        Professor FindById(int id);
        List<Professor> FindAll();
    }

}
