using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ProjetoMiçangato72A
{
    internal class VarId_Prod
    {
        private static int idProd;
        public static int IdProd
        {
            get { return idProd; }
            set { idProd = value; }
        }
    }
}
