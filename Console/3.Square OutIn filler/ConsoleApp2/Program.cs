using System;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Largeur du carré :");
            int width = int.Parse(ReadLine());

            WriteLine("Hauteur du carré :");
            int height = int.Parse(ReadLine());

            WriteLine("Caractère de remplissage :");
            string characterInner = ReadLine(); 

            WriteLine("Caractère du Côté :");
            string characterOuter = ReadLine();

            Square(width, height, characterOuter, characterInner);
        }

        static void Square(int width, int height, string characterOuter, string characterInner)
        {
            for (int row = 0; row < height; row++)
            {
                if (row == 0 || row == height - 1) //Top and Bot
                {
                    for(int col = 0; col < width; col++)
                    {
                        Write("{0} ", characterOuter );
                    }
                }
                else
                {
                    //Start Line
                    Write("{0} ", characterOuter);

                    for (int col = 0; col < width -2; col++)
                    {
                        Write("{0} ", characterInner);
                    }

                    //End line
                    Write("{0}", characterOuter);
                }
                WriteLine();
            }
        }
   
    }
}
