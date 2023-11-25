using System;
using System.Collections.Generic;

namespace MODEL
{
    public partial class TbProfessor
    {
        public TbProfessor()
        {
            TbFichatrs = new HashSet<TbFichatr>();
        }

        public int IdProf { get; set; }
        public string NomeP { get; set; } = null!;
        public string Cnpj { get; set; } = null!;
        public string Ddd { get; set; } = null!;
        public string? Numero { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<TbFichatr> TbFichatrs { get; set; }
    }
}
