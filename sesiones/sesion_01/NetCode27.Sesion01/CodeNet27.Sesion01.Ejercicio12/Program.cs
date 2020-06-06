using System;

namespace CodeNet27.Sesion01.Ejercicio12
{
    //Crea un programa que pida por consola un numero del 1 al 1000 
    //(validara que el numero introducido es correcto) y sume todos los números 
    //del 1 al numero introducido, mostrando por consola el numero de la suma y la media. 0

    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;


            Console.WriteLine("Introduce un numero del 1 al 1000");
            var numero = Console.ReadLine();
            int numeroInt = int.Parse(numero);


            if (numeroInt < 1 || numeroInt > 1000)
            {
                Console.WriteLine("Introduce un numero del 1 al 1000");
                Console.ReadKey();
            }
            for (int i = 1; i < numeroInt + 1; i++)
            {
                suma = suma + i;
            }

            Console.WriteLine($"La suma es {suma}");
            Console.WriteLine($"La media es {suma / numeroInt}");
            Console.ReadKey();

        }
    }
}
