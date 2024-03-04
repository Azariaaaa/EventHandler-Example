namespace EventTrainingCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter (0,30);
            PairDetector pairDetector = new PairDetector("Pair");

            counter.OnPair += pairDetector.DisplayPairNumbers;

            counter.StartCounter();
            Console.ReadLine();

        }
    }
}
