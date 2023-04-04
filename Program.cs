using System;

namespace CsE19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 19
            Console.Write("Verificando se valores informados estão no intervalo [10,20]\n\nQuantos valores deseja verificar? ");
            int N = int.Parse(Console.ReadLine());
            int v, vIn = 0, vOut = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Valor ({i}): ");
                v = int.Parse(Console.ReadLine());

                if (v >= 10 && v <= 20)
                    vIn++;
                else vOut++;
            }
            Console.WriteLine($"\nIn: {vIn}");
            Console.WriteLine($"Out: {vOut}");
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
