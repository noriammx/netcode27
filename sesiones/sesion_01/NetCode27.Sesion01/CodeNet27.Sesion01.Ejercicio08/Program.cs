using System;

namespace CodeNet27.Sesion01.Ejercicio08
{
    class Program
    {
        //Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
