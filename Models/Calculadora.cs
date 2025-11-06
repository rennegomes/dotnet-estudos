using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplo_explorando.interfaces;

namespace exemplo_explorando.Models
{
    public class Calculadora : ICalculadora
    {
        public int divisao(int num1, int num2)
        {
            return num1 / num2;
        }

        public int multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }

        public int soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int subitracao(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}