using System;
using static System.Console;


class Program
{
    static void Main()
    {
        
        WriteLine("Enter your day of birth : ");
        int day = int.Parse(ReadLine());

        WriteLine("Enter your month of birth : ");
        int month = int.Parse(ReadLine());

        WriteLine("Enter your year of birth : ");
        int year = int.Parse(ReadLine());

        DateTime birth = new DateTime(year, month, day, 0, 0, 0);

        
        while (true)
        {
            TimeSpan span = (DateTime.Now - birth);

            String dateOfBirth = string.Format("{0} days, {1} hours, {2} minues, {3} seconds",
            span.Days, span.Hours, span.Minutes, span.Seconds);

            WriteLine(dateOfBirth);

            System.Threading.Thread.Sleep(1000);

            Clear();

        }





    }
}