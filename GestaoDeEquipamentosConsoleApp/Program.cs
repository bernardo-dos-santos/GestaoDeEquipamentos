namespace GestaoDeEquipamentosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamentos telaEquipamentos = new TelaEquipamentos();
            while(true)
            {
                string opcao = telaEquipamentos.ExibirMenuEquipamentos();

                switch (opcao)
                {
                    case "1":
                        telaEquipamentos.CadastrarEquipamento();
                        continue;

                    case "2":

                    case "3":

                    case "4":
                        telaEquipamentos.VisualizarEquipamentos();
                        continue;
                    default:
                        break;
                }
            }
        }
    }
}
