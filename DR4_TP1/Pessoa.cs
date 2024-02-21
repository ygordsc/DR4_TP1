using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR4_TP1
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private int CPF;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public int CPF1 { get => CPF; set => CPF = value; }
        
        public void exibir()
        {
            Console.WriteLine(this.Nome);
            Console.WriteLine(this.Idade);
            Console.WriteLine(this.CPF1);
        }
        
    }
}
