using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReturnOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação(+,-,/,*): ");
            string op = Console.ReadLine();
            Console.WriteLine("O resultado da conta é: " +operacao(n1,n2,op));
            Console.ReadKey();
        }

        static double operacao(double n1, double n2, string op)
        {

            switch (op)
            {
                case "+":
                    return n1 + n2;
                 



                case "-":

                    return n1 - n2;



                case "*":

                    return n1 * n2;




                case "/":

                    return n1 / n2;

                default: return 0;

            }
        }
    }
}
