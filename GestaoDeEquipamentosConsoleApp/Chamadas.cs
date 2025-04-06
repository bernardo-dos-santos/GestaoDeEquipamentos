using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentosConsoleApp
{
    public class Chamadas
    {

        public int IdChamado;
        public string Titulo;
        public int IdDoEquipamento;
        public string Descricao;
        public DateTime DataAbertura;
        public string NomeEquipamento;

        public Chamadas( string titulo, int idDoEquipamento, string descricao, DateTime dataAbertura)
        {
            Titulo = titulo;
            IdDoEquipamento = idDoEquipamento;
            Descricao = descricao;
            DataAbertura = dataAbertura;
        }
        
    }
}
