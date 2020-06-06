using System;

namespace CodeNet27.Sesion01.Ejercicio03
{
    class Program
    {
        //Pedir el nombre de la semana al usuario y 
        //decirle si es fin de semana o no. En caso de error, indicarlo
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el dia de la semana (lunes, martes,miercoles,jueves,viernes,sabado o domingo");
            string dia = Console.ReadLine();

            if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
            {
                Console.WriteLine("no es fin de semana");
                Console.ReadKey();
            }
            else
            {
                if (dia == "sabado" || dia == "domingo")
                {
                    Console.WriteLine("Es fin de semana");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No existe el dia introducido");
                    Console.ReadKey();
                }
            }

        }
    }
}
