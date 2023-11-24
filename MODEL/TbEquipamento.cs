using System;
using System.Collections.Generic;

namespace MODEL
{
    public partial class TbEquipamento
    {
        public TbEquipamento()
        {
            TbRepeticaos = new HashSet<TbRepeticao>();
        }

        public int IdEquipamento { get; set; }
        public string? NomeEqp { get; set; }

        public virtual ICollection<TbRepeticao> TbRepeticaos { get; set; }
    }
}
