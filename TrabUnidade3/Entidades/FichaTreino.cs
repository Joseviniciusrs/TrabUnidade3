using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Entidades
{
    using System;

    [Serializable]
    public class FichaTreino
    {
        private int Id;
        private Aluno Aluno;
        private Professor Prof;

        public FichaTreino()
        {

        }

        public FichaTreino(int id_FichaTreino, Aluno aluno, Professor prof)
        {
            Id = id_FichaTreino;
            Aluno = aluno;
            Prof = prof;
        }

        public int Id_FichaTreino
        {
            get { return Id; }
            set { Id = value; }
        }

        public Aluno Aluno_FichaTreino
        {
            get { return Aluno; }
            set { Aluno = value; }
        }

        public Professor Prof_FichaTreino
        {
            get { return Prof; }
            set { Prof = value; }
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            if (obj == null || GetType() != obj.GetType())
                return false;
            FichaTreino other = (FichaTreino)obj;
            return Id == other.Id;
        }

        public override string ToString()
        {
            return $" [ Aluno = {Aluno} ], [ Professor = {Prof} ]";
        }

        public string Ficha()
        {
            return $"Ficha [ Código = {Id} , Aluno = {Aluno.GetNome()} , Professor = {Prof.GetNome()} ]";
        }
    }

}
