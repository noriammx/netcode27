using System;

namespace CodeNet27.Sesion01.Ejercicio06
{
    class Program
    {
        //Recorre los números del 1 al 100. Usa un bucle while, pintarlos por consola.
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 101)
            {
                Console.WriteLine(i);
                i++; // incrementamos la i, tambien se puede usar i = i + 1
            }
            Console.ReadKey();

        }
    }
}
