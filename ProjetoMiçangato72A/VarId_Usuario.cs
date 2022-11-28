using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ProjetoMiçangato72A
{
    internal class VarId_Usuario
    {
        private static int id;
        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
