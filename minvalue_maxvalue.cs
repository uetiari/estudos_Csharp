using System;

namespace UdemyCourse {
    class Program {
        public static void Main(string[] args) {
            //não é necessário decorar os números, usar MinValue e MaxValue
            int n1 = int.MinValue; //menor número
            int n2 = int.MaxValue; //maior número
            sbyte n3 = sbyte.MinValue;
            sbyte n4 = sbyte.MaxValue;
            
            decimal n5 = decimal.MaxValue;
            
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            
            Console.WriteLine(n5);
        }
    }
}