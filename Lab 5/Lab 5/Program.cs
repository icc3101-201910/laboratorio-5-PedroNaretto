using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("hola");
                int n;
                Console.WriteLine("-------------------Menu-------------------");
                Console.WriteLine("Ingrese un numero");
                string ns = Console.ReadLine();
                int.TryParse(ns, out n);
                while (true)
                {
                    if (n.ToString() == ns)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Numero invalido \nIngrese un numero");
                        ns = Console.ReadLine();
                        int.TryParse(ns, out n);
                    }
                }

                Calculadora cal = new Calculadora(n);

                List<string> operador = new List<string> { $"Suma 5 a {n}", $"Cuadrado de {n}", $"Cubo de {n}", $"Factorial de {n}", $"Finobacci de {n}" };

                Console.WriteLine("Que operacion decea realizar?");
                int c = 1;
                foreach (string op in operador)
                {
                    Console.WriteLine($"{c})" + op);
                    c += 1;
                }
                string o = Console.ReadLine();
                while ((o != "1") && (o != "2") && (o != "3") && (o != "4") && (o != "5"))
                {
                    Console.WriteLine("Eperacion invalida");
                    Console.WriteLine("Que operacion decea realizar?");
                    c = 1;
                    foreach (string op in operador)
                    {
                        Console.WriteLine($"{c})" + op);
                        c += 1;
                    }
                    o = Console.ReadLine();
                }

                if (o == "1")
                {
                    Console.WriteLine($"La " + operador[0] + $" es " + cal.calculadoras[0].Calcular(n));
                }
                else
                {
                    Console.WriteLine($"El " + operador[int.Parse(o) - 1] + $" es " + cal.calculadoras[int.Parse(o) - 1].Calcular(n));
                }
                Console.WriteLine("1)Salir? \n2)Constinuar");
                
                if (Console.ReadLine() == "1")
                {
                    break;
                }
            }
        }
    }
}
