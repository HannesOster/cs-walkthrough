
using System.Security.Cryptography;

namespace HalloWelt
{
    class Program
    {
        static void Main()
        {
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
        }

    }
}