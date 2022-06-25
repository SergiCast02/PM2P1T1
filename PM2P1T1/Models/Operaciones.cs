using System;
using System.Collections.Generic;
using System.Text;

namespace PM2P1T1.Models
{
    internal class Operaciones
    {
        public double getSuma(double num1, double num2)
        {
            return num1 + num2;
        }

        public double getResta(double num1, double num2)
        {
            return num1 - num2;
        }

        public double getMultiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        public double getDivision(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
