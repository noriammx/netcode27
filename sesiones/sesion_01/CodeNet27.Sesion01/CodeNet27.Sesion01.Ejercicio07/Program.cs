using System;

namespace CodeNet27.Sesion01.Ejercicio07
{
    class Program
    {
        //Recorre los números del 1 al 100. Muestra los números pares. 
        //Usar el tipo de bucle que quieras.
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
