using System;

namespace UdemyCourse {
    class Program {
        static void Main(string[] args) {
            // aparece na tela pro usuário digitar o número
            Console.Write("Quantos números você vai digitar?");
            int N = int.Parse(Console.ReadLine());
            
            int soma = 0;
            for (int i = 1; i <= N; i++) {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
            
        }
    }
}