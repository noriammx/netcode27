using System;

namespace CodeNet27.Sesion01.Ejercicio02
{
    class Program
    {
        //Pedir dos números al usuario por teclado y decir que número es el mayor.

        static void Main(string[] args)
        {

            Console.WriteLine("Hola comunidad .NetCode27");
            Console.WriteLine("Introduzca un numero");
            var numero1 = Console.ReadLine();
            Console.WriteLine("Introduzca otro numero");
            var numero2 = Console.ReadLine();

            //Convertir números
            if (int.Parse(numero1) > int.Parse(numero2))
            {
                Console.WriteLine(numero1 + " es mayor que " + numero2);
            }
            else
            {
                Console.WriteLine(numero2 + " es mayor que " + numero1);
            }
        }
    }
}
