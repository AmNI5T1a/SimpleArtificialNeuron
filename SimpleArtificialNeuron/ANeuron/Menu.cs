using System;
using AF;

namespace AF
{
    class Program
    {
        static void Main()
        {
            bool status = true;
            while (status)
            {
                Console.WriteLine("Choose ur option: \n 1.USD to Euro\n 2.Km to miles\n 3.Kg to lbs \n 4.Exit");
                int ChoiceValue = Convert.ToInt32(Console.ReadLine());

                switch (ChoiceValue)
                {
                    //USD to Euro
                    case 1:
                        Console.WriteLine("Starting USD to Euro arti-neuron");
                        USDtoEuro MoneyConvertor = new USDtoEuro();
                        MoneyConvertor.USDtoEuroMethod();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Shutting down...");
                        status = false;
                        break;
                }
            }
        }
    }
}