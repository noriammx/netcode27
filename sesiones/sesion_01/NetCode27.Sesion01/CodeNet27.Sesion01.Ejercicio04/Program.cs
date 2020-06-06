using System;

namespace CodeNet27.Sesion01.Ejercicio04
{
    class Program
    {
        //Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar 
        //(efectivo o tarjeta) si la forma de pago es mediante tarjeta, 
        //pedir el numero de cuenta (inventado).
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca el valor del producto");

            //Si no se introduce un numero fallara
            var valor = int.Parse(Console.ReadLine());
            Console.WriteLine("efectivo o tarjeta");
            var tipo = Console.ReadLine();

            if (tipo == "tarjeta")
            {
                Console.WriteLine("Introduzca el numero de tarjeta");
                var tarjeta = Console.ReadLine();

                //usamos la interpolacion de cadenas para mostrar el resultado $(" texto {variable}")
                Console.WriteLine($"Su tarjeta es {tarjeta}");
                Console.ReadKey();
            }

        }
    }
}
