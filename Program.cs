
using System.Security.Cryptography;

namespace HalloWelt
{
    class Program
    {
        static void Main()
        {
            // boolsche Operatoren
            bool mobile = true;
            bool qualified = true;
            bool examPassed = false;
            bool shy = false;

            if (mobile && (qualified || examPassed) && !shy)
            {
                Console.WriteLine("Angenommen");
            }
            else
            {
                Console.WriteLine("Abgelehnt");
            }
            int number = 2;

            //switch
            switch(number)
            {
                case 0:
                    Console.WriteLine("Wert = ^0");
                    break;
                    case 1:
                    Console.WriteLine("Wert = 1");
                    break;
                case 2:
                    Console.WriteLine("Wert = 2");
                    break;
            }

            //Array
            string[] stuff = new string[3];

            stuff[0] = "Bucket";
            stuff[1] = "Box";
            stuff[2] = "Broom";

            Console.WriteLine(stuff[2]);

            //2D-Array
            string[,] weapons = new string[2, 2];

            weapons[0, 0] = "Longsword";
            weapons[0, 1] = "Sword";
            weapons[1, 0] = "Big Axe";
            weapons[1, 1] = "Axe";

            Console.WriteLine("Name: " + weapons[0,0]);
        }

    }
}