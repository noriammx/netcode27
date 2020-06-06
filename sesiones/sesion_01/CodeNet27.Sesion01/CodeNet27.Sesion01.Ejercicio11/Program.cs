using System;

namespace CodeNet27.Sesion01.Ejercicio11
{
    //Crea un programa, que pida un número del 1 al 7, 
    //devuelva el día de la semana , teniendo en cuenta que el 1 es Lunes, hacer con un switch.
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("introduce un numero de 1 al 7");
            var numero = Console.ReadLine();
            int numeroSemana = int.Parse(numero);

            //comprobamos que el numero este comprendido entre 1 y 7
            if (numeroSemana > 7 || numeroSemana < 1)
            {
                Console.WriteLine("El numero es incorrecto");
                Console.ReadKey();
            }
            else
            {
                switch (numeroSemana)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
