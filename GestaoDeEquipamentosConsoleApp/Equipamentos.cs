using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEquipamentosConsoleApp
{
    public class Equipamentos
    {
        public int Id;
        public string Nome;
        public decimal Preco;
        public string NumeroSerie;
        public DateTime Data;
        public string Fabricante;

        public Equipamentos(string nome, decimal preco, DateTime data, string fabricante)
        {
            Nome = nome;
            Preco = preco;
            Data = data;
            Fabricante = fabricante;
        }

        public string ObterNumeroSerie()
        {
            string numeroSerie = Nome.Substring(0, 3).ToUpper();

            return $"{numeroSerie}-{Id}";
        }
    }
}
