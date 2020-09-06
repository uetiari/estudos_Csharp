using System;
using System.Globalization;

namespace UdemyCourse {
    class Program {
        public static void Main(string[] args) {
            
            int idade = 32;
            double saldo = 10.8574;
            string nome = "Maria";
            
            //placeholder - não dá pra trocar vírgula por ponto
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);
            
            //interpolação - não dá pra trocar vírgula por ponto
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");
            
            //concatenação - forma mais antiga
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            
        }
    }
}