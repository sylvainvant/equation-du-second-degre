using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation_du_second_degre
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string a;
            string b;
            string c;
            double A;
            double B;
            double C;
            double delta;
            char resultat;

            Console.WriteLine("entrez la valeur de a:");
            a = Console.ReadLine();
            Console.WriteLine("entrez la valeur de b:");
            b = Console.ReadLine();
            Console.WriteLine("entrez la valeur de c:");
            c = Console.ReadLine();
            A = Convert.ToDouble(a);
            B = Convert.ToDouble(b);
            C = Convert.ToDouble(c);
            delta= ((B*B)-(4*A*C);

        }
    }
}
