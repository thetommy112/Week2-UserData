using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma sünniaasta:");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - YearOfBirth;

            if(UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube taotleda.");
            }

            else if(UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube taotleda.");
            }

            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotleda.");
            }

            Console.WriteLine("End of script");
        }
    }
}
