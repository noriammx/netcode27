using System;

namespace CodeNet27.Sesion01
{
    //Crear 3 variables numéricas con el valor que tu quieras y en otra variable 
    //numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 2;
            int numero3 = 5;

            int sumaNumeros = numero1 + numero2 + numero3;

            Console.WriteLine("Hola Comunidad .NetCode27");
            Console.WriteLine("Resultado = " + sumaNumeros);
            Console.ReadKey();
        }
    }
}
