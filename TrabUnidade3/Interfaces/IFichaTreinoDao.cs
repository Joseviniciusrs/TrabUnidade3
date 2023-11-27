using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Properties
{
    using System.Collections.Generic;

    public interface IFichaTreinoDao
    {
        void Insert(FichaTreino obj, Aluno aluno, Professor professor);
        void Update(FichaTreino obj, Aluno aluno, Professor professor);
        void DeleteById(int id);
        FichaTreino FindById(int id);
        List<FichaTreino> FindAll();
    }

}
