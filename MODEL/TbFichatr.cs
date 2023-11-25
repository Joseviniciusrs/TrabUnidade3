using System;
using System.Collections.Generic;

namespace MODEL
{
    public partial class TbFichatr
    {
        public TbFichatr()
        {
            TbRepeticaos = new HashSet<TbRepeticao>();
        }

        public int IdFichatr { get; set; }
        public int IdAluno { get; set; }
        public int IdProf { get; set; }

        public virtual TbAluno IdAlunoNavigation { get; set; } = null!;
        public virtual TbProfessor IdProfNavigation { get; set; } = null!;
        public virtual ICollection<TbRepeticao> TbRepeticaos { get; set; }
    }
}
