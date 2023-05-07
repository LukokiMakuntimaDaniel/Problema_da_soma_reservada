using System;

namespace Problema_da_soma_reservada
{
    class Program
    {
        public static int inverter(int n)
        {
            string nString = n.ToString();
            string nInvertida = "";
            for(int cont=nString.Length-1;cont>=0; cont--)
            {
                nInvertida += nString.Substring(cont, 1);
            }
            return int.Parse(nInvertida);
        }
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("" + inverter(inverter(n1) + inverter(n2)));
        }
    }
}
