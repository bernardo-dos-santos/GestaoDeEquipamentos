using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GestaoDeEquipamentosConsoleApp
{
    public class TelaEquipamentos
    {
        Equipamentos[] equipamentos = new Equipamentos[100];
        public int contadorEquipamentos = 0;

        public string ExibirMenuEquipamentos()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Selecione uma das opcões abaixo: ");

            Console.WriteLine("1 - Cadastrar Equipamento");
            Console.WriteLine("2 - Editar Equipamento");
            Console.WriteLine("3 - Excluir Equipamento");
            Console.WriteLine("4 - Visualizar Equipamentos");

            string opcao = Console.ReadLine()!;
            return opcao;
        }

        public void CadastrarEquipamento()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Cadastrando Equipamento");
            Console.WriteLine("-------------------------------------------");

            Console.Write("Digite o nome do equipamento: ");
            string nome = Console.ReadLine()!;

            Console.Write("Digite o nome do fabricante equipamento: ");
            string fabricante = Console.ReadLine()!;

            Console.Write("Digite o preço de aquisição R$ ");
            decimal preco = int.Parse(Console.ReadLine()!);

            Console.Write("Digite a data de fabricação do equipamento (DD/MM/YYYY) ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Equipamentos novoEquipamento = new Equipamentos(nome, preco, data, fabricante);
            novoEquipamento.Id = GeradorIds.GerarIdEquipamentos();

            equipamentos[contadorEquipamentos++] = novoEquipamento;
        }

        public void VisualizarEquipamentos()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Visualizando Equipamentos");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(
                "{0, -5} | {1, -20} | {2, -10} | {3, -16} | {4, -16} | {5, -9}",
                "Id", "Nome", "Num. Série", "Fabricante", "Preço", "Data de Fabricação");

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamentos a = equipamentos[i];
                if (a == null) continue;

                Console.WriteLine(
                 "{0, -5} | {1, -20} | {2, -10} | {3, -16} | {4, -16} | {5, -9}",
                 a.Id, a.Nome, a.ObterNumeroSerie(), a.Fabricante, a.Preco.ToString("C2"), a.Data.ToShortDateString());


            }
        }
    }
}
