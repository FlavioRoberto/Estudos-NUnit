using System;

namespace Application.Domain
{
    public class Calculadora
    {

        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public object Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
