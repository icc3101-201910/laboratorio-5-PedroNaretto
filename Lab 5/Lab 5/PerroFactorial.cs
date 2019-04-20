using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class PerroFactorial : ICalcular
    {

        public int Calcular(int numero)
        {
            int n = 1;
            for(int i = 2; i <= numero && i <13; i++)
            {
                n = n * i;
            }
            return n;
        }
    }
}
