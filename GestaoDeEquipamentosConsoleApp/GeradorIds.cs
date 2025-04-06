using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestaoDeEquipamentosConsoleApp
{
    public static class GeradorIds
    {
        public static int IdEquipamentos = 0;

        public static int GerarIdEquipamentos()
        {
            IdEquipamentos++;
            return IdEquipamentos;
        }
    }
}
