using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            Console.WriteLine("Palun, sisesta oma vanus:");

            //programm muudab konsooli sisestatud teksti taisarvuks;
            int UserAge = Convert.ToInt32(Console.ReadLine());

            //programm arvutab kasutaja vanuse;
            int YearOfBirth = 2021 - UserAge;

            //programm kuvab kasutaja vanust konsoolis;
            Console.WriteLine($"Oled Sündinud aastal {YearOfBirth}.");//string interpolation - lisa $teksti ette ja muutuja maara{}
        }
    }
}
