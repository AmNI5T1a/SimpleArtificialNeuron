using System;

namespace AN
{
    class Program
    {
        public static int ChoiceValue { get; private set; }

        static AF.USDtoEuro MoneyConvertor = new AF.USDtoEuro();

        

        static void Main()
        {
            Console.WriteLine("Choose ur option");

            ChoiceValue = Console.Read();

            switch (ChoiceValue)
            {
                //USD to Euro
                case 1:
                    MoneyConvertor.USDtoEuroMethod(ChoiceValue);
                    break;
                //Miles to km
                case 2:

                    break;
                //F to C
                case 3:

                    break;

            }
        }
    }
}
