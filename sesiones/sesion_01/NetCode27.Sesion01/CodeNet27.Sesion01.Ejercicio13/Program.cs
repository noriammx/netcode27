using System;

namespace CodeNet27.Sesion01.Ejercicio13
{
    //Comprobar si un numero introducido por consola es primo
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, i, numero;
            Console.WriteLine("Ingrese numero");
            numero = int.Parse(Console.ReadLine());

            for (i = 1; i < (numero + 1); i++)
            {
                if (numero % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("No es Primo");
            }
            else
            {
                Console.WriteLine("Si es Primo");
            }
            Console.ReadLine();
        }
    }
}
