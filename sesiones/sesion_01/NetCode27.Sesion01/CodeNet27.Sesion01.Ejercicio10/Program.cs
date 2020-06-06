using System;

namespace CodeNet27.Sesion01.Ejercicio10
{
    class Program
    {
        // Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.
        static void Main(string[] args)
        {
            //iniciamos las variables, para ir sumando los valores
            int sumaPares = 0;
            int sumaImpares = 0;

            //hacemos un bucle for, para pedir los 10 numeros
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce un numero");
                var numero = Console.ReadLine();

                //como RedLine devuelve un string, hay que convertirlo en entero
                int numeroInt = int.Parse(numero);

                //obtenemos si es par o impar, para sumarlo a la variable correspondiente
                if (int.Parse(numero) % 2 == 0)
                {
                    sumaPares = sumaPares + numeroInt;
                }
                else
                {
                    sumaImpares = sumaImpares + numeroInt;
                }
            }

            Console.WriteLine($"Los pares suman {sumaPares}");
            Console.WriteLine($"Los impares suman {sumaImpares}");
            Console.ReadKey();
        }
    }
}
