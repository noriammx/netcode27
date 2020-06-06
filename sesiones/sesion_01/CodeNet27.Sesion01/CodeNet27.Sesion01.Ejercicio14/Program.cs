using System;

namespace CodeNet27.Sesion01.Ejercicio14
{
    //Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce un numero");
            int numero = int.Parse(Console.ReadLine());
            //Creamos una variable float, para que en la division acepte resultados con decimales
            float numeroDividido = numero;
            //inicalizamos el numero de cifras del numero a 0
            int numeroCifras = 0;

            //realizaremos esta accion hasta que la division sea menor que 1
            while (numeroDividido > 1)
            {
                //dividimos el numero entre 10, si el resultado no es menor que 1, sumamos uno al numero de cifras
                numeroDividido = numeroDividido / 10;
                numeroCifras++;
            }

            Console.WriteLine($"El numero tienen {numeroCifras} cifras");
            Console.ReadKey();
        }
    }
}
