using System;
using System.Globalization;

namespace UdemyCourse {
    class Program {
        static void Main(string[] args) {
            
            // pedindo pra pessoa digitar número no programa
            Console.Write("Digite um número: ");
            // vai receber o número digitado e adicionar ponto
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            
            // enquanto o X for maior ou igual a 0
            while (x >= 0.0) {
            // calculando a raíz quadrada
            double raiz = Math.Sqrt(x);
            // mostrando resultado com número com 3 casas decimais F3
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            
            // para testar de novo
            Console.Write("Digite outro número: ");
            // verificar a variável x novamente
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            // quando acabar, o número negativo irá aparecer
            Console.WriteLine("Número negativo!");
            
        }
    }
}