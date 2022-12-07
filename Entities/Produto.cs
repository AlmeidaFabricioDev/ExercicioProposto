using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }
       

        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public double Totalizar()
        {
            return Preco * Qtd;
        }

    }
}
