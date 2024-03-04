using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTrainingCounter
{
    public class PairDetector
    {
        public string MessageWhenItsPair {  get; set; }

        public PairDetector(string message)
        {
            MessageWhenItsPair = message;
        }
        public void DisplayPairNumbers(object? sender, CounterEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" " + MessageWhenItsPair);
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
