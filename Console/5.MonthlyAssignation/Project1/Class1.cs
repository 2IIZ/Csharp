using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class1
    {


        //30 days // X participants // each day one participant 
        static void Main()
        {
            Random rnd = new Random();


            int participant = 3;
            int month = 30;
            int randomParticipant = 0;

            string[] participants = { "Ivan", "Coraly", "Matt", "Delphine", "Phoebe", "Chimuelo", "PtitLoup" };

            Console.WriteLine(participants[1]);


            int time = HowManyTimeTheyParticipate(month, participant);

            Console.WriteLine("Hello there");
            Console.WriteLine();

            int compteur = 0;
            bool ok = true;

            for (int day = 1; day <= month; day++)
            {
                while(ok)	    
                {
                    Console.WriteLine("Day {0} = {1}",day, participants[compteur]);
                    compteur++;
                    ok = false;
			    }
                if(compteur == participants.Length)
                {
                    compteur = 0;
                }
                ok = true;
            }
          
            

            Console.Write(time);

            Console.ReadLine();
        }

        static int HowManyTimeTheyParticipate(int month, int participant)
        {
            return month / participant;
        }
    }
}
