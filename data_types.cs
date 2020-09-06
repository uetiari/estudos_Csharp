using System;

namespace UdemyCourse {
    class Program {
        public static void Main(string[] args) {
            
            bool complete = false; // para guardar info se é V ou F 
            char genero = 'F'; //guardar caracteres sempre entre aspas simples; 
            char letra = '\u0041'; //pode usar cód. unicode
            //SByte x = 100; letra maiúscula do .Net, precisa do using System; minúscula do C#não precisa using System
            byte n1 = 126; //não aceita negativos; não passa de 255, caso volta limite oposto = 0
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //sempre usar com L no final do long
            float n5 = 4.5f; //sempre usar com f no final do número para não confundir com double
            double n6 = 4.5;
            string nome = "Ariane Ueti"; //frases sempre com aspas duplas; não pode mudar conteúdo da string, imutável
            object obj1 = "Kika"; //aceita qualquer coisa
            
            
            
            Console.WriteLine(complete);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            
            
        }
    }
}