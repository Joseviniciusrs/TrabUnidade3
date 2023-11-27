using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.DB
{
    using System;

    public class DbException : Exception
    {
        public DbException(string message) : base(message)
        {
        }
    }

}
