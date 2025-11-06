using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_explorando.interfaces
{
    public interface ICalculadora
    {
        int soma(int num1, int num2);
        int divisao(int num1, int num2);
        int subitracao(int num1, int num2);
        int multiplicacao(int num1, int num2);
    }
}