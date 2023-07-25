using System;
using System.Globalization;

namespace exercise2
{
    class _exercise
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua casa tem " + quartos + " quartos");
            Console.WriteLine("O preço do seu produto é: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu último nome é: " + name);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Você tem " + altura.ToString("F2", CultureInfo.InvariantCulture) + " de Altura");






        }
    }
}