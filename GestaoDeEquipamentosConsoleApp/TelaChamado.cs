using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentosConsoleApp
{
    public class TelaChamado 
    {
        Chamadas[] chamados = new Chamadas[100];
        public int contadorChamados = 0;

        public string ExibirMenuChamados()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Selecione uma das opcões abaixo: ");

            Console.WriteLine("1 - Cadastrar Chamado");
            Console.WriteLine("2 - Visualizar Chamados");
            Console.WriteLine("3 - Editar Chamado");
            Console.WriteLine("4 - Excluir Chamado");

            string opcaoChamado = Console.ReadLine()!;
            return opcaoChamado;
        }

        public void CadastrarChamado()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Cadastrando Chamado");
            Console.WriteLine("-------------------------------------------");

            Console.Write("Digite o título do chamado: ");
            string titulo = Console.ReadLine()!;

            Console.Write("Digite a descrição do chamado: ");
            string descricao = Console.ReadLine()!;

            Console.Write("Digite o Id do equipamento: ");
            int idDoEquipamento = int.Parse(Console.ReadLine()!);

            Console.Write("Digite a data de abertura do chamado (DD/MM/YYYY) ");
            DateTime dataDeAbertura = Convert.ToDateTime(Console.ReadLine());

            Chamadas novoChamado = new Chamadas(titulo, idDoEquipamento, descricao, dataDeAbertura);
            novoChamado.IdChamado = GeradorIds.GerarIdChamados();
            novoChamado.NomeEquipamento = TelaEquipamentos.ObterNomeEquipamento(idDoEquipamento);

            chamados[contadorChamados++] = novoChamado;

            Console.WriteLine("O cadastro foi um sucesso");
            Console.WriteLine("Retornando...");
            Thread.Sleep(1500);
        }
        public void VisualizarChamados()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Visualizando Chamados");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(
                "{0, -5} | {1, -10} | {2, -20} | {3, -16} | {4, -16} | {5, -9}",
                "Id", "Título", "Descrição", "Id Equipamento", "Nome Equipamento", "Data de Abertura");

            for (int i = 0; i < chamados.Length; i++)
            {
                Chamadas a = chamados[i];
                if (a == null) continue;

                Console.WriteLine(
                 "{0, -5} | {1, -10} | {2, -20} | {3, -16} | {4, -16} | {5, -9}",
                 a.IdChamado, a.Titulo, a.Descricao, a.IdDoEquipamento, a.NomeEquipamento, a.DataAbertura);
            }
            Console.WriteLine("Digite Enter para retornar ao Menu Principal");
            Console.ReadLine();
        }

    }
}
