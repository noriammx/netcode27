using ImageToASCCIConverter;
using System;

namespace CodeNet27.Sesion01
{
    //Crear 3 variables numéricas con el valor que tu quieras y en otra variable 
    //numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLogoNetCode27 service = new ServiceLogoNetCode27();
            service.PrintLogo();

            int numero1 = 10;
            int numero2 = 2;
            int numero3 = 5;
            

            int sumaNumeros = numero3 + numero2 + numero3;           
            Console.WriteLine("Resultado = " + sumaNumeros);
        }
    }
}
