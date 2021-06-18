using FormulaMagica.Aplicacao;
using System;

namespace FormulaMagica
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor;
            int validade, quantidade;

            Console.WriteLine("Questão 2 - Calcular Preço item");

            Console.Write("Digite o valor do item: ");
            valor = decimal.Parse(Console.ReadLine());
            Console.Write("Digite quantos dias falta para vencer: ");
            validade = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de itens: ");
            quantidade = int.Parse(Console.ReadLine());

            var valorDoItem = CalculadorDoValorDoItem.Calcular(valor, validade, quantidade);

            Console.WriteLine($"O valor do item é: R${valorDoItem}");

            Console.ReadKey();
        }
    }
}
