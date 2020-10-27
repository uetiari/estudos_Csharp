using System;
using System.Globalization;

namespace Curso{
    class Program {
        static void Main(string[] args){
            Retangulo x, y;
            x = new Retangulo();
                       
            Console.WriteLine("Entre a largura e altura do retângulo:");
            xAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xLargura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = x.Area();

            Console.WriteLine("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}