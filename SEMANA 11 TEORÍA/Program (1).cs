using System;

internal class Program
{
    static void Main()
    {

        Console.WriteLine("PROGRAMA DE VIVIENDA EN EL EDIFICIO");

        int[] nivel = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese la cantidad de personas totales en el nivel " + (i + 1) + " :");
            nivel[i] = int.Parse(Console.ReadLine());
        }

        int[] niños = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese la cantidad de niños en el nivel " + (i + 1) + " :");
            niños[i] = int.Parse(Console.ReadLine());
        }

        int[] mujeres = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese la cantidad de mujeres en el nivel " + (i + 1) + " :");
            mujeres[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("En el nivel " + (i + 1) + " hay  " + nivel[i] + " personas," + " hay  " + niños[i] + " niños," + " hay  " + mujeres[i] + " mujeres.");
        }

        if (niños[0] > niños[1] && niños[0] > niños[2] && niños[0] > niños[3] && niños[0] > niños[4])
        {
            Console.WriteLine("El nivel con más niños es el primer nivel. ");
        }

        if (niños[1] > niños[0] && niños[1] > niños[2] && niños[1] > niños[3] && niños[1] > niños[4])
        {
            Console.WriteLine("El nivel con más niños es el segundo nivel.");
        }

        if (niños[2] > niños[0] && niños[2] > niños[1] && niños[2] > niños[3] && niños[2] > niños[4])
        {
            Console.WriteLine("El nivel con más niños es el tercer nivel.");
        }

        if (niños[3] > niños[0] && niños[3] > niños[1] && niños[3] > niños[2] && niños[3] > niños[4])
        {
            Console.WriteLine("El nivel con más niños es el cuarto nivel.");
        }

        if (niños[4] > niños[0] && niños[4] > niños[1] && niños[4] > niños[2] && niños[4] > niños[3])
        {
            Console.WriteLine("El nivel con más niños es el quinto nivel.");
        }
    }
}