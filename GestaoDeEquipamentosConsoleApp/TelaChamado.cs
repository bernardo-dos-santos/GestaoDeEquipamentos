using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace GestaoDeEquipamentosConsoleApp
{
    public class TelaChamado
    {
        Chamadas[] chamados = new Chamadas[100];
        public int contadorChamados = 0;

        public string ExibirMenuChamados()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Selecione uma das opcões abaixo: ");

            Console.WriteLine("1 - Cadastrar Chamado");
            Console.WriteLine("2 - Visualizar Chamados");
            Console.WriteLine("3 - Editar Chamado");
            Console.WriteLine("4 - Excluir Chamado");
            Console.WriteLine("5 - Retornar");

            string opcaoChamado = Console.ReadLine()!;
            return opcaoChamado;
        }

        public bool CadastrarChamado()
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
            novoChamado.Id = GeradorIds.GerarIdChamados();
            novoChamado.NomeEquipamento = TelaEquipamentos.ObterNomeEquipamento(idDoEquipamento);

            chamados[contadorChamados++] = novoChamado;

            Console.WriteLine("O cadastro foi um sucesso");
            Console.WriteLine("Retornando...");
            Thread.Sleep(1500);
            return true;
        }
        public void VisualizarChamados()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Visualizando Chamados");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(
                "{0, -5} | {1, -10} | {2, -20} | {3, -16} | {4, -16} | {5, -9} | {6, -13}",
                "Id", "Título", "Descrição", "Id Equipamento", "Nome Equipamento", "Data de Abertura", "Dias Passados");
            DateTime dataAtual = DateTime.Now;
            for (int i = 0; i < chamados.Length; i++)
            {
                Chamadas a = chamados[i];
                if (a == null) continue;
                string dataCerta = a.DataAbertura.ToString("dd/MM/yyyy");
                TimeSpan diferenca = dataAtual - a.DataAbertura;
                Console.WriteLine(
                 "{0, -5} | {1, -10} | {2, -20} | {3, -16} | {4, -16} | {5, -9} | {6, -13}",
                 a.Id, a.Titulo, a.Descricao, a.IdDoEquipamento, a.NomeEquipamento, dataCerta, $"{diferenca.Days} dias");
            }
            Console.WriteLine("Digite Enter para retornar ao Menu Principal");
            Console.ReadLine();
        }
        public void EditarChamado()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Editando Chamado");
            Console.WriteLine("-------------------------------------------");

            Console.Write("Digite o Id do chamado: ");
            int IdSelecionado = int.Parse(Console.ReadLine()!);
            bool conseguiuEditar = false;
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] == null) continue;
                if (chamados[i].Id == IdSelecionado)
                {
                    Console.Write("Digite o novo título do chamado: ");
                    string titulo = Console.ReadLine()!;

                    Console.Write("Digite a nova descrição do chamado: ");
                    string descricao = Console.ReadLine()!;

                    Console.Write("Digite o novo Id do equipamento: ");
                    int idDoEquipamento = int.Parse(Console.ReadLine()!);

                    Console.Write("Digite a nova data de abertura do chamado (DD/MM/YYYY) ");
                    DateTime dataDeAbertura = Convert.ToDateTime(Console.ReadLine());


                    Chamadas novoEquipamento = new Chamadas(titulo, idDoEquipamento, descricao, dataDeAbertura);
                    novoEquipamento.Id = IdSelecionado;
                    chamados[i] = novoEquipamento;
                    conseguiuEditar = true;
                }
            }

            if (conseguiuEditar == false)
            {
                Console.WriteLine("O Id não foi Encontrado, Retornando...");
                EditarChamado();
            }
            else
            {
                Console.WriteLine("Chamado atualizado, Retornando...");
                Thread.Sleep(1500);
            }
        }

        public void ExcluirChamado()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Excluindo Chamado");
            Console.WriteLine("-------------------------------------------");

            Console.Write("Digite o Id do chamado que deseja excluir: ");
            int IdSelecionado = int.Parse(Console.ReadLine()!);
            bool conseguiuExcluir = false;
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] == null) continue;
                if (chamados[i].Id == IdSelecionado)
                {
                    chamados[i] = null;
                    conseguiuExcluir = true;
                }
            }
            if (conseguiuExcluir == false)
            {
                Console.WriteLine("O Id não foi Encontrado, Retornando...");
                ExcluirChamado();
            }
            else
            {
                for (int i = 0; i < chamados.Length; i++)
                {
                    if (chamados[i] == null) continue;
                    if (chamados[i].Id > IdSelecionado)
                        chamados[i].Id = chamados[i].Id - 1;
                }
                Console.WriteLine("O equipamento foi excluído com sucesso");
                Console.WriteLine("A lista dos Id´s foi atualizada");
                Thread.Sleep(1500);
            }
        }
    }
}
