using System;

namespace CodeNet27.Sesion01.Ejercicio09
{
    class Program
    {
        //Crea un array e inserta los números pares del 1 al 100 en ese array.
        static void Main(string[] args)
        {
            //inicializamos el array
            int[] arrayInt = new int[50];

            //ponemos el indice a 0
            int index = 0;

            //recorremos el bucle comprobando los pares
            for (int i = 1; i < 101; i++)
            {
                //Si es multiplo de 2, ponemos en la posicion del indice el valor del numero
                if (i % 2 == 0)
                {
                    arrayInt[index] = i;

                    //Incrementamos el valor del indice a indice + 1
                    index++;
                }
            }

            //recorremos el array pintando los datos del array
            foreach (var numeroPar in arrayInt)
            {
                Console.WriteLine(numeroPar);
            }

            Console.ReadKey();
        }
    }
}
