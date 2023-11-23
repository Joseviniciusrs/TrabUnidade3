using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Entidades
{
    using System;

    [Serializable]
    public class Equipamento
    {
        private int Id;
        private string Nome;

        public Equipamento()
        {

        }

        public Equipamento(int id_Equipamento, string nome)
        {
            Id = id_Equipamento;
            Nome = nome;
        }

        public int Id_Equipamento
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Nome_Equipamento
        {
            get { return Nome; }
            set { Nome = value; }
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
            Equipamento other = (Equipamento)obj;
            return Id == other.Id;
        }

        public override string ToString()
        {
            return $"{Nome} , Código = {Id}";
        }

        public string Objeto()
        {
            return $"Equipamento [ Código = {Id} , Nome = {Nome} ]";
        }
    }

}
