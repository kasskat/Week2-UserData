using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis 
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju Õnne! Nüüd sa saad juhilube taotleda";

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int DateOfBirth = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2021 - DateOfBirth;

            if (UserAge < 18)
            {
                Console.WriteLine("Kahjuks oled liiga noor, et juhilube saada.");
            }
            else if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad juhilube taotleda!");
            }

            Console.WriteLine("Küsimuste korral helista meie infoliinile.");
        }
    }
}
