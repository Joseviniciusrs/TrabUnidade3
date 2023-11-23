using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.Entidades
{
    using System;

    [Serializable]
    public class Repeticao
    {
        private int Id;
        private int repeticao;
        private int serie;
        private FichaTreino FichaTr;
        private Equipamento Equip;

        public Repeticao()
        {

        }

        public Repeticao(int id_Repeticao, int repeticao, int serie, FichaTreino fichaTr, Equipamento equip)
        {
            Id = id_Repeticao;
            this.repeticao = repeticao;
            this.serie = serie;
            FichaTr = fichaTr;
            Equip = equip;
        }

        public int Id_Repeticao
        {
            get { return Id; }
            set { Id = value; }
        }

        public int Repeticao_Repeticao
        {
            get { return repeticao; }
            set { repeticao = value; }
        }

        public int Serie_Repeticao
        {
            get { return serie; }
            set { serie = value; }
        }

        public FichaTreino FichaTr_Repeticao
        {
            get { return FichaTr; }
            set { FichaTr = value; }
        }

        public Equipamento Equip_Repeticao
        {
            get { return Equip; }
            set { Equip = value; }
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
            Repeticao other = (Repeticao)obj;
            return Id == other.Id;
        }

        public override string ToString()
        {
            return $"Treino [ Código do Treino = {Id}, Series = {serie}, Repeticoes = {repeticao}, [ Equipamento = {Equip} ], {FichaTr} ]";
        }
    }

}
