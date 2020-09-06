using System;

namespace AF
{
    class KgToLBS
    {
        public void KgToLBSMethod(decimal temp_kg)
        {
            decimal kg = 1m;
            decimal lbs = 2.20462m;

            ArtificialNeuron neuron = new ArtificialNeuron();

            Console.WriteLine(neuron.InputReceiver(kg));

            double ProcedureNumber = 0;

            do
            {
                ProcedureNumber += 1;
                neuron.NeuronTraining(kg, lbs);
                if (ProcedureNumber % 10000000 == 0) Console.WriteLine($"Operation : {ProcedureNumber}  Misstep :{neuron.Misstep}");

            } while (neuron.Misstep > neuron.Smoothing || neuron.Misstep < -neuron.Smoothing);

            Console.WriteLine("USD to Euro neuron ready!");

            Console.WriteLine(value: $" in {temp_kg}");
        }
    }
}