using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class RobotFibonacci : ICalcular
    {
        public int Calcular(int numero)
        {
            int x0 = 0;
            int x1 = 1;
            int n = 0;
            if (numero == 0)
            {
                return 0;
            }
            else if(numero == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 2; i <= numero && i <= 46; i++)
                {
                    n = x0 + x1;
                    x0 = x1;
                    x1 = n;
                }
                return n;
            }
        }
    }
}
