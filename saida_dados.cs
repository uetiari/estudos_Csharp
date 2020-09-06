using System;
using System.Globalization; //influencia na troca de ponto por vírgula

namespace UdemyCourse {
    class Program {
        public static void Main(string[] args) {
            
            char genero = 'F';
            int idade = 32;
            double saldo = 10.85736;
            string nome = "Maria";
            
            Console.WriteLine("Hello world!");
            Console.WriteLine("How are you?");
            
            Console.Write("Bom dia!"); //sem quebra de linha
            Console.WriteLine("Boa tarde!"); //com quebra de linha
            Console.WriteLine("Boa noite!");
            Console.WriteLine("________");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2")); // deixa mostrar apenas duas casa decimais arredenonda números
            Console.WriteLine(saldo.ToString("F4")); // mostrar 4 casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // trocar ponto por vírgula
            Console.WriteLine(nome);
        }
    }
}