namespace GestaoDeEquipamentosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamentos telaEquipamentos = new TelaEquipamentos();
            TelaChamado telaChamado = new TelaChamado();
            TelaMenu telaMenu = new TelaMenu();
            while(true)
            {
                Console.Clear();
                string opcaoGestao = telaMenu.ExibirMenuPrincipal();

                switch (opcaoGestao)
                {
                    case "1":
                        string opcao = telaEquipamentos.ExibirMenuEquipamentos();

                        switch (opcao)
                        {
                            case "1":
                                telaEquipamentos.CadastrarEquipamento();
                                continue;
                            case "2":
                                telaEquipamentos.VisualizarEquipamentos();
                                continue;
                            case "3":
                                telaEquipamentos.EditarEquipamento();
                                continue;
                            case "4":
                                telaEquipamentos.ExcluirEquipamento();
                                continue;
                            case "5":
                                telaEquipamentos.ExcluirEquipamento();
                                continue;
                            default:
                                Console.WriteLine("Comando Incorreto. Retornando...");
                                Thread.Sleep(1500);
                                continue;

                        }
                    case "2":

                        string opcaoChamado = telaChamado.ExibirMenuChamados();
                        switch (opcaoChamado)
                        {
                            case "1":
                                telaChamado.CadastrarChamado();
                                continue;
                            case "2":
                                telaChamado.VisualizarChamados();
                                continue;
                            case "3":
                                telaChamado.CadastrarChamado();
                                continue;
                            case "4":
                                telaChamado.CadastrarChamado();
                                continue;
                            case "5":
                                telaChamado.CadastrarChamado();
                                continue;
                            default:
                                Console.WriteLine("Comando Incorreto. Retornando...");
                                Thread.Sleep(1500);
                                continue;

                        }
                        continue;

                    default:
                        Console.WriteLine("Comando Incorreto. Retornando...");
                        Thread.Sleep(1500);
                        continue;





                }
            }
        }
    }
}
