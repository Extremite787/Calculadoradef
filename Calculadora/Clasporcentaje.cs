using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Clasporcentaje
    {
        public double Porcentaje(double num1, double num2)
        {
            double P;
            P = num1 * num2;
            P /= 100;
            return P;
        }
    }
}
