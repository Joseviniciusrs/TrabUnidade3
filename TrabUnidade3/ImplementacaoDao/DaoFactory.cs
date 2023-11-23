using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.ImplementacaoDao
{
    public class DaoFactory
    {
        public static AlunoDao CreateAlunoDao()
        {
            return new AlunoDaoJdbc(DB.GetConnection());
        }

        public static ProfessorDao CreateProfessorDao()
        {
            return new ProfessorDaoJdbc(DB.GetConnection());
        }

        public static EquipamentoDao CreateEquipamentoDao()
        {
            return new EquipamentoDaoJdbc(DB.GetConnection());
        }

        public static FichaTreinoDao CreateFichaTreinoDao()
        {
            return new FichaTreinoDaoJdbc(DB.GetConnection());
        }

        public static RepeticaoDao CreateRepeticaoDao()
        {
            return new RepeticaoDaoJdbc(DB.GetConnection());
        }
    }


   // Certifique-se de ter o namespace correto no início do arquivo e ajuste conforme necessário para corresponder à implementação específica da sua aplicação C#.
        //Além disso, substitua DB.GetConnection() pelo método correto ou construtor que fornece a conexão com o banco de dados no seu contexto C#.
}
