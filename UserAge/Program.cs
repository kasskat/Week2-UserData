using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastal {YearOfBirth}";

            Console.WriteLine("Kui vana sa oled?");

            int UserAge = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - UserAge;

            Console.WriteLine($"Oled sündinud {YearOfBirth}. aastal.");
        }
    }
}
