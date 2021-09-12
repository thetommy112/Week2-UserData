using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            
            //programm muudab konsooli sisestatud teksti taisarvuks;
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            
            //programm arvutab kasutaja vanuse;
            int UserAge = 2021 - YearOfBirth;

            //programm kuvab kasutaja vanust konsoolis;
            //Console.WriteLine("Oled " + UserAge + " aastat vana."); - algeline variant
            
            Console.WriteLine($"Oled {UserAge} aastat vana.");//string interpolation - lisa $teksti ette ja muutuja maara{}
        }
    }
}
