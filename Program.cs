namespace EventTrainingCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter (15,26);
            PairDetector pairDetector = new PairDetector("Pair");

            counter.OnPair += pairDetector.DisplayPairNumbers;

            counter.StartCounter();
            Console.ReadLine();

        }
    }
}
