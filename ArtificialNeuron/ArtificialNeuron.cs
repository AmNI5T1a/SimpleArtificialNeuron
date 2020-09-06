namespace AF
{

    public class ArtificialNeuron
    {
        protected decimal weight = 0.6m;

        public decimal Smoothing { get; set; } = 0.0000001m;
        public decimal Misstep { get; protected set; }
        public decimal InputReceiver(decimal temp_input) => temp_input * weight;
        public decimal InputHandler(decimal temp_output) => temp_output / weight;

        public void NeuronTraining(decimal temp_input, decimal anticipated_result)
        {
            decimal actualresult = temp_input * weight;
            Misstep = anticipated_result - actualresult;
            decimal correction = (Misstep / actualresult) * Smoothing;
            weight += correction;
        }
    }
}