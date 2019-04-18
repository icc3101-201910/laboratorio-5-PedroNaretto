using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Calculadora : ICalcular
    {
        Random rnd = new Random();
        private int numero;
        public List<ICalcular> calculadoras = new List<ICalcular> { new PersonaQueSuma5(), new Cuadrado(), new Cubo(), new PerroFactorial(), new RobotFibonacci()};

        public Calculadora(int numero)
        {
            this.numero = numero;
        }

        public int GetNumero()
        {
            return numero;
        }

        public int Calcular(int numero)
        {
            throw new NotImplementedException();
        }
    }
}
