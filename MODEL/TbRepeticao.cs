using System;
using System.Collections.Generic;

namespace MODEL
{
    public partial class TbRepeticao
    {
        public int IdRepeticao { get; set; }
        public int? Serie { get; set; }
        public int? Repeticao { get; set; }
        public int IdEquipamento { get; set; }
        public int IdFichatr { get; set; }

        public virtual TbEquipamento IdEquipamentoNavigation { get; set; } = null!;
        public virtual TbFichatr IdFichatrNavigation { get; set; } = null!;
    }
}
