using System.ComponentModel;

namespace EigenTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayofweek = 2;
            DayOfWeek dow = DayOfWeek.Monday;
            DayOfWeek dow2 = (DayOfWeek)18;

            Console.WriteLine(dow);
            Console.WriteLine((int)dow);

        }
    }


    enum DayOfWeek: ulong
    {
        Sunday = 7,
        Monday =  1,
        Tuesday,
        Wednesday,        
        Thursday,
        Friday,
        Saturday         
    }

    [Flags]
    enum Rooms
    {       
        Kamer1,
        Kamer2,
        Kamer3
    }
}