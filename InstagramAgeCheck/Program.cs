using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            Console.WriteLine("Palun, sisesta oma vanus:");

            int UserAge = Convert.ToInt32(Console.ReadLine());

            //programm kontrollib, kas kasutaja on 13 aastane või vanem
            if (UserAge > 13)
            {
                //Kui kasutaja on 13 aastane või vanem, siis ta võib Instagram'i kasutaja luua
                Console.WriteLine("Oled piisavalt vana, et Instagram'i konto luua.");
            }
            
            else if(UserAge < 13)
            {
                //Kui kasutaja on noorem, kui 13 siis ta on liiga noor
                Console.WriteLine("Oled liiga noor, et Instagram'i konto luua.");
            }
            
            else
            {
                Console.WriteLine("Oledki 13, nüüd saad endale Instagram'i konto luua.");
            }

            Console.WriteLine("Kena päeva!");




        }
    }
}
