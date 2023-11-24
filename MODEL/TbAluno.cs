using System;
using System.Collections.Generic;

namespace MODEL
{
    public partial class TbAluno
    {
        public TbAluno()
        {
            TbFichatrs = new HashSet<TbFichatr>();
        }

        public int IdAluno { get; set; }
        public string NomeA { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public string Ddd { get; set; } = null!;
        public string? Numero { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<TbFichatr> TbFichatrs { get; set; }
    }
}
