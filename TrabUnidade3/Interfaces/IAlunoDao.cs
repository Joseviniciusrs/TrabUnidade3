﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Properties
{
    using System.Collections.Generic;

    public interface IAlunoDao
    {
        void Insert(Aluno obj);
        void Update(Aluno obj);
        void DeleteById(int id);
        Aluno FindById(int id);
        List<Aluno> FindAll();
    }

}