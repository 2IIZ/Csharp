using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damier
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ok = false;

            for(int i = 0; i < 5; i++)
            {

                if (ok) { 
                    for(int r = 0; r < 5; r++)
                    {
                        Console.Write("X");
                        Console.Write(" ");
                    }
                }else if(!ok){
                    for (int r = 0; r < 5; r++)
                    {
                        Console.Write(" ");
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
                ok = !ok;
            }
        }
    }
}
