using static System.Net.Mime.MediaTypeNames;

namespace DR4_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Olá, mundo!");

            /* Pessoa p1 = new Pessoa();

            p1.Nome = "Ygor";
            p1.Idade = 18;
            p1.CPF1 = 123456789;

            p1.exibir(); */

            Console.WriteLine("Adicionar nova pessoa - 1");
            Console.WriteLine("Sair do programa - 0");
            int test = Int32.Parse(Console.ReadLine());

            while (test == 1) {
                Pessoa pessoa = new Pessoa();
                Console.WriteLine("Digite o nome:");
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Digite a idade:");
                pessoa.Idade = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite o CPF:");
                pessoa.CPF1 = Int32.Parse(Console.ReadLine());

                pessoa.exibir();

                Console.WriteLine("Adicionar nova pessoa - 1");
                Console.WriteLine("Sair do programa - 0");
                test = Int32.Parse(Console.ReadLine());

            }

        }
    }
}
