using System;
using System.Globalization;

namespace Course {
    class Triangule {
        public double A;
        public double B;
        public double C;
        public double Area(){
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p* (p - A)*(p - B)*(p - C));
            //double raiz = Math.Sqrt(p* (p - A)*(p - B)*(p - C));
            //return raiz;
        }
    }
}