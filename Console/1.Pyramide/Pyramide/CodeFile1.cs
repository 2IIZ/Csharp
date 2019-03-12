using System;

class Program
{


    static void ConstruirePyramide(int P_pyramide)
    {
        for (int i = P_pyramide; i > 0; i--)
        {
            for (int o = 0; o < i; o++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    static void Main()
    {

        Console.WriteLine("How long do you want the pyramide ?");
        int pyramide = int.Parse(Console.ReadLine());

        ConstruirePyramide(pyramide);
    }


}