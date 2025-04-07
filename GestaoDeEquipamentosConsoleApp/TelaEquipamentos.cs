using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


namespace GestaoDeEquipamentosConsoleApp
{
    public class TelaEquipamentos
    {
        public static Equipamentos[] equipamentos = new Equipamentos[100];
        public int contadorEquipamentos = 0;

        public string ExibirMenuEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Selecione uma das opcões abaixo: ");

            Console.WriteLine("1 - Cadastrar Equipamento");
            Console.WriteLine("2 - Visualizar Equipamentos");
            Console.WriteLine("3 - Editar Equipamento");
            Console.WriteLine("4 - Excluir Equipamento");
            Console.WriteLine("5 - Retornar");

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

            Console.Write("Digite o nome do fabricante do equipamento: ");
            string fabricante = Console.ReadLine()!;

            Console.Write("Digite o preço de aquisição R$ ");
            decimal preco = int.Parse(Console.ReadLine()!);

            Console.Write("Digite a data de fabricação do equipamento (DD/MM/YYYY) ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Equipamentos novoEquipamento = new Equipamentos(nome, preco, data, fabricante);
            novoEquipamento.Id = GeradorIds.GerarIdEquipamentos();

            equipamentos[contadorEquipamentos++] = novoEquipamento;

            Console.WriteLine("O cadastro foi um sucesso");
            Console.WriteLine("Retornando...");
            Thread.Sleep(1500);
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
                string dataCerta = a.Data.ToString("dd/MM/yyyy");

                Console.WriteLine(
                 "{0, -5} | {1, -20} | {2, -10} | {3, -16} | {4, -16} | {5, -9}",
                 a.Id, a.Nome, a.ObterNumeroSerie(), a.Fabricante, a.Preco.ToString("C2"), dataCerta);
            }
            Console.WriteLine("Digite Enter para retornar ao Menu Principal");
            Console.ReadLine();
        }
        public void EditarEquipamento()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Editando Equipamento");
            Console.WriteLine("-------------------------------------------");

            Console.Write("Digite o Id do equipamento: ");
            int IdSelecionado = int.Parse(Console.ReadLine()!);
            bool conseguiuEditar = false;
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;
                if (equipamentos[i].Id == IdSelecionado)
                {
                    Console.Write("Digite o novo nome do equipamento: ");
                    string nome = Console.ReadLine()!;

                    Console.Write("Digite o novo nome do fabricante do equipamento: ");
                    string fabricante = Console.ReadLine()!;

                    Console.Write("Digite o novo preço de aquisição R$ ");
                    decimal preco = decimal.Parse(Console.ReadLine()!);

                    Console.Write("Digite a nova data de fabricação do equipamento (DD/MM/YYYY) ");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());


                    Equipamentos novoEquipamento = new Equipamentos(nome, preco, data, fabricante);
                    novoEquipamento.Id = IdSelecionado;
                    equipamentos[i] = novoEquipamento;
                    conseguiuEditar = true;
                }
            }

            if(conseguiuEditar == false)
            {
                Console.WriteLine("O Id não foi Encontrado, Retornando...");
                EditarEquipamento();
            } else
            {
                Console.WriteLine("Equipamento atualizado, Retornando...");
                Thread.Sleep(1500);
            }
        }

        public void ExcluirEquipamento()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Excluindo Equipamento");
            Console.WriteLine("-------------------------------------------");

            Console.Write("Digite o Id do equipamento que deseja excluir: ");
            int IdSelecionado = int.Parse(Console.ReadLine()!);
            bool conseguiuExcluir = false;
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;
                if(equipamentos[i].Id == IdSelecionado)
                {
                    equipamentos[i] = null;
                    conseguiuExcluir = true;
                }
            }
            if(conseguiuExcluir == false)
            {
                Console.WriteLine("O Id não foi Encontrado, Retornando...");
                ExcluirEquipamento();
            } else
            {
                for (int i = 0; i < equipamentos.Length; i++)
                {
                    if (equipamentos[i] == null) continue;
                    if (equipamentos[i].Id > IdSelecionado)
                    equipamentos[i].Id = equipamentos[i].Id - 1;
                }
                Console.WriteLine("O equipamento foi excluído com sucesso");
                Console.WriteLine("A lista dos Id´s foi atualizada");
                Thread.Sleep(1500);
            }
        }
        public static string ObterNomeEquipamento(int idDoEquipamento)
        {
            string nomeDoEquipamento = null;
            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamentos a = equipamentos[i];
                if (a == null) continue;
                if (a.Id == idDoEquipamento)
                {
                    nomeDoEquipamento = a.Nome;
                    break;
                    
                }
            }
            return nomeDoEquipamento;
        }
    }
}
