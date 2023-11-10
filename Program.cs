
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
        }

    }
}