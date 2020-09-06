using System;

namespace AF
{
    class KmToMiles
    {
        public void KmToMilesMethod(decimal temp_km)
        {
            decimal km = 1m;
            decimal mile = 0.621371m;

            ArtificialNeuron neuron = new ArtificialNeuron();

            Console.WriteLine(neuron.InputReceiver(km));

            double ProcedureNumber = 0;

            do
            {
                ProcedureNumber += 1;
                neuron.NeuronTraining(km, mile);
                if (ProcedureNumber % 10000000 == 0) Console.WriteLine($"Operation : {ProcedureNumber}  Misstep :{neuron.Misstep}");

            } while (neuron.Misstep > neuron.Smoothing || neuron.Misstep < -neuron.Smoothing);

            Console.WriteLine("USD to Euro neuron ready!");

            Console.WriteLine(value: $" in {temp_km}");
        }
    }
}