using System;
using AF;

namespace AF
{
    public class USDtoEuro
    {
        public void USDtoEuroMethod()
        {
            decimal dollar = 1m;
            decimal euro = 0.84m;

            ArtificialNeuron neuron = new ArtificialNeuron();

            Console.WriteLine(neuron.InputReceiver(dollar));

            double ProcedureNumber = 0;

            do
            {
                ProcedureNumber += 1;
                neuron.NeuronTraining(dollar, euro);
                if (ProcedureNumber % 10000000 == 0) Console.WriteLine($"Operation : {ProcedureNumber}  Misstep :{neuron.Misstep}");

            } while (neuron.Misstep > neuron.Smoothing || neuron.Misstep < -neuron.Smoothing);

            Console.WriteLine("USD to Euro neuron ready!");

            bool status = true;

            while (status)
            {
                Console.WriteLine("Choose ur option:\n1.Paste new number\n2.Leave");
                int Option = Convert.ToInt16(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        Console.WriteLine($"Dollar: ");
                        dollar = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"{neuron.InputReceiver(dollar)} euros in {dollar.ToString()} dollars");
                        break;
                    case 2:
                        status = false;
                        break;
                }
            }
        }
    }
}