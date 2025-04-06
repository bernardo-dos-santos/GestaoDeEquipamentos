using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GestaoDeEquipamentosConsoleApp
{
    public class TelaMenu
    {
        public string ExibirMenuPrincipal()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Selecione uma das opcões abaixo: ");

            Console.WriteLine("1 - Gestão de Equipamentos");
            Console.WriteLine("2 - Gestão de Chamados");

            string opcaoGestao = Console.ReadLine()!;
            return opcaoGestao;
        }

    }
}
