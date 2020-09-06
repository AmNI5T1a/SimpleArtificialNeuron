using System;

namespace AF
{
    public class USDtoEuro
    {
        public void USDtoEuroMethod(decimal temp_dollar)
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

            Console.WriteLine(value: $" in {temp_dollar}");
        }
    }
}