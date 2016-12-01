using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        #region Métodos
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double rdo = 0;
            double num1 = numero1.getNumero();
            double num2 = numero2.getNumero();


            switch (operador)
            {
                case "-":
                    rdo = num1 - num2;
                    return rdo;
                case "+":
                    rdo = num1 + num2;
                    return rdo;
                case "*":
                    rdo = num1 * num2;
                    return rdo;
                case "/":
                    if (num2 != 0)
                    {
                        rdo = num1 / num2;
                        return rdo;
                    }
                    else
                    {
                        rdo = 0;
                        return rdo;
                    }
                default:
                    break;
            }
            return rdo;
        }

        public static string validarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                operador = "+";
            }
            return operador;
        }
        #endregion
    }
}
