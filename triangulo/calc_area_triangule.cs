using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main (string[] args){
            
            Triangule x, y;
            x = new Triangule();
            y = new Triangule();
            
            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double areaX = x.Area();
            double areaY = y.Area();
                        
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            }else {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}